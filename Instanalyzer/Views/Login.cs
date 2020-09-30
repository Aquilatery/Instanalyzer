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
            {
                TBPG.SelectedTab = WAIT;
                timer1.Enabled = true;
            }
        }

        private void MBACK_Click(object sender, EventArgs e)
        {
            TBPG.SelectedTab = MAIN;
        }

        private void WTRY_Click(object sender, EventArgs e)
        {
            WTRY.Visible = false;
            TBPG.SelectedTab = MAIN;
            WINFO.Text = "Giriş Yapılıyor.\nPlease Wait..";
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if (Utils.Login.LoginControl(USN.Text, PWD.Text, MRMB.Checked))
            {
                WINFO.Text = "Giriş Başarılı!\nYönlendiriliyorsunuz..";
                ShowInTaskbar = false;
                Visible = false;
                Opacity = 0;
                Main MN = new Main();
                MN.Text = string.Format(MN.Text, USN.Text);
                MN.ShowDialog();
                ShowInTaskbar = true;
                Visible = true;
                Opacity = 1;
                WTRY_Click(sender, e);
            }
            else
            {
                WINFO.Text = "Giriş Başarısız!\nPlease Try Again..";
                WTRY.Visible = true;
            }
        }
    }
}