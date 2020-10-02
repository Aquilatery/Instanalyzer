using System.Drawing;
using Instanalyzer.Helpers;

namespace Instanalyzer.Utils
{
    public static class User
    {
        private static string _Name;
        public static string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        private static string _Surname;
        public static string Surname
        {
            get
            {
                return _Surname;
            }
            set
            {
                _Surname = value;
            }
        }

        private static string _Username;
        public static string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
            }
        }

        private static Image _PPhoto = null;
        public static Image PPhoto
        {
            get
            {
                return _PPhoto;
            }
            set
            {
                _PPhoto = value;
            }
        }

        private static Sex.SexType _Sex = Helpers.Sex.SexType.Unknown;
        public static Sex.SexType Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                _Sex = value;
            }
        }
    }
}