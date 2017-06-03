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
    public partial class frmManageCustomers : Form
    {
        // Setting relative path for database so that project can run from any folder.
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\csm.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand SQLQuery = new SqlCommand();
        // Declaring variables for using in this class.
        public string currentUserType;
        public frmManageCustomers()
        {
            InitializeComponent();
        }
        public frmManageCustomers(string getUserType)
        {
            InitializeComponent();
            currentUserType = getUserType;
            if (currentUserType == "Salesman")
            {
                btnNewCustomer.Visible = false;
                btnEditCustomer.Visible = false;
                btnDeleteCustomer.Visible = false;
            }
        }

        private void btnCloseCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmManageCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'csmDSCustomers.tbCustomers' table. You can move, or remove it, as needed.
            this.tbCustomersTableAdapter.Fill(this.csmDSCustomers.tbCustomers);
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            string custID = Convert.ToString(dgvCustomers.CurrentRow.Cells[0].Value);
            frmCustomerManagement frmCustomerManagementForm = new frmCustomerManagement(sender,custID);
            frmCustomerManagementForm.Show();
            this.Close();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            string custID = Convert.ToString(dgvCustomers.CurrentRow.Cells[0].Value);
            frmCustomerManagement frmCustomerManagementForm = new frmCustomerManagement(sender,custID);
            frmCustomerManagementForm.Show();
            this.Close();
        }
        // Deleting selected customer from the system.
        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string custID = Convert.ToString(dgvCustomers.CurrentRow.Cells[0].Value);
            if(MessageBox.Show("Are you sure you want to delete this customer?","Customer Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SQLQuery.Connection = connection;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SQLQuery.Transaction = transaction;

                SQLQuery.CommandText = "DELETE FROM tbCustomers WHERE customerID='"+custID+"'";
                SQLQuery.ExecuteNonQuery();

                SQLQuery.CommandText = "DELETE FROM tbSales WHERE customerId='" + custID + "'";
                SQLQuery.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Customer deleted successfully!", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}