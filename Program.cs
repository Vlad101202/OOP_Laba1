using System;
using System.Windows.Forms;

namespace LiveWallPaper {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            if (StartChecker.IsRun()) return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            Holder.Init();
            DefaultWP.Start();

            Application.Run(new MainForm());
        }
    }                                                                       //here was Vlad101202 :D
}
