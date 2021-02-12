namespace Instanalyzer.Helpers
{
    public static class Argument
    {
        public static char StartChar => '-';

        public static char StartBrackets => '[';

        public static char EndBrackets => ']';

        public static string[] ArgType => new string[]
                {
                    "user"
                };

        private static string _ArgUser;
        public static string ArgUser
        {
            get => _ArgUser;
            set => _ArgUser = value;
        }
    }
}