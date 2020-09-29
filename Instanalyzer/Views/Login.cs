using System;
using ReaLTaiizor.Util;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Controls;

namespace Instanalyzer.Views
{
    public partial class Login : MaterialForm
    {
        private readonly MaterialManager materialManager;

        public Login()
        {
            InitializeComponent();

            materialManager = MaterialManager.Instance;
            materialManager.EnforceBackcolorOnAllComponents = true;
            materialManager.AddFormToManage(this);
            materialManager.Theme = MaterialManager.Themes.DARK;
            materialManager.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.WHITE);
        }

        private void PSWS_CheckedChanged(object sender, EventArgs e)
        {
            PWD.Password = !PSWS.Checked;
        }

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(URN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                MaterialMessageBox.Show(this, "Username and Password is Empty!");
            }
            else if (string.IsNullOrEmpty(URN.Text) && !string.IsNullOrEmpty(PWD.Text))
            {
                MaterialMessageBox.Show(this, "Username is Empty!");
            }
            else if (!string.IsNullOrEmpty(URN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                MaterialMessageBox.Show(this, "Password is Empty!");
            }
            else
            {
                TBPG.SelectedTab = WAIT;
            }
        }
    }
}