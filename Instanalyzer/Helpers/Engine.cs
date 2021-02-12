using System.Windows.Forms;

namespace Instanalyzer.Helpers
{
    public class Engine
    {
        private static readonly string _StartupPath = Application.StartupPath;
        public static string StartupPath => _StartupPath;

        private static readonly string _ExecutablePath = Application.ExecutablePath;
        public static string ExecutablePath => _ExecutablePath;
    }
}