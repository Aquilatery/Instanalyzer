using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static Instanalyzer.Utils.Engine;
using static Instanalyzer.Helpers.Setting;

namespace Instanalyzer.Utils
{
    public static class Setting
    {
        public static void Control(string Config)
        {
            Config = DefaultPath + "\\" + Config;
            if (!Files_Control(Config))
                Save(Config);
            Read(Config);
        }

        public static void Read(string Files)
        {

        }

        public static void Save(string Files)
        {

        }

        public static void Move(string Path1, string Path2)
        {
            //klasör konumu taşıma
        }
    }
}