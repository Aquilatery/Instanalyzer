
namespace Instanalyzer.Views.UI
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
            this.FRAMEP = new System.Windows.Forms.PictureBox();
            this.FRAME = new System.Windows.Forms.PictureBox();
            this.FPNL = new ReaLTaiizor.Controls.LostBorderPanel();
            this.NCBX = new ReaLTaiizor.Controls.NightControlBox();
            this.FRAMET = new System.Windows.Forms.Timer(this.components);
            this.SSBR = new ReaLTaiizor.Controls.ForeverStatusBar();
            this.STATUST = new System.Windows.Forms.Timer(this.components);
            this.STATUSMT = new System.Windows.Forms.Timer(this.components);
            this.WINDOWT = new System.Windows.Forms.Timer(this.components);
            this.NFRM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FRAMEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME)).BeginInit();
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
            // FRAMEP
            // 
            this.FRAMEP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FRAMEP.BackColor = System.Drawing.Color.Transparent;
            this.FRAMEP.Image = global::Instanalyzer.Properties.Resources.Frame1;
            this.FRAMEP.Location = new System.Drawing.Point(137, 119);
            this.FRAMEP.Name = "FRAMEP";
            this.FRAMEP.Size = new System.Drawing.Size(137, 244);
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
            this.SSBR.TimeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(95)))));
            this.SSBR.TimeFormat = "HH:mm:ss";
            // 
            // STATUST
            // 
            this.STATUST.Enabled = true;
            this.STATUST.Interval = 1000;
            this.STATUST.Tick += new System.EventHandler(this.STATUST_Tick);
            // 
            // STATUSMT
            // 
            this.STATUSMT.Enabled = true;
            this.STATUSMT.Interval = 50;
            this.STATUSMT.Tick += new System.EventHandler(this.STATUSMT_Tick);
            // 
            // WINDOWT
            // 
            this.WINDOWT.Enabled = true;
            this.WINDOWT.Interval = 50;
            this.WINDOWT.Tick += new System.EventHandler(this.WINDOWT_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(751, 471);
            this.Controls.Add(this.SSBR);
            this.Controls.Add(this.NFRM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Here You Can Login";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.NFRM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FRAMEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FRAME)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm NFRM;
        private ReaLTaiizor.Controls.NightControlBox NCBX;
        private ReaLTaiizor.Controls.LostBorderPanel FPNL;
        private ReaLTaiizor.Controls.LostBorderPanel SPNL;
        private System.Windows.Forms.PictureBox FRAMEP;
        private System.Windows.Forms.PictureBox FRAME;
        private System.Windows.Forms.Timer FRAMET;
        private ReaLTaiizor.Controls.ForeverStatusBar SSBR;
        private System.Windows.Forms.Timer STATUST;
        private System.Windows.Forms.Timer STATUSMT;
        private System.Windows.Forms.Timer WINDOWT;
    }
}