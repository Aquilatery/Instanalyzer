using System.IO;
using static Instanalyzer.Helpers.Engine;

namespace Instanalyzer.Helpers
{
    public static class Setting
    {
        private static string _DefaultPath = StartupPath;
        public static string DefaultPath
        {
            get
            {
                return _DefaultPath;
            }
            set
            {
                if (Directory.Exists(value))
                    _DefaultPath = value;
            }
        }

        private static string _ConfigFile = "Config.json";
        public static string ConfigFile
        {
            get
            {
                return _ConfigFile;
            }
        }

        private static string _UserFolder = "User";
        public static string UserFolder
        {
            get
            {
                return _UserFolder;
            }
            set
            {
                if (Directory.Exists(value))
                    _UserFolder = value;
            }
        }

        private static string _DownloadFolder = "Download";
        public static string DownloadFolder
        {
            get
            {
                return _DownloadFolder;
            }
            set
            {
                if (Directory.Exists(value))
                    _DownloadFolder = value;
            }
        }

        private static string _DownloadPPFolder = "PP";
        public static string DownloadPPFolder
        {
            get
            {
                return DownloadFolder + "\\" + _DownloadPPFolder;
            }
            set
            {
                value = DownloadFolder + "\\" + value;
                if (Directory.Exists(value))
                    _DownloadPPFolder = value;
            }
        }

        private static string _DownloadImageFolder = "Image";
        public static string DownloadImageFolder
        {
            get
            {
                return DownloadFolder + "\\" + _DownloadImageFolder;
            }
            set
            {
                value = DownloadFolder + "\\" + value;
                if (Directory.Exists(value))
                    _DownloadImageFolder = value;
            }
        }

        private static string _DownloadVideoFolder = "Video";
        public static string DownloadVideoFolder
        {
            get
            {
                return DownloadFolder + "\\" + _DownloadVideoFolder;
            }
            set
            {
                value = DownloadFolder + "\\" + value;
                if (Directory.Exists(value))
                    _DownloadVideoFolder = value;
            }
        }
    }
}