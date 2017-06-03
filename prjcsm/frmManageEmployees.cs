using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjcsm
{
    public partial class frmManageEmployees : Form
    {
        // Setting relative path for database so that project can run from any folder.
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\csm.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand SQLQuery = new SqlCommand();

        public frmManageEmployees()
        {
            InitializeComponent();
        }
        private void frmManageEmployees_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'csmDSEmployees.tbEmployees' table. You can move, or remove it, as needed.
            this.tbEmployeesTableAdapter.Fill(this.csmDSEmployees.tbEmployees);
        }
        // Creating objects of forms to pass value and open new form on each click event.
        private void btnHireEmployee_Click(object sender, EventArgs e)
        {
            string empID = Convert.ToString(dgvEmployees.CurrentRow.Cells[0].Value);
            frmEmployeeManagement frmEmployeeManagementForm = new frmEmployeeManagement(sender,empID);
            frmEmployeeManagementForm.Show();
            this.Close();
        }
        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            string empID = Convert.ToString(dgvEmployees.CurrentRow.Cells[0].Value);
            frmEmployeeManagement frmEmployeeManagementForm = new frmEmployeeManagement(sender,empID);
            frmEmployeeManagementForm.Show();
            this.Close();
        }
        // Deletes selected employee from database.
        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            string empID = Convert.ToString(dgvEmployees.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Are you sure you want to fire this employee?", "Customer Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SQLQuery.Connection = connection;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SQLQuery.Transaction = transaction;

                SQLQuery.CommandText = "DELETE FROM tbEmployees WHERE employeeID='" + empID + "'";
                SQLQuery.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Employee was fired !", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void btnCloseEmployees_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}