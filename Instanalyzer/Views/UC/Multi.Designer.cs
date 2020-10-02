
namespace Instanalyzer.Views.UC
{
    partial class Multi
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
            this.IGLL = new System.Windows.Forms.PictureBox();
            this.metroEllipse1 = new ReaLTaiizor.Controls.MetroEllipse();
            this.royalEllipseButton1 = new ReaLTaiizor.Controls.RoyalEllipseButton();
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).BeginInit();
            this.SuspendLayout();
            // 
            // IGLL
            // 
            this.IGLL.BackColor = System.Drawing.Color.Transparent;
            this.IGLL.Image = global::Instanalyzer.Properties.Resources.Instagram;
            this.IGLL.Location = new System.Drawing.Point(21, 6);
            this.IGLL.Name = "IGLL";
            this.IGLL.Size = new System.Drawing.Size(340, 66);
            this.IGLL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IGLL.TabIndex = 14;
            this.IGLL.TabStop = false;
            // 
            // metroEllipse1
            // 
            this.metroEllipse1.BorderThickness = 7;
            this.metroEllipse1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroEllipse1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroEllipse1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroEllipse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroEllipse1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroEllipse1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroEllipse1.HoverTextColor = System.Drawing.Color.White;
            this.metroEllipse1.Image = global::Instanalyzer.Properties.Resources.Female;
            this.metroEllipse1.ImageSize = new System.Drawing.Size(96, 96);
            this.metroEllipse1.Location = new System.Drawing.Point(21, 78);
            this.metroEllipse1.MetroStyleManager = null;
            this.metroEllipse1.Name = "metroEllipse1";
            this.metroEllipse1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroEllipse1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroEllipse1.NormalTextColor = System.Drawing.Color.Black;
            this.metroEllipse1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroEllipse1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.metroEllipse1.PressTextColor = System.Drawing.Color.White;
            this.metroEllipse1.Size = new System.Drawing.Size(100, 100);
            this.metroEllipse1.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroEllipse1.TabIndex = 17;
            this.metroEllipse1.Text = "Bayram";
            this.metroEllipse1.ThemeAuthor = "Taiizor";
            this.metroEllipse1.ThemeName = "MetroLite";
            // 
            // royalEllipseButton1
            // 
            this.royalEllipseButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.royalEllipseButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.royalEllipseButton1.BorderThickness = 3;
            this.royalEllipseButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.royalEllipseButton1.DrawBorder = true;
            this.royalEllipseButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.royalEllipseButton1.HotTrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.royalEllipseButton1.Image = global::Instanalyzer.Properties.Resources.Male;
            this.royalEllipseButton1.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageOnly;
            this.royalEllipseButton1.Location = new System.Drawing.Point(127, 78);
            this.royalEllipseButton1.Name = "royalEllipseButton1";
            this.royalEllipseButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.royalEllipseButton1.PressedForeColor = System.Drawing.Color.White;
            this.royalEllipseButton1.Size = new System.Drawing.Size(100, 100);
            this.royalEllipseButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.royalEllipseButton1.TabIndex = 18;
            this.royalEllipseButton1.Text = "Bayram Emekli";
            // 
            // Multi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.royalEllipseButton1);
            this.Controls.Add(this.metroEllipse1);
            this.Controls.Add(this.IGLL);
            this.Name = "Multi";
            this.Size = new System.Drawing.Size(383, 299);
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox IGLL;
        private ReaLTaiizor.Controls.MetroEllipse metroEllipse1;
        private ReaLTaiizor.Controls.RoyalEllipseButton royalEllipseButton1;
    }
}
