
namespace Instanalyzer.Views.UC
{
    partial class Login
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
            this.RGLL = new ReaLTaiizor.Controls.NightLinkLabel();
            this.NOAL = new ReaLTaiizor.Controls.NightLabel();
            this.SuspendLayout();
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
            this.RGLL.Location = new System.Drawing.Point(208, 0);
            this.RGLL.Margin = new System.Windows.Forms.Padding(0);
            this.RGLL.Name = "RGLL";
            this.RGLL.Size = new System.Drawing.Size(175, 39);
            this.RGLL.TabIndex = 7;
            this.RGLL.TabStop = true;
            this.RGLL.Text = "Hesap Ekle";
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
            this.NOAL.Size = new System.Drawing.Size(208, 39);
            this.NOAL.TabIndex = 6;
            this.NOAL.Text = "Başka hesabın mı var?";
            this.NOAL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.RGLL);
            this.Controls.Add(this.NOAL);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(383, 39);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.NightLinkLabel RGLL;
        private ReaLTaiizor.Controls.NightLabel NOAL;
    }
}
