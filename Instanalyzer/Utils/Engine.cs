using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static Instanalyzer.Helpers.Argument;
using static Instanalyzer.Helpers.Setting;
using static Instanalyzer.Utils.Argument;
using static Instanalyzer.Utils.Setting;

namespace Instanalyzer.Utils
{
    public static class Engine
    {
        private static readonly Mutex MTX = new(true, "{Soferity Instanalyzer - Instagram Analyzer}");

        public static void Start_Engine(string[] Args)
        {
            Application.EnableVisualStyles();
#if NETCOREAPP3_1 || NET5_0 || NET6_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
#endif
            Application.SetCompatibleTextRenderingDefault(false);
            if (MTX.WaitOne(TimeSpan.Zero, true))
            {
                MTX.ReleaseMutex();
                if (SEE_UI)
                {
                    if (Args != null)
                    {
                        Explode(Args);
                        if (!string.IsNullOrEmpty(ArgUser))
                        {
                            Helpers.Window.WindowMode = Helpers.Window.WindowType.Multi;
                        }
                        /*
   arg'da olan user eĞer remember olarak daha önceden girilmişse
   wait'e atıp direk giriş işlemini başlatabilirsin. ETC/Account da var örnek
*/
                    }
                    Application.Run(new Views.UI.Login());
                }
                else
                {
                    Application.Exit();
                    Environment.Exit(1);
                }
            }
            else
            {
                MessageBox.Show("Already Open!", "Instanalyzer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static bool SEE_UI
        {
            get
            {
                Control(ConfigFile);
                Folder_Control(UserFolder, true);
                Folder_Control(DownloadFolder, true);
                Folder_Control(DownloadPPFolder, true);
                Folder_Control(DownloadImageFolder, true);
                Folder_Control(DownloadVideoFolder, true);
                return true;
            }
        }

        public static bool Folder_Control(string Folder, bool Create = false)
        {
            Folder = DefaultPath + "\\" + Folder;
            if (!Directory.Exists(Folder))
            {
                if (Create)
                {
                    Directory.CreateDirectory(Folder);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Files_Control(string Files)
        {
            Files = DefaultPath + "\\" + Files;
            if (!File.Exists(Files))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}