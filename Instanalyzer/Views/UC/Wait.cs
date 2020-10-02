using Instanalyzer.Utils;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC
{
    public partial class Wait : UserControl
    {
        public Wait()
        {
            InitializeComponent();
            if (User.PPhoto != null)
                PP.Image = User.PPhoto;
            else
            {
                switch (User.Sex)
                {
                    case Helpers.Sex.SexType.Unknown:
                        PP.Image = Properties.Resources.Unknown;
                        break;
                    case Helpers.Sex.SexType.Female:
                        PP.Image = Properties.Resources.Female;
                        break;
                    case Helpers.Sex.SexType.Male:
                        PP.Image = Properties.Resources.Male;
                        break;
                }
            }
            UNNS.Text = User.Username + "\n" + User.Name + " " + User.Surname;
        }
    }
}