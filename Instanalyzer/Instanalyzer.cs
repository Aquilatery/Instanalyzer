using System;
using static Instanalyzer.Utils.Engine;

namespace Instanalyzer
{
    static class Instanalyzer
    {
        [STAThread]
        static void Main(string[] Args = null)
        {
            /*
                string Argt = null;
                foreach (string Arg in Args)
                    Argt = string.IsNullOrEmpty(Argt) ? Arg : "\n" + Arg;
                System.Windows.Forms.MessageBox.Show(Argt);
            */
            Start_Engine(Args);
        }
    }
}