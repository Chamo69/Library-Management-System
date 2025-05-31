namespace Library_System
{
    partial class frmLoanManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanManage));
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBookCopies = new MaterialSkin.Controls.MaterialComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLoanBook = new ReaLTaiizor.Controls.ParrotButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bigLabel1.Location = new System.Drawing.Point(357, 3);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(301, 46);
            this.bigLabel1.TabIndex = 1;
            this.bigLabel1.Text = "Loan Management";
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(480, 185);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(164, 22);
            this.txtUserId.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "___________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(371, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "User ID :";
            // 
            // cmbBookCopies
            // 
            this.cmbBookCopies.AutoResize = false;
            this.cmbBookCopies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBookCopies.Depth = 0;
            this.cmbBookCopies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBookCopies.DropDownHeight = 174;
            this.cmbBookCopies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookCopies.DropDownWidth = 121;
            this.cmbBookCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBookCopies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBookCopies.FormattingEnabled = true;
            this.cmbBookCopies.IntegralHeight = false;
            this.cmbBookCopies.ItemHeight = 43;
            this.cmbBookCopies.Location = new System.Drawing.Point(478, 242);
            this.cmbBookCopies.MaxDropDownItems = 4;
            this.cmbBookCopies.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBookCopies.Name = "cmbBookCopies";
            this.cmbBookCopies.Size = new System.Drawing.Size(166, 49);
            this.cmbBookCopies.StartIndex = 0;
            this.cmbBookCopies.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(371, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Book Name :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 461);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(990, 242);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnLoanBook
            // 
            this.btnLoanBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLoanBook.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnLoanBook.ButtonImage")));
            this.btnLoanBook.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnLoanBook.ButtonText = "Loan Book";
            this.btnLoanBook.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnLoanBook.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLoanBook.CornerRadius = 5;
            this.btnLoanBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoanBook.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLoanBook.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnLoanBook.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnLoanBook.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnLoanBook.Location = new System.Drawing.Point(895, 422);
            this.btnLoanBook.Name = "btnLoanBook";
            this.btnLoanBook.Size = new System.Drawing.Size(107, 33);
            this.btnLoanBook.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnLoanBook.TabIndex = 17;
            this.btnLoanBook.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnLoanBook.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnLoanBook.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLoanBook.Click += new System.EventHandler(this.btnLoanBook_Click);
            // 
            // frmLoanManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 715);
            this.Controls.Add(this.btnLoanBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBookCopies);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLoanManage";
            this.Text = "frmLoanManage";
            this.Load += new System.EventHandler(this.frmLoanManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialComboBox cmbBookCopies;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.Controls.ParrotButton btnLoanBook;
    }
}