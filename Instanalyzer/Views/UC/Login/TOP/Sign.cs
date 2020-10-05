using System;
using Instanalyzer.Helpers;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC.Login.TOP
{
    public partial class Sign : UserControl
    {
        public Sign()
        {
            InitializeComponent();
        }

        private void SGN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(USN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                Status.Message = "Username and Password is Empty!";
            }
            else if (string.IsNullOrEmpty(USN.Text) && !string.IsNullOrEmpty(PWD.Text))
            {
                Status.Message = "Username is Empty!";
            }
            else if (!string.IsNullOrEmpty(USN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                Status.Message = "Password is Empty!";
            }
            else
            {
                Window.WindowMode = Window.WindowType.Multi;
            }
        }

        private void FPLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/password/reset");
        }
    }
}
