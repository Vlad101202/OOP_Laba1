using System.Diagnostics;
using System.Linq;

namespace LiveWallPaper {
    class StartChecker {
        public static bool IsRun() {
            var allProcess = from pr in Process.GetProcesses(".") select pr;
            int amt = 0;
            foreach (var proc in allProcess) {
                if (proc.ProcessName == "LiveWallPaper") amt++;
            }
            if (amt == 1) return false;
            else return true;
        }
    }
}