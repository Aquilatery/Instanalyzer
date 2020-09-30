using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using ReaLTaiizor.Forms;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Instanalyzer.Views
{
    public partial class Test : Form
    {
        private const string DefaultStatus = "Uygulama işleyişi sorunsuz bir şekilde devam etmektedir.";
        private long ChangedStatus = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

        private int FRAMEPI = 1;

        public Test()
        {
            InitializeComponent();
        }

        private void FRAMET_Tick(object sender, EventArgs e)
        {
            switch (FRAMEPI++)
            {
                case 1:
                    FRAMEP.Image = Properties.Resources.Frame2;
                    break;
                case 2:
                    FRAMEP.Image = Properties.Resources.Frame3;
                    break;
                case 3:
                    FRAMEP.Image = Properties.Resources.Frame4;
                    break;
                case 4:
                    FRAMEP.Image = Properties.Resources.Frame5;
                    break;
                case 5:
                    FRAMEP.Image = Properties.Resources.Frame1;
                    FRAMEPI = 0;
                    break;
            }
        }

        private void SGN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(USN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                SSBR.Text = "Username and Password is Empty!";
                ChangedStatus = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            }
            else if (string.IsNullOrEmpty(USN.Text) && !string.IsNullOrEmpty(PWD.Text))
            {
                SSBR.Text = "Username is Empty!";
                ChangedStatus = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            }
            else if (!string.IsNullOrEmpty(USN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                SSBR.Text = "Password is Empty!";
                ChangedStatus = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            }
            else
            {
                //
            }
        }

        private void STATUST_Tick(object sender, EventArgs e)
        {
            try
            {
                long Result = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - ChangedStatus;
                if (Result >= 3)
                    SSBR.Text = DefaultStatus;
            }
            catch (Exception Hata)
            {
                SSBR.Text = "Hata - " + Hata.Source + ": " + Hata.Message;
                ChangedStatus = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            }
        }

        private void FPLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/password/reset");
        }

        private void RGLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/emailsignup");
        }
    }
}