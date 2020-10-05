using System.Linq;
using static Instanalyzer.Helpers.Argument;

namespace Instanalyzer.Utils
{
    public static class Argument
    {
        public static void Explode(string[] Args)
        {
            foreach (string Arg in Args)
            {
                if (Arg.StartsWith(StartChar.ToString()) && Arg.EndsWith(EndBrackets.ToString()) && Arg.Count(C => C == StartChar) == 1 && Arg.Count(C => C == StartBrackets) == 1 && Arg.Count(C => C == EndBrackets) == 1)
                {
                    foreach (string Type in ArgType)
                    {
                        string Val1 = Arg.Substring(Arg.IndexOf(StartChar) + 1, Arg.IndexOf(StartBrackets) - 1);
                        if (Val1 == Type)
                        {
                            string Val2 = Arg.Substring(Arg.IndexOf(StartBrackets) + 1, Arg.IndexOf(EndBrackets) - Arg.IndexOf(StartBrackets) - 1);
                            if (Val1 == "user" && string.IsNullOrEmpty(ArgUser))
                                ArgUser = Val2;
                            break;
                        }
                    }
                }
            }
        }
    }
}