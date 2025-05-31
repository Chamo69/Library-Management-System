using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class frmBookRegister: Form
    {
        public frmBookRegister()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmBookRegister_Load);
            StyleDataGridView(dataGridView1);
        }

        void StyleDataGridView(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.DefaultCellStyle.Font = new Font("Arial", 10);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(194, 210, 227);
        }

        private void frmBookRegister_Load(object sender, EventArgs e)
        {
            LoadBookData();
        }

        private void LoadBookData()
        {
            try
            {
                var repository = new BookRepository();
                DataTable booksTable = repository.GetAllBooks();
                dataGridView1.DataSource = booksTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading book data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbClassification.SelectedIndex == -1 || txtTitle.Text == "" || txtAuthor.Text == "" || txtISBN.Text == "" || txtPublisher.Text == "" || cmbCopyType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all fields.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
                txtTitle.Focus();
            }

            try
            {
                string classification = cmbClassification.SelectedItem.ToString();
                string title = txtTitle.Text;
                string author = txtAuthor.Text;
                string isbn = txtISBN.Text;
                string publisher = txtPublisher.Text;
                int totalCopies = (int)numTotalCopies.Value;
                string copyType = cmbCopyType.SelectedItem.ToString();

                if (totalCopies > 10)
                {
                    MessageBox.Show("You can only register up to 10 copies per book.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    numTotalCopies.Focus();
                }

                var repository = new BookRepository();
                repository.AddBookWithCopies(classification, title, author, isbn, publisher, totalCopies, copyType);
                txtTitle.Clear();
                txtAuthor.Clear();
                txtISBN.Clear();
                txtPublisher.Clear();
                numTotalCopies.Value = 1;
                cmbClassification.SelectedIndex = -1;
                cmbCopyType.SelectedIndex = -1;
                txtTitle.Focus();

                LoadBookData();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
