using System.Windows.Forms;

namespace Instanalyzer.Helpers
{
    public class Engine
    {
        private static string _StartupPath = Application.StartupPath;
        public static string StartupPath
        {
            get
            {
                return _StartupPath;
            }
        }

        private static string _ExecutablePath = Application.ExecutablePath;
        public static string ExecutablePath
        {
            get
            {
                return _ExecutablePath;
            }
        }
    }
}