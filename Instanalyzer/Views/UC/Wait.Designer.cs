
namespace Instanalyzer.Views.UC
{
    partial class Wait
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
            this.PIND = new ReaLTaiizor.Controls.ProgressIndicator();
            this.WMLBL = new ReaLTaiizor.Controls.MetroLabel();
            this.metroLabel1 = new ReaLTaiizor.Controls.MetroLabel();
            this.IGLL = new System.Windows.Forms.PictureBox();
            this.PP = new ReaLTaiizor.Controls.MetroEllipse();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PIND
            // 
            this.PIND.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PIND.Location = new System.Drawing.Point(289, 78);
            this.PIND.MinimumSize = new System.Drawing.Size(50, 50);
            this.PIND.Name = "PIND";
            this.PIND.P_AnimationColor = System.Drawing.Color.Gray;
            this.PIND.P_AnimationSpeed = 75;
            this.PIND.P_BaseColor = System.Drawing.Color.Silver;
            this.PIND.Size = new System.Drawing.Size(72, 72);
            this.PIND.TabIndex = 15;
            this.PIND.Text = "PIND";
            // 
            // WMLBL
            // 
            this.WMLBL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WMLBL.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.WMLBL.Location = new System.Drawing.Point(21, 255);
            this.WMLBL.Margin = new System.Windows.Forms.Padding(3);
            this.WMLBL.MetroStyleManager = null;
            this.WMLBL.Name = "WMLBL";
            this.WMLBL.Size = new System.Drawing.Size(340, 41);
            this.WMLBL.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.WMLBL.TabIndex = 16;
            this.WMLBL.Text = "Giriş Yapılıyor. Lütfen Bekleyin..";
            this.WMLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WMLBL.ThemeAuthor = "Taiizor";
            this.WMLBL.ThemeName = "MetroLite";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.metroLabel1.Location = new System.Drawing.Point(99, 78);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.MetroStyleManager = null;
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(184, 72);
            this.metroLabel1.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "ReaLTaiizor\r\nBayram Emekli";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.ThemeAuthor = "Taiizor";
            this.metroLabel1.ThemeName = "MetroDark";
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
            // PP
            // 
            this.PP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PP.BorderThickness = 7;
            this.PP.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PP.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.PP.Enabled = false;
            this.PP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PP.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PP.HoverTextColor = System.Drawing.Color.White;
            this.PP.Image = global::Instanalyzer.Properties.Resources.Unknown;
            this.PP.ImageSize = new System.Drawing.Size(64, 64);
            this.PP.Location = new System.Drawing.Point(21, 78);
            this.PP.MetroStyleManager = null;
            this.PP.Name = "PP";
            this.PP.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PP.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PP.NormalTextColor = System.Drawing.Color.Black;
            this.PP.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PP.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PP.PressTextColor = System.Drawing.Color.White;
            this.PP.Size = new System.Drawing.Size(72, 72);
            this.PP.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.PP.TabIndex = 17;
            this.PP.ThemeAuthor = "Taiizor";
            this.PP.ThemeName = "MetroLite";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Instanalyzer.Properties.Resources.DuckCat;
            this.pictureBox1.Location = new System.Drawing.Point(21, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WMLBL);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.PIND);
            this.Controls.Add(this.IGLL);
            this.Controls.Add(this.PP);
            this.Name = "Wait";
            this.Size = new System.Drawing.Size(383, 299);
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox IGLL;
        private ReaLTaiizor.Controls.ProgressIndicator PIND;
        private ReaLTaiizor.Controls.MetroLabel WMLBL;
        private ReaLTaiizor.Controls.MetroEllipse PP;
        private ReaLTaiizor.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
