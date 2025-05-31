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
    public partial class frmReservation: Form
    {
        public frmReservation()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmReservation_Load);
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

        private void frmReservation_Load(object sender, EventArgs e)
        {
            LoadReservationData();
            LoadAvailableBooks();
        }

        private void LoadReservationData()
        {
            try
            {
                var repository = new ReservationRepository();
                DataTable reservationsTable = repository.GetAllReservations();
                dataGridView1.DataSource = reservationsTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading reservation data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReserveBook_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = Convert.ToInt32(txtUserId.Text);
                int bookId = Convert.ToInt32(cmbBooks.SelectedValue);


                var repository = new ReservationRepository();
                repository.ReserveBook(userId, bookId);

                MessageBox.Show("Book reserved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadReservationData();
                txtUserId.Clear();
                txtUserId.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableBooks()
        {
            try
            {
                var repository = new BookRepository();
                var availableBooks = repository.GetAvailableTitles();

                cmbBooks.DataSource = availableBooks;
                cmbBooks.DisplayMember = "Title";
                cmbBooks.ValueMember = "CopyID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading books: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
