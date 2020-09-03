using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Runtime.InteropServices;

namespace LiveWallPaper {
    class Holder {
        #region DllImport

       

        #endregion

        private static Process cmd;
        private static ProcessStartInfo startInfo;
        protected static void CustomConsole(string command) {
            startInfo.Arguments = "/C " + command;
            cmd.StartInfo = startInfo;
            cmd.Start();
        }

        public static void Command(string command) {
            CustomConsole("wp mpv " + command);
        }

        #region InitRegion

        public static void Init() {
            Debugger.Init();
            InitFolder();
            InitCMD();
            InitMPV();
            FullscreenChecker.Init();
        }

        protected static void InitCMD() {
            cmd = new Process();
            startInfo = new ProcessStartInfo {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe"
            };
        }

        static bool IsProcessRun(string search) {
            var allProcess = from pr in Process.GetProcesses(".") select pr;
            foreach (var proc in allProcess) {
                if (proc.ProcessName == search) return true;
            }
            return false;
        }
        protected static void InitMPV() {
            if (!IsProcessRun("mpv")) {
                CustomConsole(@"wp run mpv --mute=yes --player-operation-mode=pseudo-gui --force-window=yes --terminal=no --loop-file=yes --loop-playlist=inf --input-ipc-server=\\.\pipe\mpvsocket");
                Thread.Sleep(50);
                CustomConsole("wp add --wait --fullscreen --class mpv");
                Thread.Sleep(200);
                Command("loadlist C:\\LiveWallpapers");
            }
            else {
                CustomConsole("wp mpv quit");
                InitMPV();
            }
        }

        protected static void InitFolder() {
            Directory.CreateDirectory(@"C:\LiveWallpapers");
            Directory.CreateDirectory(@"cache");
            Directory.CreateDirectory(@"cache\badpath");
            Directory.CreateDirectory(@"cache\defaultWallpaper");
        }

        #endregion
        #region MediaControlRegion

        private static bool mute = false;
        public static bool MuteToggle() {
            mute = !mute;
            if (mute) Command("set mute no");
            else Command("set mute yes");
            return mute;
        }

        private static bool loop = true;
        public static bool LoopToggle() {
            loop = !loop;
            if (loop) Command("set loop yes");
            else Command("set loop no");
            return loop;
        }

        public static bool pause = false;
        public static bool PauseToggle() {
            pause = !pause;
            if (pause) Command("set pause yes");
            else Command("set pause no");
            return pause;
        }

        private static double speed = 1;
        public static void Speed(double value) {
            if (value == 0) speed = 1;
            speed += value;
            if (speed <= 0) speed = 0.1;
            Command("set speed " + speed.ToString().Replace(',', '.'));
        }

        #endregion
        #region FilesConrolRegion

        public static bool LoadFile(string path) {
            if (path.Contains(" ")) {
                if (File.Exists(path)) {
                    File.Delete(@"cache\badpath\tmpfile");
                    File.Copy(path, @"cache\badpath\tmpfile");
                    LoadFile(@"cache\badpath\tmpfile");
                    return true;
                }
                else return false;
            }

            Command("loadfile \"" + path + "\"");
            return true;
        }

        public static bool LoadList(string path) {
            if (path.Contains(" ")) {
                return false;
            }

            Command("loadlist \"" + path + "\"");
            return true;
        }

        #endregion

        public static void Close() {
            FullscreenChecker.Close();
            CustomConsole("wp mpv quit");
            Thread.Sleep(50);
            CustomConsole("wp ls");
            cmd.Close();
        }
    }
}