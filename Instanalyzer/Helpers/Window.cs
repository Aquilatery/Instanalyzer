namespace Instanalyzer.Helpers
{
    public class Window
    {
        public enum WindowType
        {
            Sign,
            Wait,
            Warn,
            Multi
        }

        private static bool _ActiveWindow = true;
        public static bool ActiveWindow
        {
            get => _ActiveWindow;
            set => _ActiveWindow = value;
        }

        private static WindowType _WindowMode = WindowType.Warn;
        public static WindowType WindowMode
        {
            get => _WindowMode;
            set
            {
                if (_WindowMode != value)
                {
                    ActiveWindow = true;
                }

                _WindowMode = value;
            }
        }
    }
}