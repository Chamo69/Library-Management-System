using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library_System
{
    public partial class frmUserRegister: Form
    {
        public frmUserRegister()
        {
            InitializeComponent();
            this.Load += new EventHandler(frmUserRegister_Load);
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

        private void frmUserRegister_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                var repository = new UserRepository();
                DataTable usersTable = repository.GetAllUsers();
                dataGridView1.DataSource = usersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string sex = cmbSex.SelectedItem?.ToString();
                string nic = txtNIC.Text;
                string address = txtAddress.Text;
                string userType = cmbUserType.SelectedItem?.ToString();


                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(sex) ||
                    string.IsNullOrWhiteSpace(nic) || string.IsNullOrWhiteSpace(address) ||
                    string.IsNullOrWhiteSpace(userType))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                    txtName.Focus();
                }

                var repository = new UserRepository();
                repository.AddUser(name, sex, nic, address, userType);

                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                txtName.Clear();
                txtNIC.Clear();
                txtAddress.Clear();
                cmbSex.SelectedIndex = -1;
                cmbUserType.SelectedIndex = -1;
                txtName.Focus();

                LoadUserData();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
