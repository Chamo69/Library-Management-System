namespace Library_System
{
    partial class frmInquiries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInquiries));
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new ReaLTaiizor.Controls.ParrotButton();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSearchType = new MaterialSkin.Controls.MaterialComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearchTerm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchTerm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTerm.Location = new System.Drawing.Point(446, 216);
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(188, 22);
            this.txtSearchTerm.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(441, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "_______________________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(339, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 21);
            this.label1.TabIndex = 32;
            this.label1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.ButtonImage")));
            this.btnSearch.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnSearch.ButtonText = "";
            this.btnSearch.ClickBackColor = System.Drawing.Color.Silver;
            this.btnSearch.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.CornerRadius = 5;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnSearch.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Center;
            this.btnSearch.Location = new System.Drawing.Point(631, 202);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 40);
            this.btnSearch.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSearch.TabIndex = 34;
            this.btnSearch.TextColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSearch.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bigLabel1.Location = new System.Drawing.Point(434, 3);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(147, 46);
            this.bigLabel1.TabIndex = 35;
            this.bigLabel1.Text = "Inquiries";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(339, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 37;
            this.label3.Text = "Book Name :";
            // 
            // cmbSearchType
            // 
            this.cmbSearchType.AutoResize = false;
            this.cmbSearchType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbSearchType.Depth = 0;
            this.cmbSearchType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbSearchType.DropDownHeight = 174;
            this.cmbSearchType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchType.DropDownWidth = 121;
            this.cmbSearchType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbSearchType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbSearchType.FormattingEnabled = true;
            this.cmbSearchType.IntegralHeight = false;
            this.cmbSearchType.ItemHeight = 43;
            this.cmbSearchType.Location = new System.Drawing.Point(446, 121);
            this.cmbSearchType.MaxDropDownItems = 4;
            this.cmbSearchType.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbSearchType.Name = "cmbSearchType";
            this.cmbSearchType.Size = new System.Drawing.Size(188, 49);
            this.cmbSearchType.StartIndex = 0;
            this.cmbSearchType.TabIndex = 36;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 549);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(990, 154);
            this.dataGridView2.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(449, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Book Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Book Status";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(359, 150);
            this.dataGridView1.TabIndex = 41;
            // 
            // frmInquiries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1014, 715);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSearchType);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInquiries";
            this.Text = "frmInquiries";
            this.Load += new System.EventHandler(this.frmInquiries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.ParrotButton btnSearch;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialComboBox cmbSearchType;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}