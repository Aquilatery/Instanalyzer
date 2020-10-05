using System;
using System.Windows.Forms;
using Instanalyzer.Views.UI.ETC;

namespace Instanalyzer.Views.UC.Login.BOT
{
    public partial class Copyright : UserControl
    {
        public Copyright()
        {
            InitializeComponent();
        }

        private void NOAL_Click(object sender, EventArgs e)
        {
            new Thank().ShowDialog();
        }
    }
}