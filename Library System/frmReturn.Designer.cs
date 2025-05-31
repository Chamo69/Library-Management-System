namespace Library_System
{
    partial class frmReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturn));
            this.btnReturnBook = new ReaLTaiizor.Controls.ParrotButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBookCopies = new MaterialSkin.Controls.MaterialComboBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturnBook.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnReturnBook.ButtonImage")));
            this.btnReturnBook.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnReturnBook.ButtonText = "Return Book";
            this.btnReturnBook.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnReturnBook.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReturnBook.CornerRadius = 5;
            this.btnReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturnBook.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReturnBook.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnReturnBook.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReturnBook.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnReturnBook.Location = new System.Drawing.Point(889, 426);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(113, 33);
            this.btnReturnBook.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnReturnBook.TabIndex = 25;
            this.btnReturnBook.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnReturnBook.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnReturnBook.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(990, 242);
            this.dataGridView1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(371, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Book Name :";
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
            this.cmbBookCopies.Location = new System.Drawing.Point(478, 246);
            this.cmbBookCopies.MaxDropDownItems = 4;
            this.cmbBookCopies.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBookCopies.Name = "cmbBookCopies";
            this.cmbBookCopies.Size = new System.Drawing.Size(166, 49);
            this.cmbBookCopies.StartIndex = 0;
            this.cmbBookCopies.TabIndex = 22;
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(480, 189);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(164, 22);
            this.txtUserId.TabIndex = 20;
            this.txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "___________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(371, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "User ID :";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bigLabel1.Location = new System.Drawing.Point(387, 3);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(241, 46);
            this.bigLabel1.TabIndex = 18;
            this.bigLabel1.Text = "Return Process";
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 715);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBookCopies);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReturn";
            this.Text = "frmReturn";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnReturnBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox cmbBookCopies;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}