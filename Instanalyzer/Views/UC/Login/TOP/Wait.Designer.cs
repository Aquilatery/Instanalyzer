
namespace Instanalyzer.Views.UC.Login.TOP
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
            this.components = new System.ComponentModel.Container();
            this.PIND = new ReaLTaiizor.Controls.ProgressIndicator();
            this.WMLBL = new ReaLTaiizor.Controls.MetroLabel();
            this.UNNS = new ReaLTaiizor.Controls.MetroLabel();
            this.IGLL = new System.Windows.Forms.PictureBox();
            this.PP = new ReaLTaiizor.Controls.MetroEllipse();
            this.GIF = new System.Windows.Forms.PictureBox();
            this.DOTT = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).BeginInit();
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
            this.WMLBL.IsDerivedStyle = true;
            this.WMLBL.Location = new System.Drawing.Point(21, 255);
            this.WMLBL.Margin = new System.Windows.Forms.Padding(3);
            this.WMLBL.Name = "WMLBL";
            this.WMLBL.Size = new System.Drawing.Size(340, 41);
            this.WMLBL.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.WMLBL.StyleManager = null;
            this.WMLBL.TabIndex = 16;
            this.WMLBL.Text = "Giriş Yapılıyor. Lütfen Bekleyin.";
            this.WMLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WMLBL.ThemeAuthor = "Taiizor";
            this.WMLBL.ThemeName = "MetroLite";
            // 
            // UNNS
            // 
            this.UNNS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UNNS.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UNNS.IsDerivedStyle = true;
            this.UNNS.Location = new System.Drawing.Point(99, 78);
            this.UNNS.Margin = new System.Windows.Forms.Padding(3);
            this.UNNS.Name = "UNNS";
            this.UNNS.Size = new System.Drawing.Size(184, 72);
            this.UNNS.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            this.UNNS.StyleManager = null;
            this.UNNS.TabIndex = 20;
            this.UNNS.Text = "ReaLTaiizor\r\nBayram Emekli";
            this.UNNS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UNNS.ThemeAuthor = "Taiizor";
            this.UNNS.ThemeName = "MetroDark";
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
            this.PP.IsDerivedStyle = true;
            this.PP.Location = new System.Drawing.Point(21, 78);
            this.PP.Name = "PP";
            this.PP.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PP.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.PP.NormalTextColor = System.Drawing.Color.Black;
            this.PP.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PP.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.PP.PressTextColor = System.Drawing.Color.White;
            this.PP.Size = new System.Drawing.Size(72, 72);
            this.PP.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.PP.StyleManager = null;
            this.PP.TabIndex = 17;
            this.PP.ThemeAuthor = "Taiizor";
            this.PP.ThemeName = "MetroLite";
            // 
            // GIF
            // 
            this.GIF.BackColor = System.Drawing.Color.Transparent;
            this.GIF.Image = global::Instanalyzer.Properties.Resources.DuckCat;
            this.GIF.Location = new System.Drawing.Point(21, 156);
            this.GIF.Name = "GIF";
            this.GIF.Size = new System.Drawing.Size(340, 93);
            this.GIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GIF.TabIndex = 21;
            this.GIF.TabStop = false;
            // 
            // DOTT
            // 
            this.DOTT.Enabled = true;
            this.DOTT.Interval = 250;
            this.DOTT.Tick += new System.EventHandler(this.DOTT_Tick);
            // 
            // Wait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.GIF);
            this.Controls.Add(this.WMLBL);
            this.Controls.Add(this.UNNS);
            this.Controls.Add(this.PIND);
            this.Controls.Add(this.IGLL);
            this.Controls.Add(this.PP);
            this.Name = "Wait";
            this.Size = new System.Drawing.Size(383, 299);
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox IGLL;
        private ReaLTaiizor.Controls.ProgressIndicator PIND;
        private ReaLTaiizor.Controls.MetroLabel WMLBL;
        private ReaLTaiizor.Controls.MetroEllipse PP;
        private ReaLTaiizor.Controls.MetroLabel UNNS;
        private System.Windows.Forms.PictureBox GIF;
        private System.Windows.Forms.Timer DOTT;
    }
}