using Instanalyzer.Helpers;
using ReaLTaiizor.Colors;
using ReaLTaiizor.Util;
using System;
using System.Windows.Forms;

namespace Instanalyzer.Views.UC.Login.TOP
{
    public partial class Sign : UserControl
    {
        private readonly MaterialManager MM;

        public Sign()
        {
            InitializeComponent();
            MM = MaterialManager.Instance;
            MM.EnforceBackcolorOnAllComponents = true;
            MM.Theme = MaterialManager.Themes.LIGHT;
            MM.ColorScheme = new MaterialColorScheme(MaterialPrimary.Indigo500, MaterialPrimary.Indigo700, MaterialPrimary.Indigo100, MaterialAccent.Pink200, MaterialTextShade.WHITE);
        }

        private void SGN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(USN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                Status.Message = "Username and Password is Empty!";
            }
            else if (string.IsNullOrEmpty(USN.Text) && !string.IsNullOrEmpty(PWD.Text))
            {
                Status.Message = "Username is Empty!";
            }
            else if (!string.IsNullOrEmpty(USN.Text) && string.IsNullOrEmpty(PWD.Text))
            {
                Status.Message = "Password is Empty!";
            }
            else
            {
                Window.WindowMode = Window.WindowType.Multi;
            }
        }

        private void FPLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/accounts/password/reset");
        }
    }
}
