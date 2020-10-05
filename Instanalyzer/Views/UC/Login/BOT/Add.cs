using Instanalyzer.Helpers;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC.Login.BOT
{
    public partial class Add : UserControl
    {
        public Add()
        {
            InitializeComponent();
        }

        private void RGLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Window.WindowMode = Window.WindowType.Sign;
        }
    }
}