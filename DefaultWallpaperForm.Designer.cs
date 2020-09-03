namespace LiveWallPaper {
    partial class DefaultWallpaperForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.InputBox = new System.Windows.Forms.TextBox();
            this.SaveAsFileButton = new System.Windows.Forms.Button();
            this.SaveAsLinkButton = new System.Windows.Forms.Button();
            this.ChooseFileButton = new System.Windows.Forms.Button();
            this.StatusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.BackColor = System.Drawing.Color.White;
            this.InputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputBox.Enabled = false;
            this.InputBox.Font = new System.Drawing.Font("Arial", 10F);
            this.InputBox.Location = new System.Drawing.Point(12, 12);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(354, 80);
            this.InputBox.TabIndex = 8;
            // 
            // SaveAsFileButton
            // 
            this.SaveAsFileButton.BackColor = System.Drawing.Color.White;
            this.SaveAsFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAsFileButton.Enabled = false;
            this.SaveAsFileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveAsFileButton.FlatAppearance.BorderSize = 0;
            this.SaveAsFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsFileButton.Font = new System.Drawing.Font("Arial", 10F);
            this.SaveAsFileButton.Location = new System.Drawing.Point(12, 152);
            this.SaveAsFileButton.Name = "SaveAsFileButton";
            this.SaveAsFileButton.Size = new System.Drawing.Size(170, 40);
            this.SaveAsFileButton.TabIndex = 9;
            this.SaveAsFileButton.Text = "Save as file";
            this.SaveAsFileButton.UseVisualStyleBackColor = false;
            this.SaveAsFileButton.Click += new System.EventHandler(this.SaveAsFileButton_Click);
            // 
            // SaveAsLinkButton
            // 
            this.SaveAsLinkButton.BackColor = System.Drawing.Color.White;
            this.SaveAsLinkButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveAsLinkButton.Enabled = false;
            this.SaveAsLinkButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.SaveAsLinkButton.FlatAppearance.BorderSize = 0;
            this.SaveAsLinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsLinkButton.Font = new System.Drawing.Font("Arial", 10F);
            this.SaveAsLinkButton.Location = new System.Drawing.Point(196, 152);
            this.SaveAsLinkButton.Name = "SaveAsLinkButton";
            this.SaveAsLinkButton.Size = new System.Drawing.Size(170, 40);
            this.SaveAsLinkButton.TabIndex = 10;
            this.SaveAsLinkButton.Text = "Save as link";
            this.SaveAsLinkButton.UseVisualStyleBackColor = false;
            this.SaveAsLinkButton.Click += new System.EventHandler(this.SaveAsLinkButton_Click);
            // 
            // ChooseFileButton
            // 
            this.ChooseFileButton.BackColor = System.Drawing.Color.White;
            this.ChooseFileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChooseFileButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ChooseFileButton.FlatAppearance.BorderSize = 0;
            this.ChooseFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseFileButton.Font = new System.Drawing.Font("Arial", 10F);
            this.ChooseFileButton.Location = new System.Drawing.Point(12, 106);
            this.ChooseFileButton.Name = "ChooseFileButton";
            this.ChooseFileButton.Size = new System.Drawing.Size(170, 40);
            this.ChooseFileButton.TabIndex = 11;
            this.ChooseFileButton.Text = "Choose file";
            this.ChooseFileButton.UseVisualStyleBackColor = false;
            this.ChooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // StatusButton
            // 
            this.StatusButton.BackColor = System.Drawing.Color.White;
            this.StatusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatusButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StatusButton.FlatAppearance.BorderSize = 0;
            this.StatusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatusButton.Font = new System.Drawing.Font("Arial", 10F);
            this.StatusButton.Location = new System.Drawing.Point(196, 106);
            this.StatusButton.Name = "StatusButton";
            this.StatusButton.Size = new System.Drawing.Size(170, 40);
            this.StatusButton.TabIndex = 12;
            this.StatusButton.UseVisualStyleBackColor = false;
            this.StatusButton.Click += new System.EventHandler(this.StatusButton_Click);
            // 
            // DefaultWallpaperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 204);
            this.Controls.Add(this.StatusButton);
            this.Controls.Add(this.ChooseFileButton);
            this.Controls.Add(this.SaveAsLinkButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.SaveAsFileButton);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 260);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 260);
            this.Name = "DefaultWallpaperForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose default wallpaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button SaveAsFileButton;
        private System.Windows.Forms.Button SaveAsLinkButton;
        private System.Windows.Forms.Button ChooseFileButton;
        private System.Windows.Forms.Button StatusButton;
    }
}