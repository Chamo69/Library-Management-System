namespace Library_System
{
    partial class frmBookRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookRegister));
            this.btnSave = new ReaLTaiizor.Controls.ParrotButton();
            this.cmbClassification = new ReaLTaiizor.Controls.MaterialComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbCopyType = new ReaLTaiizor.Controls.MaterialComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numTotalCopies = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCopies)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ButtonImage")));
            this.btnSave.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnSave.ButtonText = "Save";
            this.btnSave.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.btnSave.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.CornerRadius = 5;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSave.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnSave.Location = new System.Drawing.Point(915, 430);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 33);
            this.btnSave.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSave.TabIndex = 32;
            this.btnSave.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSave.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbClassification
            // 
            this.cmbClassification.AutoResize = false;
            this.cmbClassification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbClassification.Depth = 0;
            this.cmbClassification.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbClassification.DropDownHeight = 174;
            this.cmbClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClassification.DropDownWidth = 121;
            this.cmbClassification.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClassification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbClassification.FormattingEnabled = true;
            this.cmbClassification.Hint = "Select Classification";
            this.cmbClassification.IntegralHeight = false;
            this.cmbClassification.ItemHeight = 43;
            this.cmbClassification.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbClassification.Location = new System.Drawing.Point(333, 373);
            this.cmbClassification.MaxDropDownItems = 4;
            this.cmbClassification.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cmbClassification.Name = "cmbClassification";
            this.cmbClassification.Size = new System.Drawing.Size(190, 49);
            this.cmbClassification.StartIndex = 0;
            this.cmbClassification.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(219, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 21);
            this.label7.TabIndex = 28;
            this.label7.Text = "Classification :";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(466, 207);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(164, 22);
            this.txtISBN.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "___________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(387, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "ISBM :";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(466, 150);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(164, 22);
            this.txtAuthor.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "___________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(387, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Author :";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(466, 97);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(164, 22);
            this.txtTitle.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(461, 110);
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
            this.label1.Location = new System.Drawing.Point(387, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Title :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 469);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(990, 240);
            this.dataGridView1.TabIndex = 18;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bigLabel1.Location = new System.Drawing.Point(370, 6);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(284, 46);
            this.bigLabel1.TabIndex = 17;
            this.bigLabel1.Text = "Book Registration";
            // 
            // txtPublisher
            // 
            this.txtPublisher.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPublisher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(464, 256);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(164, 22);
            this.txtPublisher.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(459, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(169, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "___________________________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(370, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 33;
            this.label10.Text = "Publisher :";
            // 
            // cmbCopyType
            // 
            this.cmbCopyType.AutoResize = false;
            this.cmbCopyType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCopyType.Depth = 0;
            this.cmbCopyType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCopyType.DropDownHeight = 174;
            this.cmbCopyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCopyType.DropDownWidth = 121;
            this.cmbCopyType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCopyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCopyType.FormattingEnabled = true;
            this.cmbCopyType.Hint = "Select Type";
            this.cmbCopyType.IntegralHeight = false;
            this.cmbCopyType.ItemHeight = 43;
            this.cmbCopyType.Items.AddRange(new object[] {
            "Borrowable",
            "Reference"});
            this.cmbCopyType.Location = new System.Drawing.Point(654, 373);
            this.cmbCopyType.MaxDropDownItems = 4;
            this.cmbCopyType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cmbCopyType.Name = "cmbCopyType";
            this.cmbCopyType.Size = new System.Drawing.Size(142, 49);
            this.cmbCopyType.StartIndex = 0;
            this.cmbCopyType.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(559, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 21);
            this.label11.TabIndex = 36;
            this.label11.Text = "Copy Type :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "___________________________";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(352, 309);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 21);
            this.label12.TabIndex = 38;
            this.label12.Text = "Total Copies :";
            // 
            // numTotalCopies
            // 
            this.numTotalCopies.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.numTotalCopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numTotalCopies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTotalCopies.Location = new System.Drawing.Point(462, 309);
            this.numTotalCopies.Name = "numTotalCopies";
            this.numTotalCopies.Size = new System.Drawing.Size(166, 25);
            this.numTotalCopies.TabIndex = 40;
            this.numTotalCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmBookRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 715);
            this.Controls.Add(this.numTotalCopies);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbCopyType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbClassification);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bigLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBookRegister";
            this.Text = "frmBookRegister";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCopies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton btnSave;
        private ReaLTaiizor.Controls.MaterialComboBox cmbClassification;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ReaLTaiizor.Controls.MaterialComboBox cmbCopyType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numTotalCopies;
    }
}