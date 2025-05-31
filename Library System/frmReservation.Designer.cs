namespace Library_System
{
    partial class frmReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReservation));
            this.btnReserveBook = new ReaLTaiizor.Controls.ParrotButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBooks = new MaterialSkin.Controls.MaterialComboBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReserveBook
            // 
            this.btnReserveBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReserveBook.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnReserveBook.ButtonImage")));
            this.btnReserveBook.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnReserveBook.ButtonText = "Reserve";
            this.btnReserveBook.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnReserveBook.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReserveBook.CornerRadius = 5;
            this.btnReserveBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserveBook.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReserveBook.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnReserveBook.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnReserveBook.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnReserveBook.Location = new System.Drawing.Point(907, 425);
            this.btnReserveBook.Name = "btnReserveBook";
            this.btnReserveBook.Size = new System.Drawing.Size(95, 33);
            this.btnReserveBook.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnReserveBook.TabIndex = 33;
            this.btnReserveBook.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnReserveBook.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnReserveBook.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnReserveBook.Click += new System.EventHandler(this.btnReserveBook_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 464);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(990, 242);
            this.dataGridView1.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(371, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Book Name :";
            // 
            // cmbBooks
            // 
            this.cmbBooks.AutoResize = false;
            this.cmbBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBooks.Depth = 0;
            this.cmbBooks.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBooks.DropDownHeight = 174;
            this.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooks.DropDownWidth = 121;
            this.cmbBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBooks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.IntegralHeight = false;
            this.cmbBooks.ItemHeight = 43;
            this.cmbBooks.Location = new System.Drawing.Point(478, 245);
            this.cmbBooks.MaxDropDownItems = 4;
            this.cmbBooks.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(166, 49);
            this.cmbBooks.StartIndex = 0;
            this.cmbBooks.TabIndex = 30;
            // 
            // txtUserId
            // 
            this.txtUserId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtUserId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(480, 188);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(164, 22);
            this.txtUserId.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "___________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(371, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "User ID :";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bigLabel1.Location = new System.Drawing.Point(411, 3);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(193, 46);
            this.bigLabel1.TabIndex = 26;
            this.bigLabel1.Text = "Reservation";
            // 
            // frmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 715);
            this.Controls.Add(this.btnReserveBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReservation";
            this.Text = "frmReservation";
            this.Load += new System.EventHandler(this.frmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnReserveBook;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox cmbBooks;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
    }
}