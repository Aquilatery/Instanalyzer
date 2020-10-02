
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
            this.MAFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.IGLL = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).BeginInit();
            this.SuspendLayout();
            // 
            // MAFLP
            // 
            this.MAFLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MAFLP.AutoScroll = true;
            this.MAFLP.Location = new System.Drawing.Point(21, 78);
            this.MAFLP.Name = "MAFLP";
            this.MAFLP.Size = new System.Drawing.Size(340, 215);
            this.MAFLP.TabIndex = 19;
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
            // Multi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.MAFLP);
            this.Controls.Add(this.IGLL);
            this.Name = "Multi";
            this.Size = new System.Drawing.Size(383, 299);
            this.Load += new System.EventHandler(this.Multi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox IGLL;
        private System.Windows.Forms.FlowLayoutPanel MAFLP;
    }
}
