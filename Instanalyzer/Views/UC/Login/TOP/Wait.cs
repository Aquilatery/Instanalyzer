using Instanalyzer.Utils;
using System;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC.Login.TOP
{
    public partial class Wait : UserControl
    {
        private int DOT = 1;

        public Wait()
        {
            InitializeComponent();
            if (User.PPhoto != null)
            {
                PP.Image = User.PPhoto;
            }
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

        private void DOTT_Tick(object sender, EventArgs e)
        {
            switch (DOT++)
            {
                case 1:
                case 2:
                    WMLBL.Text += ".";
                    break;
                default:
                    DOT = 1;
                    WMLBL.Text = WMLBL.Text.Substring(0, WMLBL.Text.Length - 2);
                    break;
            }
        }
    }
}