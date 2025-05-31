namespace Library_System
{
    partial class frmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nightHeaderLabel1 = new ReaLTaiizor.Controls.NightHeaderLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.aloneProgressBar1 = new ReaLTaiizor.Controls.AloneProgressBar();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(178, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 270);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nightHeaderLabel1
            // 
            this.nightHeaderLabel1.AutoSize = true;
            this.nightHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.nightHeaderLabel1.Font = new System.Drawing.Font("News701 BT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nightHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(206)))), ((int)(((byte)(223)))));
            this.nightHeaderLabel1.LeftSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nightHeaderLabel1.Location = new System.Drawing.Point(245, 319);
            this.nightHeaderLabel1.Name = "nightHeaderLabel1";
            this.nightHeaderLabel1.RightSideForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(171)))), ((int)(((byte)(176)))));
            this.nightHeaderLabel1.Side = ReaLTaiizor.Controls.NightHeaderLabel.PanelSide.LeftPanel;
            this.nightHeaderLabel1.Size = new System.Drawing.Size(189, 42);
            this.nightHeaderLabel1.TabIndex = 1;
            this.nightHeaderLabel1.Text = "WELCOME";
            this.nightHeaderLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nightHeaderLabel1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.nightHeaderLabel1.UseCompatibleTextRendering = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            // 
            // aloneProgressBar1
            // 
            this.aloneProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.aloneProgressBar1.BackgroundColor = System.Drawing.Color.Green;
            this.aloneProgressBar1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.aloneProgressBar1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.aloneProgressBar1.Location = new System.Drawing.Point(-4, 382);
            this.aloneProgressBar1.Maximum = 100;
            this.aloneProgressBar1.Minimum = 0;
            this.aloneProgressBar1.Name = "aloneProgressBar1";
            this.aloneProgressBar1.Size = new System.Drawing.Size(690, 29);
            this.aloneProgressBar1.Stripes = System.Drawing.Color.DarkGreen;
            this.aloneProgressBar1.TabIndex = 2;
            this.aloneProgressBar1.Text = "aloneProgressBar1";
            this.aloneProgressBar1.Value = 10;
            // 
            // timerFade
            // 
            this.timerFade.Interval = 20;
            this.timerFade.Tick += new System.EventHandler(this.timerFade_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(679, 407);
            this.Controls.Add(this.aloneProgressBar1);
            this.Controls.Add(this.nightHeaderLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSplashScreen";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            this.Load += new System.EventHandler(this.frmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightHeaderLabel nightHeaderLabel1;
        private System.Windows.Forms.Timer timer1;
        private ReaLTaiizor.Controls.AloneProgressBar aloneProgressBar1;
        private System.Windows.Forms.Timer timerFade;
    }
}