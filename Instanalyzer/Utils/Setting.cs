using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static Instanalyzer.Helpers.Setting;
using static Instanalyzer.Utils.Engine;

namespace Instanalyzer.Utils
{
    public static class Setting
    {
        public static void Control(string Config)
        {
            if (!Files_Control(Config))
            {
                Save(Config);
            }

            Config = DefaultPath + "\\" + Config;
            Read(Config);
        }

        public static void Read(string Files)
        {
            Dictionary<string, string> Settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(Files));
            if (Settings.ContainsKey("DefaultPath") && Settings.ContainsKey("UserFolder") && Settings.ContainsKey("DownloadFolder") && Settings.ContainsKey("DownloadPPFolder") && Settings.ContainsKey("DownloadImageFolder") && Settings.ContainsKey("DownloadVideoFolder"))
            {
                DefaultPath = Settings["DefaultPath"];
                UserFolder = Settings["UserFolder"];
                DownloadFolder = Settings["DownloadFolder"];
                DownloadPPFolder = Settings["DownloadPPFolder"];
                DownloadImageFolder = Settings["DownloadImageFolder"];
                DownloadVideoFolder = Settings["DownloadVideoFolder"];
            }
            else
            {
                Save(Files);
            }
        }

        public static void Save(string Files)
        {
            Dictionary<string, string> Settings = new()
            {
                { "DefaultPath", DefaultPath },
                { "UserFolder", UserFolder },
                { "DownloadFolder", DownloadFolder },
                { "DownloadPPFolder", DownloadPPFolder.Replace(DownloadFolder + "\\", "") },
                { "DownloadImageFolder", DownloadImageFolder.Replace(DownloadFolder + "\\", "") },
                { "DownloadVideoFolder", DownloadVideoFolder.Replace(DownloadFolder + "\\", "") }
            };
            File.WriteAllText(Files, JsonConvert.SerializeObject(Settings, Formatting.Indented));
        }

        public static void Move(string Path1, string Path2)
        {
            //klasör konumu taşıma
        }
    }
}