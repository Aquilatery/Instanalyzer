using System;
using Instanalyzer.Helpers;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC
{
    public partial class Multi : UserControl
    {
        public Multi()
        {
            InitializeComponent();
        }

        private void FPLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/password/reset");
        }
    }
}
