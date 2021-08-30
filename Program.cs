using System;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector_Updater {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
                MainForm.DownloadUrl = "https://github.com/Kashiiera/Minecraft-Wii-U-Mod-Injector/releases/latest/download/Minecraft.Wii.U.Mod.Injector.exe";
            else
                MainForm.DownloadUrl = "https://github.com/Kashiiera/Minecraft-Wii-U-Mod-Injector/releases/" + args[0] + "/download/Minecraft.Wii.U.Mod.Injector.exe";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}