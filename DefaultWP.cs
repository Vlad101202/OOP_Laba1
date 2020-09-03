using System.IO;
using System.Threading;

namespace LiveWallPaper {
    class DefaultWP {
        public static string path = "";

        public static bool ValidationChecker() {
            if (path.Contains(" ")) return false;
            return true;
        }

        public static void Start() {
            Thread.Sleep(500);
            if (Properties.Settings.Default.DefaultWallpaperStatus) {
                if (Properties.Settings.Default.DefaultWallpaperSaveFile) {
                    if (Directory.GetFiles(@"cache\defaultWallpaper").Length != 0)
                        Holder.LoadList(@"cache\defaultWallpaper");
                }
                else {
                    if (File.Exists(Properties.Settings.Default.DefaultWallpaperPath))
                        Holder.LoadFile(Properties.Settings.Default.DefaultWallpaperPath);
                    else {
                        Properties.Settings.Default.DefaultWallpaperPath = "";
                    }
                }
            }
        }

        public static void Saver(string type) {
            switch (type) {
                case "Link":
                    Properties.Settings.Default.DefaultWallpaperPath = path;
                    Properties.Settings.Default.DefaultWallpaperSaveFile = false;
                    Properties.Settings.Default.Save();
                    break;
                case "File":
                    File.Delete(@"cache\defaultWallpaper\default");
                    File.Copy(path, @"cache\defaultWallpaper\default");
                    Properties.Settings.Default.DefaultWallpaperSaveFile = true;
                    Properties.Settings.Default.Save();
                    break;
                default:
                    break;
            }
        }
    }
}
