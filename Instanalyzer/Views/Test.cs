using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Instanalyzer.Views
{
    public partial class Test : Form
    {
        private int FRAMEPI = 1;

        public Test()
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
    }
}