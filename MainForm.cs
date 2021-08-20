using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector_Updater {
    public partial class MainForm : MetroForm {
        public MainForm() {
            InitializeComponent();
        }

        public string latestURL = "https://github.com/Kashiiera/Minecraft-Wii-U-Mod-Injector/releases/latest/download/Minecraft.Wii.U.Mod.Injector.exe";
        public string targetPath = $@"{Application.StartupPath}\Minecraft.Wii.U.Mod.Injector.exe";

        private void StartDownloading(object sender, EventArgs e) {
            autoStart.Checked = Properties.Settings.Default.AutoStart;

            var wc = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            wc.DownloadProgressChanged += DownloadProgress;
            wc.DownloadFileCompleted += Completed;
            wc.DownloadFileAsync(new Uri(latestURL), targetPath);
        }

        private void DownloadProgress(object sender, DownloadProgressChangedEventArgs e) {
            statusLabel.Text = string.Format("Downloading... [ {0}/{1} MB ]", (e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), (e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
            progressBar.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e) {
            if (e.Cancelled) {
                Console.WriteLine("Mod Injector download aborted");
            } else {
                Console.WriteLine("Mod Injector download complete");
            }
            statusLabel.Text = "Finished!";
            if (autoStart.Checked) {
                Process.Start(targetPath);
                Environment.Exit(0);
            } else {
                startButton.Enabled = true;
            }
        }

        private void ChangeAutoStart(object sender, EventArgs e) {
            Properties.Settings.Default.AutoStart = autoStart.Checked;
            Properties.Settings.Default.Save();
        }

        private void Launch(object sender, EventArgs e) {
            Process.Start(targetPath);
            Environment.Exit(0);
        }
    }
}
