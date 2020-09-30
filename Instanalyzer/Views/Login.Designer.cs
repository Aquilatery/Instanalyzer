
namespace Instanalyzer.Views
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.USN = new ReaLTaiizor.Controls.HopeTextBox();
            this.AIL = new ReaLTaiizor.Controls.MetroLabel();
            this.PSW = new ReaLTaiizor.Controls.HopeTextBox();
            this.SGN = new ReaLTaiizor.Controls.MetroButton();
            this.lostCheckBox1 = new ReaLTaiizor.Controls.LostCheckBox();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // USN
            // 
            this.USN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.USN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.USN.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.USN.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.USN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.USN.ForeColor = System.Drawing.Color.Silver;
            this.USN.Hint = "Username";
            this.USN.Location = new System.Drawing.Point(5, 125);
            this.USN.MaxLength = 50;
            this.USN.Multiline = false;
            this.USN.Name = "USN";
            this.USN.PasswordChar = '\0';
            this.USN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.USN.SelectedText = "";
            this.USN.SelectionLength = 0;
            this.USN.SelectionStart = 0;
            this.USN.Size = new System.Drawing.Size(265, 38);
            this.USN.TabIndex = 0;
            this.USN.TabStop = false;
            this.USN.UseSystemPasswordChar = false;
            // 
            // AIL
            // 
            this.AIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AIL.Location = new System.Drawing.Point(5, 91);
            this.AIL.MetroStyleManager = null;
            this.AIL.Name = "AIL";
            this.AIL.Size = new System.Drawing.Size(265, 31);
            this.AIL.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.AIL.TabIndex = 9;
            this.AIL.Text = "Account Information";
            this.AIL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AIL.ThemeAuthor = "Taiizor";
            this.AIL.ThemeName = "MetroDark";
            // 
            // PSW
            // 
            this.PSW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PSW.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.PSW.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.PSW.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PSW.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PSW.ForeColor = System.Drawing.Color.Silver;
            this.PSW.Hint = "Password";
            this.PSW.Location = new System.Drawing.Point(5, 169);
            this.PSW.MaxLength = 100;
            this.PSW.Multiline = false;
            this.PSW.Name = "PSW";
            this.PSW.PasswordChar = '\0';
            this.PSW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PSW.SelectedText = "";
            this.PSW.SelectionLength = 0;
            this.PSW.SelectionStart = 0;
            this.PSW.Size = new System.Drawing.Size(265, 38);
            this.PSW.TabIndex = 1;
            this.PSW.TabStop = false;
            this.PSW.UseSystemPasswordChar = true;
            // 
            // SGN
            // 
            this.SGN.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SGN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SGN.DisabledForeColor = System.Drawing.Color.Gray;
            this.SGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SGN.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.SGN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SGN.HoverTextColor = System.Drawing.Color.Silver;
            this.SGN.Location = new System.Drawing.Point(144, 213);
            this.SGN.MetroStyleManager = null;
            this.SGN.Name = "SGN";
            this.SGN.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.SGN.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.SGN.NormalTextColor = System.Drawing.Color.Silver;
            this.SGN.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SGN.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.SGN.PressTextColor = System.Drawing.Color.Silver;
            this.SGN.Size = new System.Drawing.Size(126, 38);
            this.SGN.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.SGN.TabIndex = 5;
            this.SGN.Text = "SIGN IN";
            this.SGN.ThemeAuthor = "Taiizor";
            this.SGN.ThemeName = "MetroDark";
            // 
            // lostCheckBox1
            // 
            this.lostCheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.lostCheckBox1.Checked = true;
            this.lostCheckBox1.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.lostCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lostCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lostCheckBox1.ForeColor = System.Drawing.Color.Silver;
            this.lostCheckBox1.Location = new System.Drawing.Point(5, 221);
            this.lostCheckBox1.Name = "lostCheckBox1";
            this.lostCheckBox1.Size = new System.Drawing.Size(133, 23);
            this.lostCheckBox1.TabIndex = 4;
            this.lostCheckBox1.Text = "Remember Me";
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = global::Instanalyzer.Properties.Resources.Female;
            this.hopePictureBox1.Location = new System.Drawing.Point(5, 39);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.Size = new System.Drawing.Size(265, 49);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hopePictureBox1.TabIndex = 40;
            this.hopePictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 257);
            this.Controls.Add(this.hopePictureBox1);
            this.Controls.Add(this.lostCheckBox1);
            this.Controls.Add(this.SGN);
            this.Controls.Add(this.PSW);
            this.Controls.Add(this.AIL);
            this.Controls.Add(this.USN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Image = global::Instanalyzer.Properties.Resources.Login;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Here You Can Login";
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox USN;
        private ReaLTaiizor.Controls.MetroLabel AIL;
        private ReaLTaiizor.Controls.HopeTextBox PSW;
        private ReaLTaiizor.Controls.MetroButton SGN;
        private ReaLTaiizor.Controls.LostCheckBox lostCheckBox1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
    }
}