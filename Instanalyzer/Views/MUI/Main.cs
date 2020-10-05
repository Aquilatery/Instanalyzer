using ReaLTaiizor.Forms;
using System.Windows.Forms;

namespace Instanalyzer.Views.MUI
{
    public partial class Main : LostForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Hesaptan Çıkış Yapmak İstiyor Musunuz?", "Are You Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
