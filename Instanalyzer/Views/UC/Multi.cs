using System;
using System.Windows.Forms;
using Instanalyzer.Helpers;

namespace Instanalyzer.Views.UC
{
    public partial class Multi : UserControl
    {
        public Multi()
        {
            InitializeComponent();
        }

        private void Multi_Load(object sender, EventArgs e)
        {
            MAFLP.Controls.Add(new Account("Bayram", "Emekli", "ReaLTaiizor", null, Sex.SexType.Male));
            MAFLP.Controls.Add(new Account("Ümithan Meriç", "Bozkurt", "mericbozkurt", null, Sex.SexType.Unknown));
            MAFLP.Controls.Add(new Account("Barbara", "Palvin", "realbarbarapalvin", null, Sex.SexType.Female));
        }
    }
}
