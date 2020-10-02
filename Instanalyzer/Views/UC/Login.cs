using Instanalyzer.Helpers;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RGLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Window.WindowMode = Window.WindowType.Sign;
        }
    }
}