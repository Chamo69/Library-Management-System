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
    public partial class frmInquiries: Form
    {
        public frmInquiries()
        {
            InitializeComponent();
            StyleDataGridView(dataGridView1);
            StyleDataGridView(dataGridView2);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearchTerm.Text.Trim();
                string searchType = cmbSearchType.SelectedItem.ToString();

                var repository = new BookRepository();
                var bookStatus = repository.GetBookStatus(searchTerm, searchType);

                DataTable dt = new DataTable();
                dt.Columns.Add("Search Term");
                dt.Columns.Add("Search Type");
                dt.Columns.Add("Status");

                DataRow row = dt.NewRow();
                row["Search Term"] = searchTerm;
                row["Search Type"] = searchType;
                row["Status"] = bookStatus == "Borrowable" ? "Available" : "Not Available";
                dt.Rows.Add(row);

                dataGridView1.DataSource = dt;

                // Load book details into dataGridView2
                DataTable bookDetails = repository.GetBookDetails(searchTerm, searchType);
                dataGridView2.DataSource = bookDetails;
                txtSearchTerm.Clear();
                txtSearchTerm.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmInquiries_Load(object sender, EventArgs e)
        {
            cmbSearchType.Items.Add("ISBN");
            cmbSearchType.Items.Add("Title");
            cmbSearchType.Items.Add("Author");
            cmbSearchType.SelectedIndex = 0;
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
    }
}
