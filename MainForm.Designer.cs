namespace Minecraft_Wii_U_Mod_Injector_Updater {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.injectorLogo = new System.Windows.Forms.PictureBox();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.statusLabel = new MetroFramework.Controls.MetroLabel();
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.startButton = new MetroFramework.Controls.MetroButton();
            this.autoStart = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.injectorLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // injectorLogo
            // 
            this.injectorLogo.Image = global::Minecraft_Wii_U_Mod_Injector_Updater.Properties.Resources.injector_1;
            this.injectorLogo.Location = new System.Drawing.Point(235, 36);
            this.injectorLogo.Name = "injectorLogo";
            this.injectorLogo.Size = new System.Drawing.Size(179, 143);
            this.injectorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.injectorLogo.TabIndex = 0;
            this.injectorLogo.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(23, 185);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(603, 24);
            this.progressBar.Style = MetroFramework.MetroColorStyle.Red;
            this.progressBar.TabIndex = 1;
            this.progressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // statusLabel
            // 
            this.statusLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.statusLabel.Location = new System.Drawing.Point(23, 212);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(603, 21);
            this.statusLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Preparing...";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.statusLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // titleLabel
            // 
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.titleLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titleLabel.Location = new System.Drawing.Point(164, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(321, 26);
            this.titleLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Minecraft Wii U Mod Injector Updater";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.titleLabel.UseCustomForeColor = true;
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(23, 236);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(603, 23);
            this.startButton.Style = MetroFramework.MetroColorStyle.Red;
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Launch!";
            this.startButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.startButton.UseSelectable = true;
            // 
            // autoStart
            // 
            this.autoStart.AutoSize = true;
            this.autoStart.Location = new System.Drawing.Point(23, 164);
            this.autoStart.Name = "autoStart";
            this.autoStart.Size = new System.Drawing.Size(144, 15);
            this.autoStart.Style = MetroFramework.MetroColorStyle.Red;
            this.autoStart.TabIndex = 4;
            this.autoStart.Text = "Automatically Launch?";
            this.autoStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.autoStart.UseSelectable = true;
            this.autoStart.CheckedChanged += new System.EventHandler(this.ChangeAutoStart);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 269);
            this.Controls.Add(this.autoStart);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.injectorLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.StartDownloading);
            ((System.ComponentModel.ISupportInitialize)(this.injectorLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox injectorLogo;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroLabel titleLabel;
        private MetroFramework.Controls.MetroButton startButton;
        private MetroFramework.Controls.MetroCheckBox autoStart;
    }
}

