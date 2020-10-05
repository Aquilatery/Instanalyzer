
namespace Instanalyzer.Views.UI.ETC
{
    partial class Thank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thank));
            this.TY = new System.Windows.Forms.PictureBox();
            this.TYT = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TY)).BeginInit();
            this.SuspendLayout();
            // 
            // TY
            // 
            this.TY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TY.Image = global::Instanalyzer.Properties.Resources.ThankYou;
            this.TY.Location = new System.Drawing.Point(0, 0);
            this.TY.Margin = new System.Windows.Forms.Padding(0);
            this.TY.Name = "TY";
            this.TY.Size = new System.Drawing.Size(370, 300);
            this.TY.TabIndex = 0;
            this.TY.TabStop = false;
            // 
            // TYT
            // 
            this.TYT.Enabled = true;
            this.TYT.Interval = 2345;
            this.TYT.Tick += new System.EventHandler(this.TYT_Tick);
            // 
            // Thank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(370, 300);
            this.ControlBox = false;
            this.Controls.Add(this.TY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Thank";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thank You";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            ((System.ComponentModel.ISupportInitialize)(this.TY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TY;
        private System.Windows.Forms.Timer TYT;
    }
}