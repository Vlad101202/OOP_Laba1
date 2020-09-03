using System;
using System.Drawing;
using System.Windows.Forms;

namespace LiveWallPaper {
    public partial class DefaultWallpaperForm : Form {
        public DefaultWallpaperForm() {
            InitializeComponent();
            InputBox.Text = Properties.Settings.Default.DefaultWallpaperPath;
            if (DefaultWP.path.Length != 0) {
                InputBox.Text = DefaultWP.path;
                SaveAsFileButton.Enabled = true;
                SaveAsLinkButton.Enabled = DefaultWP.ValidationChecker();
            }
            else
                InputBox.Text = Properties.Settings.Default.DefaultWallpaperPath;

            if (Properties.Settings.Default.DefaultWallpaperStatus) {
                StatusButton.Text = "On";
                StatusButton.ForeColor = Color.Green;
            }
            else {
                StatusButton.Text = "Off";
                StatusButton.ForeColor = Color.Red;
            }
        }

        private void ChooseFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
            DefaultWP.path = openFileDialog.FileName;
            InputBox.Text = DefaultWP.path;
            SaveAsFileButton.Enabled = true;
            SaveAsLinkButton.Enabled = DefaultWP.ValidationChecker();
        }

        private void SaveAsFileButton_Click(object sender, EventArgs e) {
            DefaultWP.Saver("File");
            InputBox.Text = "File saved";
        }

        private void SaveAsLinkButton_Click(object sender, EventArgs e) {
            DefaultWP.Saver("Link");
            InputBox.Text = "Link saved";
        }

        private void StatusButton_Click(object sender, EventArgs e) {
            Properties.Settings.Default.DefaultWallpaperStatus = !Properties.Settings.Default.DefaultWallpaperStatus;
            if (Properties.Settings.Default.DefaultWallpaperStatus) {
                StatusButton.Text = "On";
                StatusButton.ForeColor = Color.Green;
            }
            else {
                StatusButton.Text = "Off";
                StatusButton.ForeColor = Color.Red;
            }
            Properties.Settings.Default.Save();
        }
    }
}
