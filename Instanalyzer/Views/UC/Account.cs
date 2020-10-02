using System;
using System.IO;
using System.Drawing;
using Instanalyzer.Helpers;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC
{
    public partial class Account : UserControl
    {
        public Account(string Name = "Name", string Surname = "Surname", string Username = "Username", string PPhoto = null, Sex.SexType Sex = Sex.SexType.Unknown)
        {
            InitializeComponent();
            PPTT.SetToolTip(PP, Name + " " + Surname);
            if (!string.IsNullOrEmpty(PPhoto) && File.Exists(PPhoto))
                PP.Image = Image.FromFile(PPhoto);
            else
            {
                switch (Sex)
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
        }

        private void PP_Click(object sender, EventArgs e)
        {
            Window.WindowMode = Window.WindowType.Wait;
        }
    }
}
