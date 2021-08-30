using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector_Updater {
    public partial class MainForm : MetroForm {
        public MainForm() {
            InitializeComponent();
        }

        public static string DownloadUrl;
        public string TempPath = $@"{Application.StartupPath}\Minecraft.Wii.U.Mod.Injector.Temp.exe";
        public string TargetPath = $@"{Application.StartupPath}\Minecraft.Wii.U.Mod.Injector.exe";

        private void StartDownloading(object sender, EventArgs e) {
            autoStart.Checked = Properties.Settings.Default.AutoStart;
            
            var wc = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            wc.DownloadProgressChanged += DownloadProgress;
            wc.DownloadFileCompleted += Completed;
            wc.DownloadFileAsync(new Uri(DownloadUrl), TempPath);
        }

        private void DownloadProgress(object sender, DownloadProgressChangedEventArgs e) {
            statusLabel.Text = string.Format("Downloading... [ {0}/{1} MB ]", (e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), (e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
            progressBar.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e) {
            if (e.Cancelled) {
                Console.WriteLine("Mod Injector download aborted");
            } else {
                if (File.Exists(TargetPath)) File.Delete(TargetPath);
                File.Move(TempPath, TargetPath);
                Console.WriteLine("Mod Injector download complete");
            }
            statusLabel.Text = "Finished!";
            if (autoStart.Checked) {
                Process.Start(TargetPath);
                Environment.Exit(0);
            } else {
                startButton.Enabled = true;
            }
        }

        private void ChangeAutoStart(object sender, EventArgs e) {
            if (autoStart.Checked)
                MessageBox.Show("The Mod Injector will now automatically start the next time the updater is run.", "AutoStart", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Properties.Settings.Default.AutoStart = autoStart.Checked;
            Properties.Settings.Default.Save();
        }

        private void Launch(object sender, EventArgs e) {
            Process.Start(TargetPath);
            Environment.Exit(0);
        }
    }
}