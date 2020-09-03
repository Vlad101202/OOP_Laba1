using System;
using System.Windows.Forms;

namespace LiveWallPaper {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
            if (Properties.Settings.Default.RunMinimized) {
                HideAtStartCheckBox.Checked = true;
                Hide();
                NotifyIcon.Visible = true;
            }
            else {
                Show();
            }
            DebugCheckBox.Checked = Properties.Settings.Default.Debugger;
            PauseAtFullscreenCheckBox.Checked = Properties.Settings.Default.PauseAtFullscreen;
        }

        // Отладка

        private void DebuggerCheckBox_Click(object sender, EventArgs e) {
            Properties.Settings.Default.Debugger = DebugCheckBox.Checked;
            Properties.Settings.Default.Save();
            Debugger.Switch();
        }

        // Пауза при полноэкранном режиме

        private void PauseAtFullscreenCheckBox_Click(object sender, EventArgs e) {
            Properties.Settings.Default.PauseAtFullscreen = PauseAtFullscreenCheckBox.Checked;
            Properties.Settings.Default.Save();
            //Debugger.Print($"Change: {Properties.Settings.Default.PauseAtFullscreen}");
#pragma warning disable CS0612 // Тип или член устарел
            FullscreenChecker.Switch();
#pragma warning restore CS0612 // Тип или член устарел
        }

        // Запуск свёрнутым

        private void HideAtStartCheckBox_Click(object sender, EventArgs e) {
            Properties.Settings.Default.RunMinimized = HideAtStartCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        protected override void SetVisibleCore(bool value) {
            if (Properties.Settings.Default.RunMinimized) {
                base.SetVisibleCore(false);
            }
            else {
                base.SetVisibleCore(true);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            Holder.Close();
        }

        // Трей

        private void ToTray_Click(object sender, EventArgs e) {
            if (WindowState != FormWindowState.Minimized) {
                Hide();
                base.SetVisibleCore(false);
                NotifyIcon.Visible = true;
            }
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e) {
            Show();
            base.SetVisibleCore(true);
            WindowState = FormWindowState.Normal;
            NotifyIcon.Visible = false;
        }

        // Быстрые загрузки

        private void LoFiButton_Click(object sender, EventArgs e) {
            Holder.LoadFile("https://www.youtube.com/watch?v=5qap5aO4i9A");
        }

        private void DefaultPlaylistButton_Click(object sender, EventArgs e) {
            Holder.Command(@"loadlist C:\\LiveWallpapers");
        }

        // Элементы управления

        private void NextButton_Click(object sender, EventArgs e) {
            Holder.Command("playlist-next");
        }

        private void PrevButton_Click(object sender, EventArgs e) {
            Holder.Command("playlist-prev");
        }

        private void MuteToggleButton_Click(object sender, EventArgs e) {
            if (Holder.MuteToggle()) {
                MuteToggleButton.Text = "Mute";
            }
            else {
                MuteToggleButton.Text = "Unmute";
            }
        }

        private void LoopToggleButton_Click(object sender, EventArgs e) {
            if (Holder.LoopToggle()) {
                LoopToggleButton.Text = "Unloop";
            }
            else {
                LoopToggleButton.Text = "Loop";
            }
        }

        private void PauseToggleButton_Click(object sender, EventArgs e) {
            if (Holder.PauseToggle()) {
                PauseToggleButton.Text = "Continue";
            }
            else {
                PauseToggleButton.Text = "Pause";
            }
        }

        // Ввод текста

        private void InputBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                Holder.LoadFile(InputBox.Text);
                e.Handled = true;
            }
        }

        // Загрузка файла/каталога

        private void DefaultWallpaperFormButton_Click(object sender, EventArgs e) {
            Form form = new DefaultWallpaperForm();
            form.Show();
        }

        private void ChooseFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            InputBox.Text = openFileDialog.FileName;
            if (!Holder.LoadFile(openFileDialog.FileName)) {

            }
        }

        private void ChooseFolderButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.Cancel)
                return;
            InputBox.Text = folderBrowserDialog.SelectedPath;
            if (!Holder.LoadList(folderBrowserDialog.SelectedPath)) {
                InputBox.Text = "Путь до папки не должен содержать пробелы";
            }
        }

        // Регулирование скорости

        private void ResetButton_Click(object sender, EventArgs e) {
            Holder.Speed(0);
        }

        private void Faster1Button_Click(object sender, EventArgs e) {
            Holder.Speed(0.1);
        }

        private void Faster2Button_Click(object sender, EventArgs e) {
            Holder.Speed(0.5);
        }

        private void Slower1Button_Click(object sender, EventArgs e) {
            Holder.Speed(-0.1);
        }

        private void Slower2Button_Click(object sender, EventArgs e) {
            Holder.Speed(-0.5);
        }
    }
}
