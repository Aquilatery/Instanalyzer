using System;
using Instanalyzer.Helpers;
using System.Windows.Forms;
using Instanalyzer.Views.UC;

namespace Instanalyzer.Views
{
    public partial class Login : Form
    {
        private int FRAMEPI = 1;

        public Login()
        {
            InitializeComponent();
        }

        private void FRAMET_Tick(object sender, EventArgs e)
        {
            switch (FRAMEPI++)
            {
                case 1:
                    FRAMEP.Image = Properties.Resources.Frame2;
                    break;
                case 2:
                    FRAMEP.Image = Properties.Resources.Frame3;
                    break;
                case 3:
                    FRAMEP.Image = Properties.Resources.Frame4;
                    break;
                case 4:
                    FRAMEP.Image = Properties.Resources.Frame5;
                    break;
                case 5:
                    FRAMEP.Image = Properties.Resources.Frame1;
                    FRAMEPI = 0;
                    break;
            }
        }

        private void STATUST_Tick(object sender, EventArgs e)
        {
            try
            {
                long Result = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - Status.ChangedStatus;
                if (Result >= 3)
                    Status.Message = Status.DefaultStatus;
            }
            catch (Exception Ex)
            {
                Status.Message = "Hata - " + Ex.Source + ": " + Ex.Message;
            }
        }

        private void STATUSMT_Tick(object sender, EventArgs e)
        {
            try
            {
                SSBR.Text = Status.Message;
            }
            catch (Exception Ex)
            {
                Status.Message = "Hata - " + Ex.Source + ": " + Ex.Message;
            }
        }

        private void WINDOWT_Tick(object sender, EventArgs e)
        {
            if (Window.ActiveWindow)
            {
                Window.ActiveWindow = false;
                SetWindow(Window.WindowMode);
            }
        }

        private void SetWindow(Window.WindowType Type)
        {
            FPNL.Controls.Clear();
            SPNL.Controls.Clear();
            switch (Type)
            {
                case Window.WindowType.Sign:
                    FPNL.Controls.Add(new Sign());
                    SPNL.Controls.Add(new Register());
                    break;
                case Window.WindowType.Multi:
                    FPNL.Controls.Add(new Multi());
                    SPNL.Controls.Add(new UC.Login());
                    break;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}