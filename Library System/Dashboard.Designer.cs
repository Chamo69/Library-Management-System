namespace Library_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlDrag = new System.Windows.Forms.Panel();
            this.btnClose = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmenu = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.pnlInqury = new System.Windows.Forms.Panel();
            this.btnInquiries = new System.Windows.Forms.Button();
            this.pnlLogout = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlReserver = new System.Windows.Forms.Panel();
            this.btnReservation = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlLoan = new System.Windows.Forms.Panel();
            this.btnLoan = new System.Windows.Forms.Button();
            this.pnlBook = new System.Windows.Forms.Panel();
            this.btnBookRegister = new System.Windows.Forms.Button();
            this.pnlReturn = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.btnUserRegister = new System.Windows.Forms.Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlPages = new System.Windows.Forms.Panel();
            this.timerFade = new System.Windows.Forms.Timer(this.components);
            this.pnlDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).BeginInit();
            this.sidebar.SuspendLayout();
            this.pnlInqury.SuspendLayout();
            this.pnlLogout.SuspendLayout();
            this.pnlReserver.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlLoan.SuspendLayout();
            this.pnlBook.SuspendLayout();
            this.pnlReturn.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDrag
            // 
            this.pnlDrag.BackColor = System.Drawing.Color.White;
            this.pnlDrag.Controls.Add(this.btnClose);
            this.pnlDrag.Controls.Add(this.label1);
            this.pnlDrag.Controls.Add(this.btnmenu);
            this.pnlDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDrag.Location = new System.Drawing.Point(0, 0);
            this.pnlDrag.Name = "pnlDrag";
            this.pnlDrag.Size = new System.Drawing.Size(1231, 33);
            this.pnlDrag.TabIndex = 0;
            this.pnlDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrag_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnClose.CloseHoverForeColor = System.Drawing.Color.DimGray;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DefaultLocation = true;
            this.btnClose.DisableMaximizeColor = System.Drawing.Color.White;
            this.btnClose.DisableMinimizeColor = System.Drawing.Color.White;
            this.btnClose.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.btnClose.EnableMaximizeButton = false;
            this.btnClose.EnableMaximizeColor = System.Drawing.Color.White;
            this.btnClose.EnableMinimizeButton = false;
            this.btnClose.EnableMinimizeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1092, 0);
            this.btnClose.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.btnClose.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(139, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // btnmenu
            // 
            this.btnmenu.Image = ((System.Drawing.Image)(resources.GetObject("btnmenu.Image")));
            this.btnmenu.Location = new System.Drawing.Point(9, 3);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(27, 28);
            this.btnmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnmenu.TabIndex = 1;
            this.btnmenu.TabStop = false;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.sidebar.Controls.Add(this.pnlInqury);
            this.sidebar.Controls.Add(this.pnlLogout);
            this.sidebar.Controls.Add(this.pnlReserver);
            this.sidebar.Controls.Add(this.pnlHome);
            this.sidebar.Controls.Add(this.pnlLoan);
            this.sidebar.Controls.Add(this.pnlBook);
            this.sidebar.Controls.Add(this.pnlReturn);
            this.sidebar.Controls.Add(this.pnlUser);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 33);
            this.sidebar.Name = "sidebar";
            this.sidebar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.sidebar.Size = new System.Drawing.Size(219, 715);
            this.sidebar.TabIndex = 1;
            // 
            // pnlInqury
            // 
            this.pnlInqury.Controls.Add(this.btnInquiries);
            this.pnlInqury.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlInqury.Location = new System.Drawing.Point(9, 369);
            this.pnlInqury.Name = "pnlInqury";
            this.pnlInqury.Size = new System.Drawing.Size(227, 50);
            this.pnlInqury.TabIndex = 7;
            // 
            // btnInquiries
            // 
            this.btnInquiries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnInquiries.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInquiries.ForeColor = System.Drawing.Color.White;
            this.btnInquiries.Image = ((System.Drawing.Image)(resources.GetObject("btnInquiries.Image")));
            this.btnInquiries.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInquiries.Location = new System.Drawing.Point(-17, -24);
            this.btnInquiries.Name = "btnInquiries";
            this.btnInquiries.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnInquiries.Size = new System.Drawing.Size(258, 99);
            this.btnInquiries.TabIndex = 2;
            this.btnInquiries.Text = "         Inquiries";
            this.btnInquiries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInquiries.UseVisualStyleBackColor = false;
            this.btnInquiries.Click += new System.EventHandler(this.btnInquiries_Click);
            // 
            // pnlLogout
            // 
            this.pnlLogout.Controls.Add(this.btnLogout);
            this.pnlLogout.Location = new System.Drawing.Point(-8, 663);
            this.pnlLogout.Name = "pnlLogout";
            this.pnlLogout.Size = new System.Drawing.Size(218, 50);
            this.pnlLogout.TabIndex = 8;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-3, -24);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(235, 99);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "          Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlReserver
            // 
            this.pnlReserver.Controls.Add(this.btnReservation);
            this.pnlReserver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlReserver.Location = new System.Drawing.Point(9, 313);
            this.pnlReserver.Name = "pnlReserver";
            this.pnlReserver.Size = new System.Drawing.Size(227, 50);
            this.pnlReserver.TabIndex = 6;
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnReservation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnReservation.Image")));
            this.btnReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.Location = new System.Drawing.Point(-17, -24);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReservation.Size = new System.Drawing.Size(258, 99);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "         Reservation Process";
            this.btnReservation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.btnHome);
            this.pnlHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlHome.Location = new System.Drawing.Point(9, 33);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(227, 50);
            this.pnlHome.TabIndex = 3;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(-17, -24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(261, 99);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "         Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlLoan
            // 
            this.pnlLoan.Controls.Add(this.btnLoan);
            this.pnlLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlLoan.Location = new System.Drawing.Point(9, 201);
            this.pnlLoan.Name = "pnlLoan";
            this.pnlLoan.Size = new System.Drawing.Size(227, 50);
            this.pnlLoan.TabIndex = 6;
            // 
            // btnLoan
            // 
            this.btnLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnLoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.White;
            this.btnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoan.Image")));
            this.btnLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.Location = new System.Drawing.Point(-17, -24);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLoan.Size = new System.Drawing.Size(258, 99);
            this.btnLoan.TabIndex = 2;
            this.btnLoan.Text = "         Loan Management";
            this.btnLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // pnlBook
            // 
            this.pnlBook.Controls.Add(this.btnBookRegister);
            this.pnlBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBook.Location = new System.Drawing.Point(9, 145);
            this.pnlBook.Name = "pnlBook";
            this.pnlBook.Size = new System.Drawing.Size(227, 50);
            this.pnlBook.TabIndex = 5;
            // 
            // btnBookRegister
            // 
            this.btnBookRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnBookRegister.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRegister.ForeColor = System.Drawing.Color.White;
            this.btnBookRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnBookRegister.Image")));
            this.btnBookRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookRegister.Location = new System.Drawing.Point(-17, -24);
            this.btnBookRegister.Name = "btnBookRegister";
            this.btnBookRegister.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBookRegister.Size = new System.Drawing.Size(258, 99);
            this.btnBookRegister.TabIndex = 2;
            this.btnBookRegister.Text = "         Book Registration";
            this.btnBookRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookRegister.UseVisualStyleBackColor = false;
            this.btnBookRegister.Click += new System.EventHandler(this.btnBookRegister_Click);
            // 
            // pnlReturn
            // 
            this.pnlReturn.Controls.Add(this.btnReturn);
            this.pnlReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlReturn.Location = new System.Drawing.Point(9, 257);
            this.pnlReturn.Name = "pnlReturn";
            this.pnlReturn.Size = new System.Drawing.Size(227, 50);
            this.pnlReturn.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnReturn.Image")));
            this.btnReturn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.Location = new System.Drawing.Point(-17, -24);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnReturn.Size = new System.Drawing.Size(258, 99);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "         Return Process";
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.btnUserRegister);
            this.pnlUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlUser.Location = new System.Drawing.Point(9, 89);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(227, 50);
            this.pnlUser.TabIndex = 4;
            // 
            // btnUserRegister
            // 
            this.btnUserRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnUserRegister.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserRegister.ForeColor = System.Drawing.Color.White;
            this.btnUserRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnUserRegister.Image")));
            this.btnUserRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRegister.Location = new System.Drawing.Point(-17, -24);
            this.btnUserRegister.Name = "btnUserRegister";
            this.btnUserRegister.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUserRegister.Size = new System.Drawing.Size(258, 99);
            this.btnUserRegister.TabIndex = 2;
            this.btnUserRegister.Text = "         User Registration";
            this.btnUserRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserRegister.UseVisualStyleBackColor = false;
            this.btnUserRegister.Click += new System.EventHandler(this.btnUserRegister_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(493, 409);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pnlPages
            // 
            this.pnlPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.pnlPages.Controls.Add(this.pictureBox1);
            this.pnlPages.Location = new System.Drawing.Point(217, 33);
            this.pnlPages.Name = "pnlPages";
            this.pnlPages.Size = new System.Drawing.Size(1014, 715);
            this.pnlPages.TabIndex = 3;
            // 
            // timerFade
            // 
            this.timerFade.Interval = 50;
            this.timerFade.Tick += new System.EventHandler(this.timerFade_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1231, 748);
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnlDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlDrag.ResumeLayout(false);
            this.pnlDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnmenu)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.pnlInqury.ResumeLayout(false);
            this.pnlLogout.ResumeLayout(false);
            this.pnlReserver.ResumeLayout(false);
            this.pnlHome.ResumeLayout(false);
            this.pnlLoan.ResumeLayout(false);
            this.pnlBook.ResumeLayout(false);
            this.pnlReturn.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDrag;
        private System.Windows.Forms.PictureBox btnmenu;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.NightControlBox btnClose;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Button btnUserRegister;
        private System.Windows.Forms.Panel pnlLoan;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Panel pnlBook;
        private System.Windows.Forms.Button btnBookRegister;
        private System.Windows.Forms.Panel pnlReserver;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Panel pnlReturn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlInqury;
        private System.Windows.Forms.Button btnInquiries;
        private System.Windows.Forms.Panel pnlLogout;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPages;
        private System.Windows.Forms.Timer timerFade;
    }
}