namespace Instanalyzer.Helpers
{
    public static class Argument
    {
        public static char StartChar
        {
            get
            { 
                return '-';
            }
        }

        public static char StartBrackets
        {
            get
            {
                return '[';
            }
        }

        public static char EndBrackets
        {
            get
            {
                return ']';
            }
        }

        public static string[] ArgType
        {
            get
            {
                return new string[]
                {
                    "user"
                };
            }
        }

        private static string _ArgUser;
        public static string ArgUser
        {
            get
            {
                return _ArgUser;
            }
            set
            {
                _ArgUser = value;
            }
        }
    }
}