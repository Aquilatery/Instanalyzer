using System;
using Instanalyzer.Views;
using System.Windows.Forms;

namespace Instanalyzer
{
    static class Instanalyzer
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            #if NET5_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            #endif
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Test());
        }
    }
}