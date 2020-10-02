
namespace Instanalyzer.Views.UC
{
    partial class Copyright
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
            this.NOAL = new ReaLTaiizor.Controls.NightLabel();
            this.SuspendLayout();
            // 
            // NOAL
            // 
            this.NOAL.BackColor = System.Drawing.Color.Transparent;
            this.NOAL.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NOAL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NOAL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NOAL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(118)))), ((int)(((byte)(127)))));
            this.NOAL.Location = new System.Drawing.Point(0, 0);
            this.NOAL.Margin = new System.Windows.Forms.Padding(0);
            this.NOAL.Name = "NOAL";
            this.NOAL.Size = new System.Drawing.Size(383, 39);
            this.NOAL.TabIndex = 6;
            this.NOAL.Text = "Copyright © 2020 Soferity LLC - All rights reserved.";
            this.NOAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Copyright
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.NOAL);
            this.Name = "Copyright";
            this.Size = new System.Drawing.Size(383, 39);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.NightLabel NOAL;
    }
}
