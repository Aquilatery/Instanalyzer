using System;
using ReaLTaiizor.Controls;
using Instanalyzer.Helpers;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC.Login.TOP
{
    public partial class Warn : UserControl
    {
        public Warn()
        {
            InitializeComponent();
        }

        private void WNNN_Click(object sender, EventArgs e)
        {
            MaterialMessageBox.Show("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "Hata");
        }

        private void ALLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Window.WindowMode = Window.WindowType.Sign;
        }
    }
}