using Instanalyzer.Views.UI.ETC;
using System;
using System.Windows.Forms;

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