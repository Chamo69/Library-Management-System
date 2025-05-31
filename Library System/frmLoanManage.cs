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
    public partial class frmLoanManage : Form
    {
        public frmLoanManage()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmLoanManage_Load);
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

        private void frmLoanManage_Load(object sender, EventArgs e)
        {
            LoadLoanData();
            LoadAvailableCopies();
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

        private void LoadAvailableCopies()
        {
            try
            {
                var repository = new BookRepository();
                var availableCopies = repository.GetAvailableBooks();

                if (availableCopies.Count == 0)
                {
                    MessageBox.Show("No available copies found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                cmbBookCopies.DataSource = availableCopies;
                cmbBookCopies.DisplayMember = "Title";
                cmbBookCopies.ValueMember = "CopyID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user and book data
                int userId = Convert.ToInt32(txtUserId.Text);  // Assume the user enters their User ID
                int copyId = Convert.ToInt32(cmbBookCopies.SelectedValue);  // Selected book copy ID

                var repository = new LoanRepository();

                // Check if the user is a member
                if (!repository.IsUserMember(userId))
                {
                    MessageBox.Show("User is not a member, cannot borrow books.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Prevent loan if the user is not a member
                }

                // Check if the user has any overdue books
                if (repository.HasOverdueBooks(userId))
                {
                    MessageBox.Show("You have overdue books. Please return them before borrowing new books.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Prevent loan if there are overdue books
                    txtUserId.Clear();
                }

                // Check if the user can borrow more books (maximum of 5 books)
                if (!repository.CanBorrowMoreBooks(userId))
                {
                    MessageBox.Show("You cannot borrow more than 5 books at a time.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Prevent loan if the user has already borrowed 5 books
                    txtUserId.Clear();
                }

                // Loan the book
                bool loaned = repository.LoanBook(userId, copyId);

                if (loaned)
                {
                    MessageBox.Show("Book loaned successfully! Please return the book in 2 weeks.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUserId.Clear();
                    txtUserId.Focus();
                    LoadLoanData();
                }
                else
                {
                    MessageBox.Show("Cannot loan the book. Please check eligibility (maximum limit or overdue books).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
