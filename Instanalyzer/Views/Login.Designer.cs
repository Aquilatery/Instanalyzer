
namespace Instanalyzer.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.URN = new ReaLTaiizor.Controls.MaterialTextBox();
            this.PWD = new ReaLTaiizor.Controls.MaterialTextBox();
            this.materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            this.PSWS = new ReaLTaiizor.Controls.MaterialSwitch();
            this.materialButton1 = new ReaLTaiizor.Controls.MaterialButton();
            this.TBPG = new ReaLTaiizor.Controls.MaterialTabControl();
            this.MAIN = new System.Windows.Forms.TabPage();
            this.WAIT = new System.Windows.Forms.TabPage();
            this.progressIndicator1 = new ReaLTaiizor.Controls.ProgressIndicator();
            this.materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            this.TBPG.SuspendLayout();
            this.MAIN.SuspendLayout();
            this.WAIT.SuspendLayout();
            this.SuspendLayout();
            // 
            // URN
            // 
            this.URN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.URN.Depth = 0;
            this.URN.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.URN.Hint = "Username";
            this.URN.Location = new System.Drawing.Point(6, 6);
            this.URN.MaxLength = 50;
            this.URN.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.URN.Multiline = false;
            this.URN.Name = "URN";
            this.URN.Size = new System.Drawing.Size(316, 50);
            this.URN.TabIndex = 15;
            this.URN.Text = "";
            // 
            // PWD
            // 
            this.PWD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWD.Depth = 0;
            this.PWD.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PWD.Hint = "Password";
            this.PWD.Location = new System.Drawing.Point(6, 62);
            this.PWD.MaxLength = 50;
            this.PWD.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.PWD.Multiline = false;
            this.PWD.Name = "PWD";
            this.PWD.Password = true;
            this.PWD.Size = new System.Drawing.Size(255, 50);
            this.PWD.TabIndex = 16;
            this.PWD.Text = "";
            // 
            // materialCheckBox1
            // 
            this.materialCheckBox1.AutoSize = true;
            this.materialCheckBox1.Checked = true;
            this.materialCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialCheckBox1.Depth = 0;
            this.materialCheckBox1.Location = new System.Drawing.Point(6, 122);
            this.materialCheckBox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckBox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialCheckBox1.Name = "materialCheckBox1";
            this.materialCheckBox1.Ripple = true;
            this.materialCheckBox1.Size = new System.Drawing.Size(137, 37);
            this.materialCheckBox1.TabIndex = 17;
            this.materialCheckBox1.Text = "Remember Me";
            this.materialCheckBox1.UseVisualStyleBackColor = true;
            // 
            // PSWS
            // 
            this.PSWS.AutoSize = true;
            this.PSWS.Depth = 0;
            this.PSWS.Location = new System.Drawing.Point(264, 67);
            this.PSWS.Margin = new System.Windows.Forms.Padding(0);
            this.PSWS.MouseLocation = new System.Drawing.Point(-1, -1);
            this.PSWS.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.PSWS.Name = "PSWS";
            this.PSWS.Ripple = true;
            this.PSWS.Size = new System.Drawing.Size(58, 37);
            this.PSWS.TabIndex = 18;
            this.PSWS.UseAccentColor = true;
            this.PSWS.UseVisualStyleBackColor = true;
            this.PSWS.CheckedChanged += new System.EventHandler(this.PSWS_CheckedChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(249, 121);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(73, 36);
            this.materialButton1.TabIndex = 19;
            this.materialButton1.Text = "SIGN IN";
            this.materialButton1.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.MaterialButton1_Click);
            // 
            // TBPG
            // 
            this.TBPG.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.TBPG.Controls.Add(this.MAIN);
            this.TBPG.Controls.Add(this.WAIT);
            this.TBPG.Depth = 0;
            this.TBPG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBPG.Location = new System.Drawing.Point(0, 60);
            this.TBPG.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.TBPG.Multiline = true;
            this.TBPG.Name = "TBPG";
            this.TBPG.SelectedIndex = 0;
            this.TBPG.Size = new System.Drawing.Size(337, 277);
            this.TBPG.TabIndex = 20;
            // 
            // MAIN
            // 
            this.MAIN.Controls.Add(this.URN);
            this.MAIN.Controls.Add(this.materialButton1);
            this.MAIN.Controls.Add(this.PWD);
            this.MAIN.Controls.Add(this.PSWS);
            this.MAIN.Controls.Add(this.materialCheckBox1);
            this.MAIN.Location = new System.Drawing.Point(4, 4);
            this.MAIN.Name = "MAIN";
            this.MAIN.Padding = new System.Windows.Forms.Padding(3);
            this.MAIN.Size = new System.Drawing.Size(329, 244);
            this.MAIN.TabIndex = 0;
            this.MAIN.Text = "MAIN";
            this.MAIN.UseVisualStyleBackColor = true;
            // 
            // WAIT
            // 
            this.WAIT.Controls.Add(this.materialLabel1);
            this.WAIT.Controls.Add(this.progressIndicator1);
            this.WAIT.Location = new System.Drawing.Point(4, 4);
            this.WAIT.Name = "WAIT";
            this.WAIT.Padding = new System.Windows.Forms.Padding(3);
            this.WAIT.Size = new System.Drawing.Size(329, 244);
            this.WAIT.TabIndex = 1;
            this.WAIT.Text = "WAIT";
            this.WAIT.UseVisualStyleBackColor = true;
            // 
            // progressIndicator1
            // 
            this.progressIndicator1.Location = new System.Drawing.Point(124, 55);
            this.progressIndicator1.MinimumSize = new System.Drawing.Size(50, 50);
            this.progressIndicator1.Name = "progressIndicator1";
            this.progressIndicator1.P_AnimationColor = System.Drawing.Color.DimGray;
            this.progressIndicator1.P_AnimationSpeed = 100;
            this.progressIndicator1.P_BaseColor = System.Drawing.Color.DarkGray;
            this.progressIndicator1.Size = new System.Drawing.Size(80, 80);
            this.progressIndicator1.TabIndex = 0;
            this.progressIndicator1.Text = "progressIndicator1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(54, 138);
            this.materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(224, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Giriş Yapılıyor. Lütfen Bekleyin..";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(337, 337);
            this.Controls.Add(this.TBPG);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.TBPG.ResumeLayout(false);
            this.MAIN.ResumeLayout(false);
            this.MAIN.PerformLayout();
            this.WAIT.ResumeLayout(false);
            this.WAIT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBox URN;
        private ReaLTaiizor.Controls.MaterialTextBox PWD;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.MaterialSwitch PSWS;
        private ReaLTaiizor.Controls.MaterialButton materialButton1;
        private ReaLTaiizor.Controls.MaterialTabControl TBPG;
        private System.Windows.Forms.TabPage MAIN;
        private System.Windows.Forms.TabPage WAIT;
        private ReaLTaiizor.Controls.ProgressIndicator progressIndicator1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
    }
}