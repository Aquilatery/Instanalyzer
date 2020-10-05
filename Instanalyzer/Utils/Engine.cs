using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Instanalyzer.Utils
{
    public static class Engine
    {
        private static readonly Mutex MTX = new Mutex(true, "{Soferity Instanalyzer - Instagram Analyzer}");

        public static void Start_Engine(string[] Args)
        {
            Application.EnableVisualStyles();
            #if NET5_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            #endif
            Application.SetCompatibleTextRenderingDefault(false);
            if (MTX.WaitOne(TimeSpan.Zero, true))
            {
                MTX.ReleaseMutex();
                if (SEE_UI)
                    Application.Run(new Views.UI.Login());
                else
                {
                    Application.Exit();
                    Environment.Exit(1);
                }
            }
            else
                MessageBox.Show("Already Open!", "Instanalyzer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static bool SEE_UI
        {
            get
            {
                Setting_Control("Config.dat");
                Folder_Control(Helpers.Setting.UserFolder, true);
                Folder_Control(Helpers.Setting.DownloadFolder, true);
                Folder_Control(Helpers.Setting.DownloadPPFolder, true);
                Folder_Control(Helpers.Setting.DownloadImageFolder, true);
                Folder_Control(Helpers.Setting.DownloadVideoFolder, true);
                return true;
            }
        }

        private static void Setting_Control(string Config)
        {
            Config = Helpers.Setting.DefaultPath + "\\" + Config;
            if (!Files_Control(Config))
                Setting.Save(Config);
            Setting.Read(Config);
        }

        private static bool Folder_Control(string Folder, bool Create = false)
        {
            Folder = Helpers.Setting.DefaultPath + "\\" + Folder;
            if (!Directory.Exists(Folder))
            {
                if (Create)
                    Directory.CreateDirectory(Folder);
                else
                    return false;
            }
            return true;
        }

        private static bool Files_Control(string Files)
        {
            Files = Helpers.Setting.DefaultPath + "\\" + Files;
            if (!File.Exists(Files))
                return false;
            else
                return true;
        }
    }
}