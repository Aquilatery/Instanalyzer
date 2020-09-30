
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.USN = new ReaLTaiizor.Controls.HopeTextBox();
            this.AIL = new ReaLTaiizor.Controls.MetroLabel();
            this.PWD = new ReaLTaiizor.Controls.HopeTextBox();
            this.SGN = new ReaLTaiizor.Controls.MetroButton();
            this.MRMB = new ReaLTaiizor.Controls.LostCheckBox();
            this.MAIMG = new ReaLTaiizor.Controls.HopePictureBox();
            this.TBPG = new ReaLTaiizor.Controls.MaterialTabControl();
            this.MAIN = new System.Windows.Forms.TabPage();
            this.MESSAGE = new System.Windows.Forms.TabPage();
            this.MIMG = new ReaLTaiizor.Controls.HopePictureBox();
            this.MINFO = new ReaLTaiizor.Controls.MetroLabel();
            this.MBACK = new ReaLTaiizor.Controls.MetroButton();
            this.WAIT = new System.Windows.Forms.TabPage();
            this.WTRY = new ReaLTaiizor.Controls.MetroButton();
            this.WINFO = new ReaLTaiizor.Controls.MetroLabel();
            this.WIND = new ReaLTaiizor.Controls.ProgressIndicator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MAIMG)).BeginInit();
            this.TBPG.SuspendLayout();
            this.MAIN.SuspendLayout();
            this.MESSAGE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MIMG)).BeginInit();
            this.WAIT.SuspendLayout();
            this.SuspendLayout();
            // 
            // USN
            // 
            this.USN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.USN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.USN.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.USN.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.USN.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.USN.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.USN.ForeColor = System.Drawing.Color.Silver;
            this.USN.Hint = "Username";
            this.USN.Location = new System.Drawing.Point(6, 119);
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
            this.USN.Text = "ReaL";
            this.USN.UseSystemPasswordChar = false;
            // 
            // AIL
            // 
            this.AIL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.AIL.Location = new System.Drawing.Point(6, 85);
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
            // PWD
            // 
            this.PWD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PWD.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.PWD.BorderColorA = System.Drawing.Color.DodgerBlue;
            this.PWD.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PWD.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PWD.ForeColor = System.Drawing.Color.Silver;
            this.PWD.Hint = "Password";
            this.PWD.Location = new System.Drawing.Point(6, 163);
            this.PWD.MaxLength = 100;
            this.PWD.Multiline = false;
            this.PWD.Name = "PWD";
            this.PWD.PasswordChar = '\0';
            this.PWD.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PWD.SelectedText = "";
            this.PWD.SelectionLength = 0;
            this.PWD.SelectionStart = 0;
            this.PWD.Size = new System.Drawing.Size(265, 38);
            this.PWD.TabIndex = 1;
            this.PWD.TabStop = false;
            this.PWD.Text = "Taiizor";
            this.PWD.UseSystemPasswordChar = true;
            // 
            // SGN
            // 
            this.SGN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SGN.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SGN.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SGN.DisabledForeColor = System.Drawing.Color.Gray;
            this.SGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SGN.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.SGN.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.SGN.HoverTextColor = System.Drawing.Color.Silver;
            this.SGN.Location = new System.Drawing.Point(145, 207);
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
            this.SGN.Click += new System.EventHandler(this.SGN_Click);
            // 
            // MRMB
            // 
            this.MRMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MRMB.Checked = true;
            this.MRMB.CheckedColor = System.Drawing.Color.DodgerBlue;
            this.MRMB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MRMB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.MRMB.ForeColor = System.Drawing.Color.Silver;
            this.MRMB.Location = new System.Drawing.Point(6, 215);
            this.MRMB.Name = "MRMB";
            this.MRMB.Size = new System.Drawing.Size(133, 23);
            this.MRMB.TabIndex = 4;
            this.MRMB.Text = "Remember Me";
            // 
            // MAIMG
            // 
            this.MAIMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MAIMG.BackColor = System.Drawing.Color.Transparent;
            this.MAIMG.Image = global::Instanalyzer.Properties.Resources.Female;
            this.MAIMG.Location = new System.Drawing.Point(6, 32);
            this.MAIMG.Name = "MAIMG";
            this.MAIMG.Size = new System.Drawing.Size(265, 50);
            this.MAIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MAIMG.TabIndex = 40;
            this.MAIMG.TabStop = false;
            // 
            // TBPG
            // 
            this.TBPG.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TBPG.Controls.Add(this.MAIN);
            this.TBPG.Controls.Add(this.MESSAGE);
            this.TBPG.Controls.Add(this.WAIT);
            this.TBPG.Depth = 0;
            this.TBPG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBPG.Location = new System.Drawing.Point(2, 36);
            this.TBPG.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.TBPG.Multiline = true;
            this.TBPG.Name = "TBPG";
            this.TBPG.Padding = new System.Drawing.Point(0, 0);
            this.TBPG.SelectedIndex = 0;
            this.TBPG.Size = new System.Drawing.Size(285, 284);
            this.TBPG.TabIndex = 41;
            // 
            // MAIN
            // 
            this.MAIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MAIN.Controls.Add(this.AIL);
            this.MAIN.Controls.Add(this.MAIMG);
            this.MAIN.Controls.Add(this.USN);
            this.MAIN.Controls.Add(this.MRMB);
            this.MAIN.Controls.Add(this.PWD);
            this.MAIN.Controls.Add(this.SGN);
            this.MAIN.Location = new System.Drawing.Point(4, 4);
            this.MAIN.Name = "MAIN";
            this.MAIN.Padding = new System.Windows.Forms.Padding(3);
            this.MAIN.Size = new System.Drawing.Size(277, 250);
            this.MAIN.TabIndex = 0;
            this.MAIN.Text = "MAIN";
            // 
            // MESSAGE
            // 
            this.MESSAGE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MESSAGE.Controls.Add(this.MIMG);
            this.MESSAGE.Controls.Add(this.MINFO);
            this.MESSAGE.Controls.Add(this.MBACK);
            this.MESSAGE.Location = new System.Drawing.Point(4, 4);
            this.MESSAGE.Name = "MESSAGE";
            this.MESSAGE.Padding = new System.Windows.Forms.Padding(3);
            this.MESSAGE.Size = new System.Drawing.Size(277, 250);
            this.MESSAGE.TabIndex = 1;
            this.MESSAGE.Text = "MESSAGE";
            // 
            // MIMG
            // 
            this.MIMG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MIMG.BackColor = System.Drawing.Color.Transparent;
            this.MIMG.Image = global::Instanalyzer.Properties.Resources.Biohazard;
            this.MIMG.Location = new System.Drawing.Point(6, 32);
            this.MIMG.Name = "MIMG";
            this.MIMG.Size = new System.Drawing.Size(265, 50);
            this.MIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MIMG.TabIndex = 41;
            this.MIMG.TabStop = false;
            // 
            // MINFO
            // 
            this.MINFO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MINFO.Location = new System.Drawing.Point(6, 85);
            this.MINFO.MetroStyleManager = null;
            this.MINFO.Name = "MINFO";
            this.MINFO.Size = new System.Drawing.Size(265, 119);
            this.MINFO.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.MINFO.TabIndex = 10;
            this.MINFO.Text = "MESSAGE";
            this.MINFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MINFO.ThemeAuthor = "Taiizor";
            this.MINFO.ThemeName = "MetroDark";
            // 
            // MBACK
            // 
            this.MBACK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MBACK.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MBACK.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.MBACK.DisabledForeColor = System.Drawing.Color.Gray;
            this.MBACK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MBACK.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.MBACK.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MBACK.HoverTextColor = System.Drawing.Color.Silver;
            this.MBACK.Location = new System.Drawing.Point(6, 207);
            this.MBACK.MetroStyleManager = null;
            this.MBACK.Name = "MBACK";
            this.MBACK.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.MBACK.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.MBACK.NormalTextColor = System.Drawing.Color.Silver;
            this.MBACK.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.MBACK.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.MBACK.PressTextColor = System.Drawing.Color.Silver;
            this.MBACK.Size = new System.Drawing.Size(265, 38);
            this.MBACK.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.MBACK.TabIndex = 6;
            this.MBACK.Text = "BACK";
            this.MBACK.ThemeAuthor = "Taiizor";
            this.MBACK.ThemeName = "MetroDark";
            this.MBACK.Click += new System.EventHandler(this.MBACK_Click);
            // 
            // WAIT
            // 
            this.WAIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.WAIT.Controls.Add(this.WTRY);
            this.WAIT.Controls.Add(this.WINFO);
            this.WAIT.Controls.Add(this.WIND);
            this.WAIT.Location = new System.Drawing.Point(4, 4);
            this.WAIT.Name = "WAIT";
            this.WAIT.Size = new System.Drawing.Size(277, 250);
            this.WAIT.TabIndex = 2;
            this.WAIT.Text = "WAIT";
            // 
            // WTRY
            // 
            this.WTRY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WTRY.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.WTRY.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.WTRY.DisabledForeColor = System.Drawing.Color.Gray;
            this.WTRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.WTRY.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.WTRY.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.WTRY.HoverTextColor = System.Drawing.Color.Silver;
            this.WTRY.Location = new System.Drawing.Point(6, 207);
            this.WTRY.MetroStyleManager = null;
            this.WTRY.Name = "WTRY";
            this.WTRY.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.WTRY.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.WTRY.NormalTextColor = System.Drawing.Color.Silver;
            this.WTRY.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.WTRY.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(58)))));
            this.WTRY.PressTextColor = System.Drawing.Color.Silver;
            this.WTRY.Size = new System.Drawing.Size(265, 38);
            this.WTRY.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.WTRY.TabIndex = 12;
            this.WTRY.Text = "TRY AGAIN";
            this.WTRY.ThemeAuthor = "Taiizor";
            this.WTRY.ThemeName = "MetroDark";
            this.WTRY.Visible = false;
            this.WTRY.Click += new System.EventHandler(this.WTRY_Click);
            // 
            // WINFO
            // 
            this.WINFO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WINFO.Location = new System.Drawing.Point(6, 85);
            this.WINFO.MetroStyleManager = null;
            this.WINFO.Name = "WINFO";
            this.WINFO.Size = new System.Drawing.Size(265, 119);
            this.WINFO.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.WINFO.TabIndex = 11;
            this.WINFO.Text = "Giriş Yapılıyor.\r\nPlease Wait..";
            this.WINFO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WINFO.ThemeAuthor = "Taiizor";
            this.WINFO.ThemeName = "MetroDark";
            // 
            // WIND
            // 
            this.WIND.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WIND.Location = new System.Drawing.Point(115, 32);
            this.WIND.MaximumSize = new System.Drawing.Size(50, 50);
            this.WIND.MinimumSize = new System.Drawing.Size(50, 50);
            this.WIND.Name = "WIND";
            this.WIND.P_AnimationColor = System.Drawing.Color.DimGray;
            this.WIND.P_AnimationSpeed = 100;
            this.WIND.P_BaseColor = System.Drawing.Color.DarkGray;
            this.WIND.Size = new System.Drawing.Size(50, 50);
            this.WIND.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 322);
            this.Controls.Add(this.TBPG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Image = global::Instanalyzer.Properties.Resources.Login;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Here You Can Login";
            ((System.ComponentModel.ISupportInitialize)(this.MAIMG)).EndInit();
            this.TBPG.ResumeLayout(false);
            this.MAIN.ResumeLayout(false);
            this.MESSAGE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MIMG)).EndInit();
            this.WAIT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox USN;
        private ReaLTaiizor.Controls.MetroLabel AIL;
        private ReaLTaiizor.Controls.HopeTextBox PWD;
        private ReaLTaiizor.Controls.MetroButton SGN;
        private ReaLTaiizor.Controls.LostCheckBox MRMB;
        private ReaLTaiizor.Controls.HopePictureBox MAIMG;
        private ReaLTaiizor.Controls.MaterialTabControl TBPG;
        private System.Windows.Forms.TabPage MAIN;
        private System.Windows.Forms.TabPage MESSAGE;
        private System.Windows.Forms.TabPage WAIT;
        private ReaLTaiizor.Controls.MetroLabel MINFO;
        private ReaLTaiizor.Controls.MetroButton MBACK;
        private ReaLTaiizor.Controls.HopePictureBox MIMG;
        private ReaLTaiizor.Controls.ProgressIndicator WIND;
        private ReaLTaiizor.Controls.MetroLabel WINFO;
        private ReaLTaiizor.Controls.MetroButton WTRY;
        private System.Windows.Forms.Timer timer1;
    }
}