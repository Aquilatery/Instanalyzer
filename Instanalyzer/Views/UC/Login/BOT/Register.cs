using System.Windows.Forms;

namespace Instanalyzer.Views.UC.Login.BOT
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RGLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/emailsignup");
        }
    }
}