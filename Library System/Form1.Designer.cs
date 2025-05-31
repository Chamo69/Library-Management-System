namespace Library_System
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonLinkLabel3 = new Krypton.Toolkit.KryptonLinkLabel();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.txtUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClose = new ReaLTaiizor.Controls.NightControlBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 546);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(203)))), ((int)(((byte)(218)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.kryptonLinkLabel3);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(547, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 530);
            this.panel1.TabIndex = 1;
            // 
            // kryptonLinkLabel3
            // 
            this.kryptonLinkLabel3.Location = new System.Drawing.Point(86, 397);
            this.kryptonLinkLabel3.Name = "kryptonLinkLabel3";
            this.kryptonLinkLabel3.Size = new System.Drawing.Size(101, 20);
            this.kryptonLinkLabel3.TabIndex = 17;
            this.kryptonLinkLabel3.Values.Text = "Forget Password";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLogin.Depth = 0;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.HighEmphasis = true;
            this.btnLogin.Icon = ((System.Drawing.Image)(resources.GetObject("btnLogin.Icon")));
            this.btnLogin.Location = new System.Drawing.Point(282, 413);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLogin.Size = new System.Drawing.Size(92, 36);
            this.btnLogin.TabIndex = 16;
            this.btnLogin.Text = "login";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(177, 89);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AnimateReadOnly = false;
            this.txtPassword.BackColor = System.Drawing.Color.Black;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Depth = 0;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Hint = "Password";
            this.txtPassword.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtPassword.LeadingIcon")));
            this.txtPassword.Location = new System.Drawing.Point(86, 341);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Password = true;
            this.txtPassword.Size = new System.Drawing.Size(288, 50);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Text = "";
            this.txtPassword.TrailingIcon = null;
            // 
            // txtUsername
            // 
            this.txtUsername.AnimateReadOnly = false;
            this.txtUsername.BackColor = System.Drawing.Color.Black;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Depth = 0;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Hint = "Username";
            this.txtUsername.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtUsername.LeadingIcon")));
            this.txtUsername.LeaveOnEnterKey = true;
            this.txtUsername.Location = new System.Drawing.Point(86, 285);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(288, 50);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Text = "";
            this.txtUsername.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management System";
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(57)))));
            this.pnlDrag.Controls.Add(this.pictureBox3);
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(1015, 28);
            this.pnlDrag.TabIndex = 2;
            this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.CloseHoverForeColor = System.Drawing.Color.DimGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DefaultLocation = true;
            this.btnClose.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.btnClose.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.btnClose.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnClose.EnableMaximizeButton = false;
            this.btnClose.EnableMaximizeColor = System.Drawing.Color.White;
            this.btnClose.EnableMinimizeButton = false;
            this.btnClose.EnableMinimizeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(876, 0);
            this.btnClose.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.btnClose.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 31);
            this.btnClose.TabIndex = 18;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1015, 589);
            this.Controls.Add(this.pnlDrag);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlDrag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtUsername;
        private MaterialSkin.Controls.MaterialTextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel2;
        private Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel3;
        private System.Windows.Forms.Panel pnlDrag;
        private ReaLTaiizor.Controls.NightControlBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
    }
}

