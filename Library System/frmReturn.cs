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
    public partial class frmReturn : Form
    {
        public frmReturn()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmReturn_Load);
            txtUserId.TextChanged += new EventHandler(txtUserId_TextChanged);
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

        private void frmReturn_Load(object sender, EventArgs e)
        {
            LoadLoanData();
        }

        private void LoadLoanData()
        {
            try
            {
                var repository = new LoanRepository();
                DataTable loansTable = repository.GetAllLoans();
                dataGridView1.DataSource = loansTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading loan data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBorrowedBooks()
        {
            try
            {
                int userId;
                if (int.TryParse(txtUserId.Text, out userId))
                {
                    var repository = new LoanRepository();
                    var borrowedBooks = repository.GetBorrowedBooks(userId);

                    cmbBookCopies.DataSource = borrowedBooks;
                    cmbBookCopies.DisplayMember = "Title";
                    cmbBookCopies.ValueMember = "CopyID";
                }
                else
                {
                    cmbBookCopies.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading borrowed books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = Convert.ToInt32(txtUserId.Text);
                int copyId = Convert.ToInt32(cmbBookCopies.SelectedValue);

                var repository = new LoanRepository();
                repository.ReturnBook(userId, copyId);

                var reservedUser = repository.GetReservationDetails(copyId);
                if (reservedUser != null)
                {
                    MessageBox.Show($"The book copy is reserved by Member ID: {reservedUser.UserID}. Please inform them accordingly.",
                    "Book Reserved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBorrowedBooks(); // Refresh the list of borrowed books
                LoadLoanData(); // Refresh the loan data
                txtUserId.Clear();
                txtUserId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReturn_Load_2(object sender, EventArgs e)
        {
            try
            {
                var repository = new BookRepository();
                var availableCopies = repository.GetAvailableBooks();

                cmbBookCopies.DataSource = availableCopies;
                cmbBookCopies.DisplayMember = "Title";
                cmbBookCopies.ValueMember = "CopyID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }
    }
}
