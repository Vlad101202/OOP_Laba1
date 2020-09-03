using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace LiveWallPaper {
    class FullscreenChecker {
        #region DllImport

        [DllImport("kernel32.dll")]
        static extern int GetProcessId(IntPtr handle);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetShellWindow();
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowRect(IntPtr hwnd, out RECT rc);
        [System.Runtime.InteropServices.DllImport("shell32.dll")]
        private static extern IntPtr SHAppBarMessage(int msg, ref APPBARDATA data);
        [DllImport("user32.dll")]
        public static extern UInt32 GetWindowThreadProcessId(IntPtr hwnd, ref Int32 pid);   

        #endregion

        public static Thread checker;
        public static void Init() {
            GetTaskbarLocation();
            GetTaskbarSize();
            pauseAtFullscreen = Properties.Settings.Default.PauseAtFullscreen;
            Debugger.Print(pauseAtFullscreen.ToString());
            checker = new Thread(FullscreenChecker.Checker);
            checker.Start();
#pragma warning disable CS0618 // Тип или член устарел
            if (!pauseAtFullscreen) {
                checker.Suspend();
#pragma warning restore CS0618 // Тип или член устарел
                Debugger.Print("Suspend");
            }
        }

        public static void Close() {
            if (pauseAtFullscreen) checker.Abort();
            else {
#pragma warning disable CS0618 // Тип или член устарел
                checker.Resume();
#pragma warning restore CS0618 // Тип или член устарел
                checker.Abort();
            }
        }

        private enum Direction { TOP, BOTTOM, LEFT, RIGHT };

        private struct Taskbar {
            public Direction Location;
            public int Width;
            public int Height;
        }

        private static Taskbar taskbar = new Taskbar();

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        private static IntPtr desktopHandle;    //Window handle for the desktop
        private static IntPtr shellHandle;      //Window handle for the shell
                                                //Get the handles for the desktop and shell now
        public static bool IsFull() {
            IntPtr hWnd;
            //Get the dimensions of the active window
            hWnd = GetForegroundWindow();
            int pid = 0;
            GetWindowThreadProcessId(hWnd, ref pid);
            if (Process.GetProcessById(pid).ProcessName == "explorer") {
                //Debugger.Print("explorer");
                return false;
            }

            desktopHandle = GetDesktopWindow();
            shellHandle = GetShellWindow();

            //GetTaskbarLocation();
            //GetTaskbarSize();

            bool runningFullScreen = false;
#pragma warning disable IDE0018 // Объявление встроенной переменной
            RECT appBounds;
#pragma warning restore IDE0018 // Объявление встроенной переменной
            Rectangle screenBounds;

            if (hWnd != null && !hWnd.Equals(IntPtr.Zero)) {
                //Check we haven't picked up the desktop or the shell
                if (!(hWnd.Equals(desktopHandle) || hWnd.Equals(shellHandle))) {
                    GetWindowRect(hWnd, out appBounds);
                    //Determine if window is fullscreen
                    screenBounds = Screen.FromHandle(hWnd).Bounds;

                    //Debugger.Clear();
                    //Debugger.Print($"TaskbarLocation: {taskbar.Location}");
                    //Debugger.Print($"TaskbarWidth:    {taskbar.Width}    TaskbarHeight: {taskbar.Height}");
                    //Debugger.Print($"ScreenBounds:    {screenBounds.Left} {screenBounds.Top} {screenBounds.Right} {screenBounds.Bottom}");
                    //Debugger.Print($"AppBounds:       {appBounds.left} {appBounds.top} {appBounds.right} {appBounds.bottom}");

                    switch (taskbar.Location) {
                        case Direction.TOP:
                            // Alt+Tab
                            if (
                                appBounds.top == taskbar.Height &&
                                appBounds.bottom == screenBounds.Bottom &&
                                appBounds.left == screenBounds.Left &&
                                appBounds.right == screenBounds.Right
                                ) return false;
                            // True
                            if (
                                appBounds.top <= taskbar.Height &&
                                appBounds.bottom >= screenBounds.Bottom &&
                                appBounds.left <= screenBounds.Left &&
                                appBounds.right >= screenBounds.Right
                                ) runningFullScreen = true;
                            break;
                        case Direction.LEFT:
                            // Alt+Tab
                            if (
                                appBounds.top == 0 &&
                                appBounds.bottom == screenBounds.Bottom &&
                                appBounds.left == taskbar.Width &&
                                appBounds.right == screenBounds.Right
                                ) return false;
                            // True
                            if (
                                appBounds.top <= 0 &&
                                appBounds.bottom >= screenBounds.Bottom &&
                                appBounds.left <= taskbar.Width &&
                                appBounds.right >= screenBounds.Right
                                ) runningFullScreen = true;
                            break;
                        case Direction.RIGHT:
                            // Alt+Tab
                            if (
                                appBounds.top == 0 &&
                                appBounds.bottom == screenBounds.Bottom &&
                                appBounds.left == screenBounds.Left &&
                                appBounds.right == screenBounds.Right - taskbar.Width
                                ) return false;
                            // True
                            if (
                                appBounds.top <= 0 &&
                                appBounds.bottom >= screenBounds.Bottom &&
                                appBounds.left <= screenBounds.Left &&
                                appBounds.right >= screenBounds.Right - taskbar.Width
                                ) runningFullScreen = true;
                            break;
                        default:
                            // Alt+Tab
                            if (
                                appBounds.top == 0 &&
                                (appBounds.bottom == screenBounds.Bottom - taskbar.Height) &&
                                appBounds.left == screenBounds.Left &&
                                appBounds.right == screenBounds.Right
                                ) return false;
                            // True
                            if (
                                appBounds.top <= 0 &&
                                (appBounds.bottom >= screenBounds.Bottom || appBounds.bottom >= screenBounds.Bottom - taskbar.Height) &&
                                appBounds.left <= screenBounds.Left &&
                                appBounds.right >= screenBounds.Right
                                ) runningFullScreen = true;
                            break;
                    }

                }
            }

            return (runningFullScreen);
        }

        // Update

        public static void Checker() {
            IntPtr hWnd, prevHWnd = IntPtr.Zero;
            bool fullscreen = false;
            while (true) {
                Thread.Sleep(500);
                hWnd = GetForegroundWindow();
                //Debugger.Print(hWnd.ToString());
                if (hWnd == prevHWnd) {
                    //Debugger.Print("Wait");
                    if (fullscreen) Thread.Sleep(5000);
                    continue;
                }
                prevHWnd = hWnd;
                if (IsFull()) {
                    Debugger.PrintW("Pause");
                    fullscreen = true;
                    Holder.Command("set pause yes");
                }
                else {
                    Debugger.PrintW("Continue");
                    fullscreen = false;
                    if (!Holder.pause) Holder.Command("set pause no");
                }
            }
        }

        private static bool pauseAtFullscreen;
        [Obsolete]
        public static void Switch() {
            pauseAtFullscreen = !pauseAtFullscreen;
            if (pauseAtFullscreen) {
                checker.Resume();
                Debugger.Print("Resume");
            }
            else {
                checker.Suspend();
                Debugger.Print("Suspend");

                Debugger.PrintW("Continue");
                if (!Holder.pause) Holder.Command("set pause no");
            }
        }

        // TaskBarSize

        private const int ABM_GETTASKBARPOS = 5;

        private struct APPBARDATA {
            public int cbSize;
            public IntPtr hWnd;
            public int uCallbackMessage;
            public int uEdge;
            public RECT rc;
            public IntPtr lParam;
        }

        public static void GetTaskbarSize() {
            APPBARDATA data = new APPBARDATA();
            data.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(data);
            SHAppBarMessage(ABM_GETTASKBARPOS, ref data);
            taskbar.Width = data.rc.right - data.rc.left;
            taskbar.Height = data.rc.bottom - data.rc.top;
        }

        // TaskBarLocation

        public static void GetTaskbarLocation() {
            Direction taskBarLocation = Direction.BOTTOM;
            bool taskBarOnTopOrBottom = (Screen.PrimaryScreen.WorkingArea.Width == Screen.PrimaryScreen.Bounds.Width);
            if (taskBarOnTopOrBottom) {
                if (Screen.PrimaryScreen.WorkingArea.Top > 0) taskBarLocation = Direction.TOP;
            }
            else {
                if (Screen.PrimaryScreen.WorkingArea.Left > 0) {
                    taskBarLocation = Direction.LEFT;
                }
                else {
                    taskBarLocation = Direction.RIGHT;
                }
            }
            taskbar.Location = taskBarLocation;
            Debugger.Print("Taskbar location: " + taskbar.Location.ToString());
        }
    }
}
