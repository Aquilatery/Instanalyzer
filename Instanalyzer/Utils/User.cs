using Instanalyzer.Helpers;
using System.Drawing;

namespace Instanalyzer.Utils
{
    public static class User
    {
        private static string _Name;
        public static string Name
        {
            get => _Name;
            set => _Name = value;
        }

        private static string _Surname;
        public static string Surname
        {
            get => _Surname;
            set => _Surname = value;
        }

        private static string _Username;
        public static string Username
        {
            get => _Username;
            set => _Username = value;
        }

        private static Image _PPhoto = null;
        public static Image PPhoto
        {
            get => _PPhoto;
            set => _PPhoto = value;
        }

        private static Sex.SexType _Sex = Helpers.Sex.SexType.Unknown;
        public static Sex.SexType Sex
        {
            get => _Sex;
            set => _Sex = value;
        }
    }
}