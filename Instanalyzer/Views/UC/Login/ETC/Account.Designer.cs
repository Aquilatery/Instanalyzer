
namespace Instanalyzer.Views.UC.Login.ETC
{
    partial class Account
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
            this.PP = new ReaLTaiizor.Controls.MetroEllipse();
            this.PPTT = new ReaLTaiizor.Controls.MetroToolTip();
            this.SuspendLayout();
            // 
            // PP
            // 
            this.PP.BorderThickness = 7;
            this.PP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PP.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PP.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PP.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.PP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.PP.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PP.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PP.HoverTextColor = System.Drawing.Color.White;
            this.PP.Image = global::Instanalyzer.Properties.Resources.Unknown;
            this.PP.ImageSize = new System.Drawing.Size(64, 64);
            this.PP.IsDerivedStyle = true;
            this.PP.Location = new System.Drawing.Point(0, 0);
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
            this.PP.TabIndex = 0;
            this.PP.ThemeAuthor = "Taiizor";
            this.PP.ThemeName = "MetroLite";
            this.PPTT.SetToolTip(this.PP, "{0}\r\n{1}");
            this.PP.Click += new System.EventHandler(this.PP_Click);
            // 
            // PPTT
            // 
            this.PPTT.BackColor = System.Drawing.Color.White;
            this.PPTT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PPTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.PPTT.IsDerivedStyle = true;
            this.PPTT.OwnerDraw = true;
            this.PPTT.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.PPTT.StyleManager = null;
            this.PPTT.ThemeAuthor = "Taiizor";
            this.PPTT.ThemeName = "MetroLite";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.PP);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(72, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MetroEllipse PP;
        private ReaLTaiizor.Controls.MetroToolTip PPTT;
    }
}