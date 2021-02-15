using Instanalyzer.Helpers;
using Instanalyzer.Views.UC.Login.ETC;
using System;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC.Login.TOP
{
    public partial class Multi : UserControl
    {
        public Multi()
        {
            InitializeComponent();
        }

        private void Multi_Load(object sender, EventArgs e)
        {
            MAFLP.Controls.Add(new Account("Bayram", "Emekli", "Taiizor", null, Sex.SexType.Male));
            MAFLP.Controls.Add(new Account("Ümithan Meriç", "Bozkurt", "mericbozkurt", null, Sex.SexType.Unknown));
            MAFLP.Controls.Add(new Account("Barbara", "Palvin", "realbarbarapalvin", null, Sex.SexType.Female));
        }
    }
}