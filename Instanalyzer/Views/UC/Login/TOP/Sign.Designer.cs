
namespace Instanalyzer.Views.UC.Login.TOP
{
    partial class Sign
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.RMBR = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.PWD = new ReaLTaiizor.Controls.MaterialTextBox();
            this.USN = new ReaLTaiizor.Controls.MaterialTextBox();
            this.FPLL = new ReaLTaiizor.Controls.NightLinkLabel();
            this.SGN = new ReaLTaiizor.Controls.MaterialButton();
            this.IGLL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).BeginInit();
            this.SuspendLayout();
            // 
            // RMBR
            // 
            this.RMBR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RMBR.AutoSize = true;
            this.RMBR.Checked = true;
            this.RMBR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RMBR.Depth = 0;
            this.RMBR.Location = new System.Drawing.Point(21, 202);
            this.RMBR.Margin = new System.Windows.Forms.Padding(0);
            this.RMBR.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RMBR.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.RMBR.Name = "RMBR";
            this.RMBR.Ripple = true;
            this.RMBR.Size = new System.Drawing.Size(137, 37);
            this.RMBR.TabIndex = 19;
            this.RMBR.Text = "Remember Me";
            this.RMBR.UseVisualStyleBackColor = true;
            // 
            // PWD
            // 
            this.PWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWD.Depth = 0;
            this.PWD.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PWD.Hint = "Şifre";
            this.PWD.Location = new System.Drawing.Point(21, 142);
            this.PWD.MaxLength = 100;
            this.PWD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.PWD.Multiline = false;
            this.PWD.Name = "PWD";
            this.PWD.Password = true;
            this.PWD.Size = new System.Drawing.Size(340, 50);
            this.PWD.TabIndex = 18;
            this.PWD.Text = "";
            this.PWD.UseAccent = false;
            // 
            // USN
            // 
            this.USN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.USN.BackColor = System.Drawing.SystemColors.Window;
            this.USN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.USN.Depth = 0;
            this.USN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.USN.Hint = "Telefon numarası, kullanıcı adı veya e-posta";
            this.USN.Location = new System.Drawing.Point(21, 86);
            this.USN.MaxLength = 100;
            this.USN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.USN.Multiline = false;
            this.USN.Name = "USN";
            this.USN.Size = new System.Drawing.Size(340, 50);
            this.USN.TabIndex = 17;
            this.USN.Text = "Taiizor";
            // 
            // FPLL
            // 
            this.FPLL.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.FPLL.BackColor = System.Drawing.Color.Transparent;
            this.FPLL.Cursor = System.Windows.Forms.Cursors.Default;
            this.FPLL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FPLL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FPLL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.FPLL.LinkColor = System.Drawing.Color.DodgerBlue;
            this.FPLL.Location = new System.Drawing.Point(0, 264);
            this.FPLL.Margin = new System.Windows.Forms.Padding(0);
            this.FPLL.Name = "FPLL";
            this.FPLL.Size = new System.Drawing.Size(383, 35);
            this.FPLL.TabIndex = 16;
            this.FPLL.TabStop = true;
            this.FPLL.Text = "Şifreni mi unuttun?";
            this.FPLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FPLL.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.FPLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FPLL_LinkClicked);
            // 
            // SGN
            // 
            this.SGN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SGN.AutoSize = false;
            this.SGN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SGN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SGN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SGN.Depth = 0;
            this.SGN.DrawShadows = true;
            this.SGN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SGN.HighEmphasis = true;
            this.SGN.Icon = null;
            this.SGN.Location = new System.Drawing.Point(204, 201);
            this.SGN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SGN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.SGN.Name = "SGN";
            this.SGN.Size = new System.Drawing.Size(157, 36);
            this.SGN.TabIndex = 15;
            this.SGN.Text = "Giriş Yap";
            this.SGN.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SGN.UseAccentColor = false;
            this.SGN.UseVisualStyleBackColor = false;
            this.SGN.Click += new System.EventHandler(this.SGN_Click);
            // 
            // IGLL
            // 
            this.IGLL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IGLL.BackColor = System.Drawing.Color.Transparent;
            this.IGLL.Image = global::Instanalyzer.Properties.Resources.Instagram;
            this.IGLL.Location = new System.Drawing.Point(21, 6);
            this.IGLL.Name = "IGLL";
            this.IGLL.Size = new System.Drawing.Size(340, 66);
            this.IGLL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IGLL.TabIndex = 14;
            this.IGLL.TabStop = false;
            // 
            // Sign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.RMBR);
            this.Controls.Add(this.PWD);
            this.Controls.Add(this.USN);
            this.Controls.Add(this.FPLL);
            this.Controls.Add(this.SGN);
            this.Controls.Add(this.IGLL);
            this.Name = "Sign";
            this.Size = new System.Drawing.Size(383, 299);
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCheckBox RMBR;
        private ReaLTaiizor.Controls.MaterialTextBox PWD;
        private ReaLTaiizor.Controls.MaterialTextBox USN;
        private ReaLTaiizor.Controls.NightLinkLabel FPLL;
        private ReaLTaiizor.Controls.MaterialButton SGN;
        private System.Windows.Forms.PictureBox IGLL;
    }
}