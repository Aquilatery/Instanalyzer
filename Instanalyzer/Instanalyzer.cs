using System;
using System.Threading;
using Instanalyzer.Views;
using System.Windows.Forms;

namespace Instanalyzer
{
    static class Instanalyzer
    {
        private static readonly Mutex MTX = new Mutex(true, "{Soferity Instanalyzer - Instagram Analyzer}");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            #if NET5_0
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            #endif
            Application.SetCompatibleTextRenderingDefault(false);
            if (MTX.WaitOne(TimeSpan.Zero, true))
            {
                MTX.ReleaseMutex();
                Application.Run(new Login());
            }
            else
                MessageBox.Show("Already Open!", "Instanalyzer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}