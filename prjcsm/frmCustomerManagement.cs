using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjcsm
{
    public partial class frmCustomerManagement : Form
    {
        // Setting relative path for database so that project can run from any folder.
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\csm.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand SQLQuery = new SqlCommand();
        // Declaring variables to use in this class.
        private bool flagNewCustomer = false;
        private bool flagEditCustomer = false;
        private string customerID;
        public frmCustomerManagement()
        {
            InitializeComponent();
        }
        public frmCustomerManagement(object _sender,string custID)
        {
            customerID = custID;
            InitializeComponent();
            // Declaring button object to get name of the button clicked.
            Button button = (Button) _sender;
            // Performing operations according to button clicked.
            if (button.Name == "btnNewCustomer")
            {
                btnModifyCustomer.Text = "Add New";
                clearControls();
                flagNewCustomer = true;
            }
            if (button.Name == "btnEditCustomer")
            {
                // Loading selected customer details into Customer Management form.
                btnModifyCustomer.Text = "Update";
                string sql = "SELECT * FROM tbCustomers WHERE (customerID='" + customerID + "')";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                txtCustomerFirstName.Text = Convert.ToString(dataReader.GetValue(1));
                txtCustomerLastName.Text = Convert.ToString(dataReader.GetValue(2));
                txtCustomerLicenceNo.Text = Convert.ToString(dataReader.GetValue(3));
                txtCustomerAddress.Text = Convert.ToString(dataReader.GetValue(4));
                txtCustomerContact.Text = Convert.ToString(dataReader.GetValue(5));
                txtCarPurchased.Text = Convert.ToString(dataReader.GetValue(6));

                connection.Close();
                flagEditCustomer = true;
            }
        }
        // Function for clearing all controls.
        private void clearControls()
        {
            txtCustomerFirstName.Text = string.Empty;
            txtCustomerLastName.Text = string.Empty;
            txtCustomerLicenceNo.Text = string.Empty;
            txtCustomerAddress.Text = string.Empty;
            txtCustomerContact.Text = string.Empty;
            txtCustomerFirstName.Focus();
        }
        // Validatating text boxes so it only allows alphabets entry.
        private void txtCustomerFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtCustomerLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        // Validatating text boxes so it only allows numeric entry.
        private void txtCustomerLicenceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtCustomerContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnModifyCustomer_Click(object sender, EventArgs e)
        {
            // If Add New button is clicked it will insert data.
            if (flagNewCustomer == true)
            {
                // Checking if fields are not empty.
                if (txtCustomerFirstName.Text == string.Empty || txtCustomerLastName.Text == string.Empty || txtCustomerLicenceNo.Text == string.Empty || txtCustomerAddress.Text == string.Empty || txtCustomerContact.Text == string.Empty)
                {
                    MessageBox.Show("Please enter all fields!", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string firstName = txtCustomerFirstName.Text;
                    string lastName = txtCustomerLastName.Text;
                    string licenseNumber = txtCustomerLicenceNo.Text;
                    string customerAddress = txtCustomerAddress.Text;
                    string contact = txtCustomerContact.Text;
                    int carPurchased = 0;
                    DateTime accountCreated = DateTime.Today;

                    SqlConnection connection = new SqlConnection(connectionString);
                    SQLQuery.Connection = connection;
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SQLQuery.Transaction = transaction;

                    SQLQuery.CommandText = "INSERT INTO tbCustomers(firstName,lastName,licenseNo,address,contact,carPurchased,accountCreated) VALUES(@firstName,@lastName,@licenseNo,@address,@contact,@carPurchased,@accountCreated)";
                    SQLQuery.Parameters.Clear();

                    SQLQuery.Parameters.AddWithValue("@firstName", firstName);
                    SQLQuery.Parameters.AddWithValue("@lastName", lastName);
                    SQLQuery.Parameters.AddWithValue("@licenseNo", licenseNumber);
                    SQLQuery.Parameters.AddWithValue("@address", customerAddress);
                    SQLQuery.Parameters.AddWithValue("@contact", contact);
                    SQLQuery.Parameters.AddWithValue("@carPurchased", carPurchased);
                    SQLQuery.Parameters.AddWithValue("@accountCreated", accountCreated);
                    SQLQuery.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("New customer added successfully!", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Clearing all controls for next insertion.
                    clearControls();
                }
            }
            // If Edit button is clicked it will update data.
            if (flagEditCustomer == true)
            {
                // Checking if fields are not empty.
                if (txtCustomerFirstName.Text == string.Empty || txtCustomerLastName.Text == string.Empty || txtCustomerLicenceNo.Text == string.Empty || txtCustomerAddress.Text == string.Empty || txtCustomerContact.Text == string.Empty)
                {
                    MessageBox.Show("Please enter all fields!", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string firstName = txtCustomerFirstName.Text;
                    string lastName = txtCustomerLastName.Text;
                    int licenseNo = Convert.ToInt32(txtCustomerLicenceNo.Text);
                    string address = txtCustomerAddress.Text;
                    int contact = Convert.ToInt32(txtCustomerContact.Text);
                    SqlConnection connection = new SqlConnection(connectionString);
                    SQLQuery.Connection = connection;
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SQLQuery.Transaction = transaction;

                    SQLQuery.CommandText = "UPDATE tbCustomers SET firstName=@firstName,lastName=@lastName,licenseNo=@licenseNo,address=@address,contact=@contact WHERE customerID=@customerID";
                    SQLQuery.Parameters.Clear();

                    SQLQuery.Parameters.AddWithValue("@firstName", firstName);
                    SQLQuery.Parameters.AddWithValue("@lastName", lastName);
                    SQLQuery.Parameters.AddWithValue("@licenseNo", licenseNo);
                    SQLQuery.Parameters.AddWithValue("@address", address);
                    SQLQuery.Parameters.AddWithValue("@contact", contact);
                    SQLQuery.Parameters.AddWithValue("@customerID", customerID);
                    SQLQuery.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Customer Updated successfully!", "Customer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Clearing all controls for next update.
                    clearControls();
                }
            }
        }
        // If Close button is clicked it will close the form.
        private void btnCancelCustomerBox_Click(object sender, EventArgs e)
        {
            this.Close();
            clearControls();
        }
    }
}