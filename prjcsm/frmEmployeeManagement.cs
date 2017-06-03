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
    public partial class frmEmployeeManagement : Form
    {
        // Setting relative path for database so that project can run from any folder.
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\csm.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand SQLQuery = new SqlCommand();
        // Declaring variables to use in this class.
        private string employeeID;
        private bool flagHireEmployee=false;
        private bool flagEditEmployee = false;
        public frmEmployeeManagement()
        {
            InitializeComponent();
        }
        // Constructor overriding for getting parameters.
        public frmEmployeeManagement(object _sender, string eID)
        {
            InitializeComponent();
            cmbEmployeeType.SelectedIndex = 0;
            employeeID = eID;
            // Declaring button object to get name of the button clicked.
            Button button = (Button)_sender;
            // Performing operations according to button clicked.
            if (button.Name == "btnHireEmployee")
            {
                btnModifyEmployee.Text = "Hire";
                clearControls();
                flagHireEmployee = true;
            }
            if (button.Name == "btnEditEmployee")
            {
                // Loading selected Employee details into Employee Management form.
                btnModifyEmployee.Text = "Update";
                string sql = "SELECT * FROM tbEmployees WHERE (employeeID='" + employeeID + "')";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                txtEmployeeUsername.Text = Convert.ToString(dataReader.GetValue(1));
                txtEmployeePassword.Text = Convert.ToString(dataReader.GetValue(2));
                txtEmployeeFirstName.Text = Convert.ToString(dataReader.GetValue(3));
                txtEmployeeLastName.Text = Convert.ToString(dataReader.GetValue(4));
                cmbEmployeeType.Text = Convert.ToString(dataReader.GetValue(5));
                txtEmployeeAddress.Text = Convert.ToString(dataReader.GetValue(6));
                txtEmployeeContact.Text = Convert.ToString(dataReader.GetValue(7));

                connection.Close();
                flagEditEmployee = true;
            }
        }
        // Function for clearing all controls.
        private void clearControls()
        {
            txtEmployeeUsername.Text = string.Empty;
            txtEmployeePassword.Text = string.Empty;
            txtEmployeeFirstName.Text = string.Empty;
            txtEmployeeLastName.Text = string.Empty;
            cmbEmployeeType.SelectedIndex = 0;
            txtEmployeeAddress.Text = string.Empty;
            txtEmployeeContact.Text = string.Empty;
        }
        // Validatating text boxes so it only allows alphabets entry.
        private void txtEmployeeUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtEmployeeFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtEmployeeLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        // Validatating text box so it only allows numeric entry.
        private void txtEmployeeContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnModifyEmployee_Click(object sender, EventArgs e)
        {
            // If Hire button is clicked it will insert data.
            if (flagHireEmployee == true)
            {
                // Checking if fields are not empty.
                if (txtEmployeeUsername.Text == string.Empty || txtEmployeePassword.Text == string.Empty || txtEmployeeFirstName.Text == string.Empty || txtEmployeeLastName.Text == string.Empty || cmbEmployeeType.SelectedIndex == 0 || txtEmployeeAddress.Text==string.Empty || txtEmployeeContact.Text==string.Empty)
                {
                    MessageBox.Show("Please enter all fields!", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string userName = txtEmployeeUsername.Text;
                    string password = txtEmployeePassword.Text;
                    string empFirstName = txtEmployeeFirstName.Text;
                    string empLastName = txtEmployeeLastName.Text;
                    string empType = cmbEmployeeType.Text;
                    string empAddress = txtEmployeeAddress.Text;
                    string empContact = txtEmployeeContact.Text;

                    SqlConnection connection = new SqlConnection(connectionString);
                    SQLQuery.Connection = connection;
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SQLQuery.Transaction = transaction;

                    SQLQuery.CommandText = "INSERT INTO tbEmployees(userName,passWord,employeeFirstName,employeeLastName,userType,address,contact) VALUES(@userName,@passWord,@employeeFirstName,@employeeLastName,@userType,@address,@contact)";
                    SQLQuery.Parameters.Clear();

                    SQLQuery.Parameters.AddWithValue("@userName", userName);
                    SQLQuery.Parameters.AddWithValue("@passWord", password);
                    SQLQuery.Parameters.AddWithValue("@employeeFirstName", empFirstName);
                    SQLQuery.Parameters.AddWithValue("@employeeLastName", empLastName);
                    SQLQuery.Parameters.AddWithValue("@userType", empType);
                    SQLQuery.Parameters.AddWithValue("@address", empAddress);
                    SQLQuery.Parameters.AddWithValue("@contact", empContact);
                    SQLQuery.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Employee was Hired !", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Clearing all controls for next insertion.
                    clearControls();
                }
            }
            // If Edit button is clicked it will Update data.
            if (flagEditEmployee == true)
            {
                // Checking if fields are not empty.
                if (txtEmployeeUsername.Text == string.Empty || txtEmployeePassword.Text == string.Empty || txtEmployeeFirstName.Text == string.Empty || txtEmployeeLastName.Text == string.Empty || cmbEmployeeType.SelectedIndex == 0 || txtEmployeeAddress.Text == string.Empty || txtEmployeeContact.Text == string.Empty)
                {
                    MessageBox.Show("Please enter all fields!", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string userName = txtEmployeeUsername.Text;
                    string password = txtEmployeePassword.Text;
                    string empFirstName = txtEmployeeFirstName.Text;
                    string empLastName = txtEmployeeLastName.Text;
                    string empType = cmbEmployeeType.Text;
                    string empAddress = txtEmployeeAddress.Text;
                    string empContact = txtEmployeeContact.Text;

                    SqlConnection connection = new SqlConnection(connectionString);
                    SQLQuery.Connection = connection;
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SQLQuery.Transaction = transaction;

                    SQLQuery.CommandText = "UPDATE tbEmployees SET userName=@userName,passWord=@password,employeeFirstName=@employeeFirstName,employeeLastName=@employeeLastName,userType=@userType,address=@address,contact=@contact WHERE employeeID=@employeeID";
                    SQLQuery.Parameters.Clear();

                    SQLQuery.Parameters.AddWithValue("@userName", userName);
                    SQLQuery.Parameters.AddWithValue("@password", password);
                    SQLQuery.Parameters.AddWithValue("@employeeFirstName", empFirstName);
                    SQLQuery.Parameters.AddWithValue("@employeeLastName", empLastName);
                    SQLQuery.Parameters.AddWithValue("@userType", empType);
                    SQLQuery.Parameters.AddWithValue("@address", empAddress);
                    SQLQuery.Parameters.AddWithValue("@contact", empContact);
                    SQLQuery.Parameters.AddWithValue("@employeeID", employeeID);
                    SQLQuery.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Employee updated successfully!", "Employee Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Clearing all controls for next update.
                    clearControls();
                }
            }
        }
        private void btnCancelEmployeeBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}