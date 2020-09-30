using System;
using ReaLTaiizor.Forms;

namespace Instanalyzer.Views
{
    public partial class Login : LostForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void SGN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(USN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                MINFO.Text = "Username and Password is Empty!";
                TBPG.SelectedTab = MESSAGE;
            }
            else if (string.IsNullOrEmpty(USN.Text) && !string.IsNullOrEmpty(PWD.Text))
            {
                MINFO.Text = "Username is Empty!";
                TBPG.SelectedTab = MESSAGE;
            }
            else if (!string.IsNullOrEmpty(USN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                MINFO.Text = "Password is Empty!";
                TBPG.SelectedTab = MESSAGE;
            }
            else
                TBPG.SelectedTab = WAIT;
        }

        private void MBACK_Click(object sender, EventArgs e)
        {
            TBPG.SelectedTab = MAIN;
        }
    }
}