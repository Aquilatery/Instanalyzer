using System;
using static Instanalyzer.Utils.Engine;

namespace Instanalyzer
{
    static class Instanalyzer
    {
        [STAThread]
        static void Main(string[] Args = null)
        {
            Start_Engine(Args);
        }
    }
}