namespace LiveWallPaper {
    partial class MainForm {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.InputBox = new System.Windows.Forms.TextBox();
            this.LoFiButton = new System.Windows.Forms.Button();
            this.DefaultPlaylistButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HideAtStartCheckBox = new System.Windows.Forms.CheckBox();
            this.ToTray = new System.Windows.Forms.Label();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MuteToggleButton = new System.Windows.Forms.Button();
            this.LoopToggleButton = new System.Windows.Forms.Button();
            this.PauseToggleButton = new System.Windows.Forms.Button();
            this.DefaultWallpaperFormButton = new System.Windows.Forms.Button();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.ChooseFolderButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.Faster1Button = new System.Windows.Forms.Button();
            this.Faster2Button = new System.Windows.Forms.Button();
            this.Slower2Button = new System.Windows.Forms.Button();
            this.Slower1Button = new System.Windows.Forms.Button();
            this.DebugCheckBox = new System.Windows.Forms.CheckBox();
            this.PauseAtFullscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.BackColor = System.Drawing.Color.White;
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.NextButton.FlatAppearance.BorderSize = 0;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Arial", 10F);
            this.NextButton.Location = new System.Drawing.Point(196, 446);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(170, 40);
            this.NextButton.TabIndex = 14;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PrevButton.BackColor = System.Drawing.Color.White;
            this.PrevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PrevButton.FlatAppearance.BorderSize = 0;
            this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton.Font = new System.Drawing.Font("Arial", 10F);
            this.PrevButton.Location = new System.Drawing.Point(12, 446);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(170, 40);
            this.PrevButton.TabIndex = 13;
            this.PrevButton.Text = "Prev";
            this.PrevButton.UseVisualStyleBackColor = false;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // InputBox
            // 
            this.InputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputBox.BackColor = System.Drawing.Color.White;
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBox.Font = new System.Drawing.Font("Arial", 10F);
            this.InputBox.Location = new System.Drawing.Point(12, 46);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(354, 80);
            this.InputBox.TabIndex = 0;
            this.InputBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputBox_KeyPress);
            // 
            // LoFiButton
            // 
            this.LoFiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoFiButton.BackColor = System.Drawing.Color.White;
            this.LoFiButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoFiButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoFiButton.FlatAppearance.BorderSize = 0;
            this.LoFiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoFiButton.Font = new System.Drawing.Font("Arial", 10F);
            this.LoFiButton.Location = new System.Drawing.Point(196, 400);
            this.LoFiButton.Name = "LoFiButton";
            this.LoFiButton.Size = new System.Drawing.Size(170, 40);
            this.LoFiButton.TabIndex = 12;
            this.LoFiButton.Text = "lofi hip hop radio";
            this.LoFiButton.UseVisualStyleBackColor = false;
            this.LoFiButton.Click += new System.EventHandler(this.LoFiButton_Click);
            // 
            // DefaultPlaylistButton
            // 
            this.DefaultPlaylistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultPlaylistButton.BackColor = System.Drawing.Color.White;
            this.DefaultPlaylistButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultPlaylistButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DefaultPlaylistButton.FlatAppearance.BorderSize = 0;
            this.DefaultPlaylistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultPlaylistButton.Font = new System.Drawing.Font("Arial", 10F);
            this.DefaultPlaylistButton.Location = new System.Drawing.Point(12, 400);
            this.DefaultPlaylistButton.Name = "DefaultPlaylistButton";
            this.DefaultPlaylistButton.Size = new System.Drawing.Size(170, 40);
            this.DefaultPlaylistButton.TabIndex = 11;
            this.DefaultPlaylistButton.Text = "Default playlist";
            this.DefaultPlaylistButton.UseVisualStyleBackColor = false;
            this.DefaultPlaylistButton.Click += new System.EventHandler(this.DefaultPlaylistButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.HideAtStartCheckBox);
            this.panel1.Controls.Add(this.ToTray);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 40);
            this.panel1.TabIndex = 7;
            // 
            // HideAtStartCheckBox
            // 
            this.HideAtStartCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HideAtStartCheckBox.Location = new System.Drawing.Point(0, 0);
            this.HideAtStartCheckBox.Name = "HideAtStartCheckBox";
            this.HideAtStartCheckBox.Size = new System.Drawing.Size(40, 40);
            this.HideAtStartCheckBox.TabIndex = 1;
            this.HideAtStartCheckBox.UseVisualStyleBackColor = true;
            this.HideAtStartCheckBox.Click += new System.EventHandler(this.HideAtStartCheckBox_Click);
            // 
            // ToTray
            // 
            this.ToTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToTray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToTray.Font = new System.Drawing.Font("Arial", 12F);
            this.ToTray.ForeColor = System.Drawing.Color.White;
            this.ToTray.Location = new System.Drawing.Point(0, 0);
            this.ToTray.Name = "ToTray";
            this.ToTray.Size = new System.Drawing.Size(378, 40);
            this.ToTray.TabIndex = 0;
            this.ToTray.Text = "Hide in tray";
            this.ToTray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ToTray.Click += new System.EventHandler(this.ToTray_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "LiveWallPaper";
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // MuteToggleButton
            // 
            this.MuteToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MuteToggleButton.BackColor = System.Drawing.Color.White;
            this.MuteToggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MuteToggleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MuteToggleButton.FlatAppearance.BorderSize = 0;
            this.MuteToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuteToggleButton.Font = new System.Drawing.Font("Arial", 10F);
            this.MuteToggleButton.Location = new System.Drawing.Point(196, 354);
            this.MuteToggleButton.Name = "MuteToggleButton";
            this.MuteToggleButton.Size = new System.Drawing.Size(170, 40);
            this.MuteToggleButton.TabIndex = 10;
            this.MuteToggleButton.Text = "Unmute";
            this.MuteToggleButton.UseVisualStyleBackColor = false;
            this.MuteToggleButton.Click += new System.EventHandler(this.MuteToggleButton_Click);
            // 
            // LoopToggleButton
            // 
            this.LoopToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LoopToggleButton.BackColor = System.Drawing.Color.White;
            this.LoopToggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoopToggleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoopToggleButton.FlatAppearance.BorderSize = 0;
            this.LoopToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoopToggleButton.Font = new System.Drawing.Font("Arial", 10F);
            this.LoopToggleButton.Location = new System.Drawing.Point(12, 354);
            this.LoopToggleButton.Name = "LoopToggleButton";
            this.LoopToggleButton.Size = new System.Drawing.Size(170, 40);
            this.LoopToggleButton.TabIndex = 9;
            this.LoopToggleButton.Text = "Unloop";
            this.LoopToggleButton.UseVisualStyleBackColor = false;
            this.LoopToggleButton.Click += new System.EventHandler(this.LoopToggleButton_Click);
            // 
            // PauseToggleButton
            // 
            this.PauseToggleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseToggleButton.BackColor = System.Drawing.Color.White;
            this.PauseToggleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PauseToggleButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.PauseToggleButton.FlatAppearance.BorderSize = 0;
            this.PauseToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseToggleButton.Font = new System.Drawing.Font("Arial", 10F);
            this.PauseToggleButton.Location = new System.Drawing.Point(12, 492);
            this.PauseToggleButton.Name = "PauseToggleButton";
            this.PauseToggleButton.Size = new System.Drawing.Size(354, 40);
            this.PauseToggleButton.TabIndex = 15;
            this.PauseToggleButton.Text = "Pause";
            this.PauseToggleButton.UseVisualStyleBackColor = false;
            this.PauseToggleButton.Click += new System.EventHandler(this.PauseToggleButton_Click);
            // 
            // DefaultWallpaperFormButton
            // 
            this.DefaultWallpaperFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DefaultWallpaperFormButton.BackColor = System.Drawing.Color.White;
            this.DefaultWallpaperFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefaultWallpaperFormButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.DefaultWallpaperFormButton.FlatAppearance.BorderSize = 0;
            this.DefaultWallpaperFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DefaultWallpaperFormButton.Font = new System.Drawing.Font("Arial", 10F);
            this.DefaultWallpaperFormButton.Location = new System.Drawing.Point(12, 308);
            this.DefaultWallpaperFormButton.Name = "DefaultWallpaperFormButton";
            this.DefaultWallpaperFormButton.Size = new System.Drawing.Size(354, 40);
            this.DefaultWallpaperFormButton.TabIndex = 8;
            this.DefaultWallpaperFormButton.Text = "Default wallpaper";
            this.DefaultWallpaperFormButton.UseVisualStyleBackColor = false;
            this.DefaultWallpaperFormButton.Click += new System.EventHandler(this.DefaultWallpaperFormButton_Click);
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseFileButton.BackColor = System.Drawing.Color.White;
            this.ChooseFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseFileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChooseFileButton.FlatAppearance.BorderSize = 0;
            this.ChooseFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFileButton.Font = new System.Drawing.Font("Arial", 10F);
            this.ChooseFileButton.Location = new System.Drawing.Point(12, 132);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(170, 40);
            this.ChooseFileButton.TabIndex = 1;
            this.ChooseFileButton.Text = "Choose file";
            this.ChooseFileButton.UseVisualStyleBackColor = false;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // ChooseFolderButton
            // 
            this.ChooseFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ChooseFolderButton.BackColor = System.Drawing.Color.White;
            this.ChooseFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseFolderButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChooseFolderButton.FlatAppearance.BorderSize = 0;
            this.ChooseFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFolderButton.Font = new System.Drawing.Font("Arial", 10F);
            this.ChooseFolderButton.Location = new System.Drawing.Point(196, 132);
            this.ChooseFolderButton.Name = "ChooseFolderButton";
            this.ChooseFolderButton.Size = new System.Drawing.Size(170, 40);
            this.ChooseFolderButton.TabIndex = 2;
            this.ChooseFolderButton.Text = "Choose folder";
            this.ChooseFolderButton.UseVisualStyleBackColor = false;
            this.ChooseFolderButton.Click += new System.EventHandler(this.ChooseFolderButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.White;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Arial", 10F);
            this.ResetButton.Location = new System.Drawing.Point(142, 178);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(94, 40);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "=";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Faster1Button
            // 
            this.Faster1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Faster1Button.BackColor = System.Drawing.Color.White;
            this.Faster1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Faster1Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Faster1Button.FlatAppearance.BorderSize = 0;
            this.Faster1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Faster1Button.Font = new System.Drawing.Font("Arial", 10F);
            this.Faster1Button.Location = new System.Drawing.Point(242, 178);
            this.Faster1Button.Name = "Faster1Button";
            this.Faster1Button.Size = new System.Drawing.Size(40, 40);
            this.Faster1Button.TabIndex = 6;
            this.Faster1Button.Text = ">";
            this.Faster1Button.UseVisualStyleBackColor = false;
            this.Faster1Button.Click += new System.EventHandler(this.Faster1Button_Click);
            // 
            // Faster2Button
            // 
            this.Faster2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Faster2Button.BackColor = System.Drawing.Color.White;
            this.Faster2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Faster2Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Faster2Button.FlatAppearance.BorderSize = 0;
            this.Faster2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Faster2Button.Font = new System.Drawing.Font("Arial", 10F);
            this.Faster2Button.Location = new System.Drawing.Point(288, 178);
            this.Faster2Button.Name = "Faster2Button";
            this.Faster2Button.Size = new System.Drawing.Size(78, 40);
            this.Faster2Button.TabIndex = 7;
            this.Faster2Button.Text = ">>";
            this.Faster2Button.UseVisualStyleBackColor = false;
            this.Faster2Button.Click += new System.EventHandler(this.Faster2Button_Click);
            // 
            // Slower2Button
            // 
            this.Slower2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Slower2Button.BackColor = System.Drawing.Color.White;
            this.Slower2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Slower2Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Slower2Button.FlatAppearance.BorderSize = 0;
            this.Slower2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slower2Button.Font = new System.Drawing.Font("Arial", 10F);
            this.Slower2Button.Location = new System.Drawing.Point(12, 178);
            this.Slower2Button.Name = "Slower2Button";
            this.Slower2Button.Size = new System.Drawing.Size(78, 40);
            this.Slower2Button.TabIndex = 3;
            this.Slower2Button.Text = "<<";
            this.Slower2Button.UseVisualStyleBackColor = false;
            this.Slower2Button.Click += new System.EventHandler(this.Slower2Button_Click);
            // 
            // Slower1Button
            // 
            this.Slower1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Slower1Button.BackColor = System.Drawing.Color.White;
            this.Slower1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Slower1Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Slower1Button.FlatAppearance.BorderSize = 0;
            this.Slower1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Slower1Button.Font = new System.Drawing.Font("Arial", 10F);
            this.Slower1Button.Location = new System.Drawing.Point(96, 178);
            this.Slower1Button.Name = "Slower1Button";
            this.Slower1Button.Size = new System.Drawing.Size(40, 40);
            this.Slower1Button.TabIndex = 4;
            this.Slower1Button.Text = "<";
            this.Slower1Button.UseVisualStyleBackColor = false;
            this.Slower1Button.Click += new System.EventHandler(this.Slower1Button_Click);
            // 
            // DebugCheckBox
            // 
            this.DebugCheckBox.AutoSize = true;
            this.DebugCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DebugCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DebugCheckBox.Location = new System.Drawing.Point(12, 224);
            this.DebugCheckBox.Name = "DebugCheckBox";
            this.DebugCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.DebugCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DebugCheckBox.Size = new System.Drawing.Size(96, 42);
            this.DebugCheckBox.TabIndex = 2;
            this.DebugCheckBox.Text = "Debug";
            this.DebugCheckBox.UseVisualStyleBackColor = true;
            this.DebugCheckBox.Click += new System.EventHandler(this.DebuggerCheckBox_Click);
            // 
            // PauseAtFullscreenCheckBox
            // 
            this.PauseAtFullscreenCheckBox.AutoSize = true;
            this.PauseAtFullscreenCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PauseAtFullscreenCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PauseAtFullscreenCheckBox.Location = new System.Drawing.Point(114, 224);
            this.PauseAtFullscreenCheckBox.Name = "PauseAtFullscreenCheckBox";
            this.PauseAtFullscreenCheckBox.Padding = new System.Windows.Forms.Padding(10);
            this.PauseAtFullscreenCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PauseAtFullscreenCheckBox.Size = new System.Drawing.Size(180, 42);
            this.PauseAtFullscreenCheckBox.TabIndex = 16;
            this.PauseAtFullscreenCheckBox.Text = "Pause at fullscreen";
            this.PauseAtFullscreenCheckBox.UseVisualStyleBackColor = true;
            this.PauseAtFullscreenCheckBox.Click += new System.EventHandler(this.PauseAtFullscreenCheckBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 544);
            this.Controls.Add(this.PauseAtFullscreenCheckBox);
            this.Controls.Add(this.DebugCheckBox);
            this.Controls.Add(this.Slower1Button);
            this.Controls.Add(this.Slower2Button);
            this.Controls.Add(this.Faster2Button);
            this.Controls.Add(this.Faster1Button);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ChooseFolderButton);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.DefaultWallpaperFormButton);
            this.Controls.Add(this.PauseToggleButton);
            this.Controls.Add(this.LoopToggleButton);
            this.Controls.Add(this.MuteToggleButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DefaultPlaylistButton);
            this.Controls.Add(this.LoFiButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.NextButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LiveWallPaper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button LoFiButton;
        private System.Windows.Forms.Button DefaultPlaylistButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ToTray;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.Button MuteToggleButton;
        private System.Windows.Forms.Button LoopToggleButton;
        private System.Windows.Forms.Button PauseToggleButton;
        private System.Windows.Forms.Button DefaultWallpaperFormButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Button ChooseFolderButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button Faster1Button;
        private System.Windows.Forms.Button Faster2Button;
        private System.Windows.Forms.Button Slower2Button;
        private System.Windows.Forms.Button Slower1Button;
        private System.Windows.Forms.CheckBox HideAtStartCheckBox;
        private System.Windows.Forms.CheckBox DebugCheckBox;
        private System.Windows.Forms.CheckBox PauseAtFullscreenCheckBox;
    }
}

