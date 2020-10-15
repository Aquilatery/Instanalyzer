
namespace Instanalyzer.Views.UC.Login.TOP
{
    partial class Warn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warn));
            this.ALLL = new ReaLTaiizor.Controls.NightLinkLabel();
            this.IGLL = new System.Windows.Forms.PictureBox();
            this.WNNN = new ReaLTaiizor.Controls.FoxNotification();
            this.GIF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).BeginInit();
            this.SuspendLayout();
            // 
            // ALLL
            // 
            this.ALLL.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.ALLL.BackColor = System.Drawing.Color.Transparent;
            this.ALLL.Cursor = System.Windows.Forms.Cursors.Default;
            this.ALLL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ALLL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ALLL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.ALLL.LinkColor = System.Drawing.Color.DodgerBlue;
            this.ALLL.Location = new System.Drawing.Point(0, 264);
            this.ALLL.Margin = new System.Windows.Forms.Padding(0);
            this.ALLL.Name = "ALLL";
            this.ALLL.Size = new System.Drawing.Size(383, 35);
            this.ALLL.TabIndex = 16;
            this.ALLL.TabStop = true;
            this.ALLL.Text = "Yine yeni yeniden dene.";
            this.ALLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ALLL.VisitedLinkColor = System.Drawing.Color.RoyalBlue;
            this.ALLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ALLL_LinkClicked);
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
            // WNNN
            // 
            this.WNNN.BlueBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(237)))), ((int)(((byte)(248)))));
            this.WNNN.BlueBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(217)))), ((int)(((byte)(240)))));
            this.WNNN.BlueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(143)))), ((int)(((byte)(184)))));
            this.WNNN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WNNN.EnabledCalc = true;
            this.WNNN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.WNNN.GreenBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(240)))), ((int)(((byte)(214)))));
            this.WNNN.GreenBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(182)))));
            this.WNNN.GreenTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(140)))), ((int)(((byte)(69)))));
            this.WNNN.Location = new System.Drawing.Point(21, 78);
            this.WNNN.Name = "WNNN";
            this.WNNN.RedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.WNNN.RedBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(204)))), ((int)(((byte)(209)))));
            this.WNNN.RedTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(99)))), ((int)(((byte)(94)))));
            this.WNNN.Size = new System.Drawing.Size(340, 40);
            this.WNNN.Style = ReaLTaiizor.Controls.FoxNotification.Styles.Red;
            this.WNNN.TabIndex = 20;
            this.WNNN.Text = "Çok çok üzgünüm.. Bir hatayla karşı karşıya gelindi!";
            this.WNNN.YellowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(248)))), ((int)(((byte)(225)))));
            this.WNNN.YellowBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(235)))), ((int)(((byte)(200)))));
            this.WNNN.YellowTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(131)))), ((int)(((byte)(88)))));
            this.WNNN.Click += new ReaLTaiizor.Util.FoxBase.NotifyFoxBase.ClickEventHandler(this.WNNN_Click);
            // 
            // GIF
            // 
            this.GIF.BackColor = System.Drawing.Color.Transparent;
            this.GIF.Image = ((System.Drawing.Image)(resources.GetObject("GIF.Image")));
            this.GIF.Location = new System.Drawing.Point(21, 124);
            this.GIF.Name = "GIF";
            this.GIF.Size = new System.Drawing.Size(340, 137);
            this.GIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GIF.TabIndex = 22;
            this.GIF.TabStop = false;
            // 
            // Warn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.WNNN);
            this.Controls.Add(this.ALLL);
            this.Controls.Add(this.IGLL);
            this.Controls.Add(this.GIF);
            this.Name = "Warn";
            this.Size = new System.Drawing.Size(383, 299);
            ((System.ComponentModel.ISupportInitialize)(this.IGLL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GIF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.NightLinkLabel ALLL;
        private System.Windows.Forms.PictureBox IGLL;
        private ReaLTaiizor.Controls.FoxNotification WNNN;
        private System.Windows.Forms.PictureBox GIF;
    }
}