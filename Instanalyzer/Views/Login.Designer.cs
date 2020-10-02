
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
            this.NFRM = new ReaLTaiizor.Forms.NightForm();
            this.SPNL = new ReaLTaiizor.Controls.LostBorderPanel();
            this.RGLL = new ReaLTaiizor.Controls.NightLinkLabel();
            this.NOAL = new ReaLTaiizor.Controls.NightLabel();
            this.FRAMEP = new System.Windows.Forms.PictureBox();
            this.FRAME = new System.Windows.Forms.PictureBox();
            this.FPNL = new ReaLTaiizor.Controls.LostBorderPanel();
            this.RMBR = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.PWD = new ReaLTaiizor.Controls.MaterialTextBox();
            this.USN = new ReaLTaiizor.Controls.MaterialTextBox();
            this.FPLL = new ReaLTaiizor.Controls.NightLinkLabel();
            this.SGN = new ReaLTaiizor.Controls.MaterialButton();
            this.IGLL = new System.Windows.Forms.PictureBox();
            this.NCBX = new ReaLTaiizor.Controls.NightControlBox();
            this.FRAMET = new System.Windows.Forms.Timer(this.components);
            this.SSBR = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.STATUST = new System.Windows.Forms.Timer(this.components);
            this.NFRM.SuspendLayout();
            this.SPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FRAMEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME)).BeginInit();
            this.FPNL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).BeginInit();
            this.SuspendLayout();
            // 
            // NFRM
            // 
            this.NFRM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.NFRM.Controls.Add(this.SPNL);
            this.NFRM.Controls.Add(this.FRAMEP);
            this.NFRM.Controls.Add(this.FRAME);
            this.NFRM.Controls.Add(this.FPNL);
            this.NFRM.Controls.Add(this.NCBX);
            this.NFRM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NFRM.DrawIcon = true;
            this.NFRM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NFRM.ForeColor = System.Drawing.SystemColors.Control;
            this.NFRM.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.NFRM.Location = new System.Drawing.Point(0, 0);
            this.NFRM.MinimumSize = new System.Drawing.Size(100, 42);
            this.NFRM.Name = "NFRM";
            this.NFRM.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.NFRM.Size = new System.Drawing.Size(751, 471);
            this.NFRM.TabIndex = 0;
            this.NFRM.Text = "Here You Can Login";
            this.NFRM.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Center;
            this.NFRM.TitleBarTextColor = System.Drawing.Color.Black;
            // 
            // SPNL
            // 
            this.SPNL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SPNL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SPNL.Controls.Add(this.RGLL);
            this.SPNL.Controls.Add(this.NOAL);
            this.SPNL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SPNL.ForeColor = System.Drawing.Color.White;
            this.SPNL.Location = new System.Drawing.Point(335, 374);
            this.SPNL.Name = "SPNL";
            this.SPNL.Padding = new System.Windows.Forms.Padding(5);
            this.SPNL.ShowText = false;
            this.SPNL.Size = new System.Drawing.Size(383, 39);
            this.SPNL.TabIndex = 4;
            this.SPNL.Text = "SPNL";
            // 
            // RGLL
            // 
            this.RGLL.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.RGLL.BackColor = System.Drawing.Color.Transparent;
            this.RGLL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RGLL.Dock = System.Windows.Forms.DockStyle.Right;
            this.RGLL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RGLL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.RGLL.LinkColor = System.Drawing.Color.DodgerBlue;
            this.RGLL.Location = new System.Drawing.Point(198, 0);
            this.RGLL.Margin = new System.Windows.Forms.Padding(0);
            this.RGLL.Name = "RGLL";
            this.RGLL.Size = new System.Drawing.Size(185, 39);
            this.RGLL.TabIndex = 5;
            this.RGLL.TabStop = true;
            this.RGLL.Text = "Kaydol";
            this.RGLL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RGLL.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.RGLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RGLL_LinkClicked);
            // 
            // NOAL
            // 
            this.NOAL.BackColor = System.Drawing.Color.Transparent;
            this.NOAL.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NOAL.Dock = System.Windows.Forms.DockStyle.Left;
            this.NOAL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NOAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.NOAL.Location = new System.Drawing.Point(0, 0);
            this.NOAL.Margin = new System.Windows.Forms.Padding(0);
            this.NOAL.Name = "NOAL";
            this.NOAL.Size = new System.Drawing.Size(198, 39);
            this.NOAL.TabIndex = 0;
            this.NOAL.Text = "Hesabın yok mu?";
            this.NOAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FRAMEP
            // 
            this.FRAMEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FRAMEP.BackColor = System.Drawing.Color.Transparent;
            this.FRAMEP.Image = global::Instanalyzer.Properties.Resources.Frame1;
            this.FRAMEP.Location = new System.Drawing.Point(135, 118);
            this.FRAMEP.Name = "FRAMEP";
            this.FRAMEP.Size = new System.Drawing.Size(139, 246);
            this.FRAMEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FRAMEP.TabIndex = 3;
            this.FRAMEP.TabStop = false;
            // 
            // FRAME
            // 
            this.FRAME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FRAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FRAME.Image = global::Instanalyzer.Properties.Resources.Frame;
            this.FRAME.Location = new System.Drawing.Point(33, 64);
            this.FRAME.Name = "FRAME";
            this.FRAME.Size = new System.Drawing.Size(296, 349);
            this.FRAME.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FRAME.TabIndex = 2;
            this.FRAME.TabStop = false;
            // 
            // FPNL
            // 
            this.FPNL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FPNL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.FPNL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FPNL.Controls.Add(this.RMBR);
            this.FPNL.Controls.Add(this.PWD);
            this.FPNL.Controls.Add(this.USN);
            this.FPNL.Controls.Add(this.FPLL);
            this.FPNL.Controls.Add(this.SGN);
            this.FPNL.Controls.Add(this.IGLL);
            this.FPNL.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FPNL.ForeColor = System.Drawing.Color.White;
            this.FPNL.Location = new System.Drawing.Point(335, 64);
            this.FPNL.Name = "FPNL";
            this.FPNL.Padding = new System.Windows.Forms.Padding(5);
            this.FPNL.ShowText = false;
            this.FPNL.Size = new System.Drawing.Size(383, 299);
            this.FPNL.TabIndex = 1;
            this.FPNL.Text = "FPNL";
            // 
            // RMBR
            // 
            this.RMBR.AutoSize = true;
            this.RMBR.Checked = true;
            this.RMBR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RMBR.Depth = 0;
            this.RMBR.Location = new System.Drawing.Point(21, 209);
            this.RMBR.Margin = new System.Windows.Forms.Padding(0);
            this.RMBR.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RMBR.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.RMBR.Name = "RMBR";
            this.RMBR.Ripple = true;
            this.RMBR.Size = new System.Drawing.Size(137, 37);
            this.RMBR.TabIndex = 13;
            this.RMBR.Text = "Remember Me";
            this.RMBR.UseVisualStyleBackColor = true;
            // 
            // PWD
            // 
            this.PWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWD.Depth = 0;
            this.PWD.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PWD.Hint = "Şifre";
            this.PWD.Location = new System.Drawing.Point(21, 149);
            this.PWD.MaxLength = 100;
            this.PWD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.PWD.Multiline = false;
            this.PWD.Name = "PWD";
            this.PWD.Password = true;
            this.PWD.Size = new System.Drawing.Size(340, 50);
            this.PWD.TabIndex = 11;
            this.PWD.Text = "";
            this.PWD.UseAccent = false;
            // 
            // USN
            // 
            this.USN.BackColor = System.Drawing.SystemColors.Window;
            this.USN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USN.Depth = 0;
            this.USN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.USN.Hint = "Telefon numarası, kullanıcı adı veya e-posta";
            this.USN.Location = new System.Drawing.Point(21, 93);
            this.USN.MaxLength = 100;
            this.USN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.USN.Multiline = false;
            this.USN.Name = "USN";
            this.USN.Size = new System.Drawing.Size(340, 50);
            this.USN.TabIndex = 10;
            this.USN.Text = "";
            // 
            // FPLL
            // 
            this.FPLL.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.FPLL.BackColor = System.Drawing.Color.Transparent;
            this.FPLL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FPLL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FPLL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FPLL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.FPLL.LinkColor = System.Drawing.Color.DodgerBlue;
            this.FPLL.Location = new System.Drawing.Point(0, 264);
            this.FPLL.Margin = new System.Windows.Forms.Padding(0);
            this.FPLL.Name = "FPLL";
            this.FPLL.Size = new System.Drawing.Size(383, 35);
            this.FPLL.TabIndex = 9;
            this.FPLL.TabStop = true;
            this.FPLL.Text = "Şifreni mi unuttun?";
            this.FPLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FPLL.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.FPLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FPLL_LinkClicked);
            // 
            // SGN
            // 
            this.SGN.AutoSize = false;
            this.SGN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SGN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SGN.Depth = 0;
            this.SGN.DrawShadows = true;
            this.SGN.HighEmphasis = true;
            this.SGN.Icon = null;
            this.SGN.Location = new System.Drawing.Point(204, 208);
            this.SGN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SGN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.SGN.Name = "SGN";
            this.SGN.Size = new System.Drawing.Size(157, 36);
            this.SGN.TabIndex = 7;
            this.SGN.Text = "Giriş Yap";
            this.SGN.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SGN.UseAccentColor = false;
            this.SGN.UseVisualStyleBackColor = true;
            this.SGN.Click += new System.EventHandler(this.SGN_Click);
            // 
            // IGLL
            // 
            this.IGLL.BackColor = System.Drawing.Color.Transparent;
            this.IGLL.Image = global::Instanalyzer.Properties.Resources.Instagram;
            this.IGLL.Location = new System.Drawing.Point(21, 13);
            this.IGLL.Name = "IGLL";
            this.IGLL.Size = new System.Drawing.Size(340, 66);
            this.IGLL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IGLL.TabIndex = 4;
            this.IGLL.TabStop = false;
            // 
            // NCBX
            // 
            this.NCBX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NCBX.BackColor = System.Drawing.Color.Transparent;
            this.NCBX.CloseHoverColor = System.Drawing.Color.Crimson;
            this.NCBX.CloseHoverForeColor = System.Drawing.Color.White;
            this.NCBX.Cursor = System.Windows.Forms.Cursors.Default;
            this.NCBX.DefaultLocation = true;
            this.NCBX.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.NCBX.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.NCBX.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NCBX.EnableMaximizeButton = true;
            this.NCBX.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NCBX.EnableMinimizeButton = true;
            this.NCBX.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NCBX.Location = new System.Drawing.Point(612, 0);
            this.NCBX.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NCBX.MaximizeHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NCBX.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.NCBX.MinimizeHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NCBX.Name = "NCBX";
            this.NCBX.Size = new System.Drawing.Size(139, 31);
            this.NCBX.TabIndex = 0;
            // 
            // FRAMET
            // 
            this.FRAMET.Enabled = true;
            this.FRAMET.Interval = 2500;
            this.FRAMET.Tick += new System.EventHandler(this.FRAMET_Tick);
            // 
            // SSBR
            // 
            this.SSBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SSBR.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SSBR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SSBR.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.SSBR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(108)))), ((int)(((byte)(117)))));
            this.SSBR.Location = new System.Drawing.Point(0, 448);
            this.SSBR.Name = "SSBR";
            this.SSBR.RectColor = System.Drawing.Color.SeaGreen;
            this.SSBR.ShowTimeDate = true;
            this.SSBR.Size = new System.Drawing.Size(751, 23);
            this.SSBR.TabIndex = 1;
            this.SSBR.Text = "Uygulama işleyişi sorunsuz bir şekilde devam etmektedir.";
            this.SSBR.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.SSBR.TimeColor = System.Drawing.Color.Crimson;
            this.SSBR.TimeFormat = "HH:mm:ss";
            // 
            // STATUST
            // 
            this.STATUST.Enabled = true;
            this.STATUST.Interval = 1000;
            this.STATUST.Tick += new System.EventHandler(this.STATUST_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 471);
            this.Controls.Add(this.SSBR);
            this.Controls.Add(this.NFRM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Here You Can Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.NFRM.ResumeLayout(false);
            this.SPNL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FRAMEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME)).EndInit();
            this.FPNL.ResumeLayout(false);
            this.FPNL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm NFRM;
        private ReaLTaiizor.Controls.NightControlBox NCBX;
        private ReaLTaiizor.Controls.LostBorderPanel FPNL;
        private ReaLTaiizor.Controls.LostBorderPanel SPNL;
        private ReaLTaiizor.Controls.NightLinkLabel RGLL;
        private ReaLTaiizor.Controls.NightLabel NOAL;
        private System.Windows.Forms.PictureBox FRAMEP;
        private System.Windows.Forms.PictureBox FRAME;
        private System.Windows.Forms.Timer FRAMET;
        private System.Windows.Forms.PictureBox IGLL;
        private ReaLTaiizor.Controls.MaterialButton SGN;
        private ReaLTaiizor.Controls.NightLinkLabel FPLL;
        private ReaLTaiizor.Controls.MaterialTextBox USN;
        private ReaLTaiizor.Controls.MaterialCheckBox RMBR;
        private ReaLTaiizor.Controls.MaterialTextBox PWD;
        private ReaLTaiizor.Controls.ForeverStatusBar SSBR;
        private System.Windows.Forms.Timer STATUST;
    }
}