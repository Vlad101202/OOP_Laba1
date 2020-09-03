using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LiveWallPaper {
    class Debugger {
        #region DllImport

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        static extern bool FreeConsole();

        #endregion

        public static bool debug = false;
        private static bool attached = false;
        private static DebuggerForm form;

        public static void Init() {
            if (Properties.Settings.Default.Debugger) {
                debug = true;
                Attach();
                On();
            }
        }

        private static bool Attach() {
            if (!attached) {
                AllocConsole();
                attached = true;
                return true;
            }
            return false;
        }

        private static void On() {
            form = new DebuggerForm();
            form.Show();
            debug = true;
            Print("Debug On");
        }

        private static void Off() {
            form.Close();
            Print("Debug Off");
            debug = false;
        }

        public static bool Switch() {
            if (Properties.Settings.Default.Debugger) {
                On();
                return true;
            }
            else {
                Off();
                return false;
            }
        }

        public static void Print(string text) {
            if (debug) {
                if (!attached) Attach();
                Console.WriteLine(text);
            }
        }

        public static void Clear() {
            if (debug)
                Console.Clear();
        }

        public static void PrintW(string text) {
            if (debug) {
                form.LogLabel.Text = text;
            }
        }
    }
}
