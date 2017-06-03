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
    public partial class frmSale : Form
    {
        // Setting relative path for database so that project can run from any folder.
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\csm.mdf;Integrated Security=True;Connect Timeout=60";
        SqlCommand SQLQuery = new SqlCommand();
        // Declaring variables to use in this class.
        string carID, currentTradeStatus;
        int totalCars, getEmployeeID;
        public frmSale()
        {
            InitializeComponent();
        }
        // Constructor overloading for getting parameters.
        public frmSale(string id, string tradeStatus, int getAvailableCars, int employeeUserID)
        {
            InitializeComponent();
            btnDone.Hide();
            carID = id;
            getEmployeeID = employeeUserID;
            currentTradeStatus = tradeStatus;
            totalCars = getAvailableCars;

            string sql = "SELECT * FROM tbCars WHERE (carID='" + carID + "')";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            dataReader.Read();
            txtCompany.Text = Convert.ToString(dataReader.GetValue(1));
            txtModel.Text = Convert.ToString(dataReader.GetValue(2));
            txtCarPrice.Text = Convert.ToString(dataReader.GetValue(5));
            txtDiscount.Text = Convert.ToString(dataReader.GetValue(7));
            txtSpecialOffer.Text = "0";
            txtCarOrdered.Text = "1";
            connection.Close();
        }
        // Preparing form for user to enter customer ID.
        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtCustomerID.ReadOnly = false;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            btnSelect.Hide();
            btnDone.Show();
        }
        // Validatating text box so it only allows numeric entry.
        private void txtCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Validatating text boxes so it only allows alphabets entry.
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        // Validatating text boxes so it only allows numeric entry.
        private void txtCarOrdered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSpecialOffer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Realtime calculation of special offer and car ordered.
        private void txtCarOrdered_TextChanged(object sender, EventArgs e)
        {
            int f = finalPrice();
            txtFinalPrice.Text = Convert.ToString(f);
        }
        // Calculating special offer.
        private void txtSpecialOffer_TextChanged(object sender, EventArgs e)
        {
            int f = finalPrice();
            txtFinalPrice.Text = Convert.ToString(f);
        }
        // Calculating final price subtracting discount and special offer.
        private int finalPrice()
        {
            int final = 0;
            if (txtDiscount.Text != string.Empty && txtSpecialOffer.Text != string.Empty && txtCarOrdered.Text != string.Empty)
            {
                int carPrice = Convert.ToInt32(txtCarPrice.Text);
                int order = Convert.ToInt32(txtCarOrdered.Text);
                int discount = Convert.ToInt32(txtDiscount.Text);
                int specialDiscount = Convert.ToInt32(txtSpecialOffer.Text);
                final = order * (carPrice - (carPrice * discount / 100) - (carPrice * specialDiscount / 100));
            }
            return final;
        }
        // Close the form on clicking cancel button.        
        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            this.Close();
            txtCustomerID.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtCompany.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtCarPrice.Text = string.Empty;
            txtCarOrdered.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtSpecialOffer.Text = string.Empty;
            txtFinalPrice.Text = string.Empty;
        }
        // Getting existing customer from database.
        private void btnDone_Click(object sender, EventArgs e)
        {
            string cId = txtCustomerID.Text;
            if (cId != string.Empty)
            {
                string sql = "SELECT customerId, firstName, lastName FROM tbCustomers WHERE (customerId='" + cId + "')";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                if (dataReader.HasRows == true)
                {
                    btnDone.Hide();
                    btnSelect.Show();
                    txtCustomerID.ReadOnly = true;
                    txtFirstName.ReadOnly = true;
                    txtLastName.ReadOnly = true;
                    txtCustomerID.Text = Convert.ToString(dataReader.GetValue(0));
                    txtFirstName.Text = Convert.ToString(dataReader.GetValue(1));
                    txtLastName.Text = Convert.ToString(dataReader.GetValue(2));
                    dataReader.Close();
                    command.Dispose();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("No such ID found!", "Car Sale", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            else
            {
                btnSelect.Show();
                btnDone.Hide();
                txtCustomerID.ReadOnly = true;
                txtFirstName.ReadOnly = false;
                txtLastName.ReadOnly = false;
                txtCustomerID.Text = string.Empty;
                txtFirstName.Text = string.Empty;
                txtLastName.Text = string.Empty;
            }
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            // Checking if fields are not empty.
            if (txtFirstName.Text == string.Empty || txtLastName.Text == string.Empty || txtCarOrdered.Text == string.Empty)
            {
                MessageBox.Show("Please enter First Name & Last Name !", "Sale Form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // If customer ID not selected than new customer will be added.
            else if(txtCustomerID.Text==string.Empty && txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtCarOrdered.Text != string.Empty)
            {
                DateTime accountCreated = DateTime.Today;
                SqlConnection connection = new SqlConnection(connectionString);
                SQLQuery.Connection = connection;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SQLQuery.Transaction = transaction;
                
                SQLQuery.CommandText = "INSERT INTO tbCustomers(firstName,lastName,carPurchased,accountCreated) OUTPUT INSERTED.customerId VALUES(@firstName,@lastName,@carPurchased,@accountCreated)";
                SQLQuery.Parameters.Clear();

                SQLQuery.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                SQLQuery.Parameters.AddWithValue("@lastName", txtLastName.Text);
                SQLQuery.Parameters.AddWithValue("@carPurchased", txtCarOrdered.Text);
                SQLQuery.Parameters.AddWithValue("@accountCreated", accountCreated);

                int getId = (int)SQLQuery.ExecuteScalar();
                DateTime purchaseDate = DateTime.Today;
                SQLQuery.CommandText = "INSERT INTO tbSales(customerId,brand,model,purchaseDate,price,carOrdered,discount,specialOffer,finalPrice,employeeID) VALUES(@customerId,@brand,@model,@purchaseDate,@price,@carOrdered,@discount,@specialOffer,@finalPrice,@employeeID)";
                SQLQuery.Parameters.Clear();

                SQLQuery.Parameters.AddWithValue("@customerId",getId);
                SQLQuery.Parameters.AddWithValue("@brand", txtCompany.Text);
                SQLQuery.Parameters.AddWithValue("@model", txtModel.Text);
                SQLQuery.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                SQLQuery.Parameters.AddWithValue("@price", txtCarPrice.Text);
                SQLQuery.Parameters.AddWithValue("@carOrdered", txtCarOrdered.Text);
                SQLQuery.Parameters.AddWithValue("@discount", txtDiscount.Text);
                SQLQuery.Parameters.AddWithValue("@specialOffer", txtSpecialOffer.Text);
                SQLQuery.Parameters.AddWithValue("@finalPrice", txtFinalPrice.Text);
                SQLQuery.Parameters.AddWithValue("@employeeID", getEmployeeID);
                SQLQuery.ExecuteNonQuery();
                
                transaction.Commit();
                connection.Close();
                MessageBox.Show("Car sold successfully!", "Car Sale", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            //If customer ID is selected existing customer is updated.
            else if(txtCustomerID.Text != string.Empty && txtFirstName.Text != string.Empty && txtLastName.Text != string.Empty && txtCarOrdered.Text != string.Empty)
            {
                // Getting available cars and adding new ordered car to carPurchased field of customers table.
                int custID = Convert.ToInt32(txtCustomerID.Text);
                string sql = "SELECT * FROM tbCustomers WHERE (customerID='" + custID + "')";
                SqlConnection connection = new SqlConnection(connectionString);
                SQLQuery.Connection = connection;
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                int oldCarPurchased = Convert.ToInt32(dataReader.GetValue(6));
                int newCarPurchased = Convert.ToInt32(txtCarOrdered.Text);
                int totalCarsPurchased = oldCarPurchased + newCarPurchased;
                dataReader.Close();
                SQLQuery.CommandText = "UPDATE tbCustomers SET carPurchased=@updateCarPurchased WHERE customerID=@customerId";
                SQLQuery.Parameters.Clear();

                SQLQuery.Parameters.AddWithValue("@updateCarPurchased", totalCarsPurchased);
                SQLQuery.Parameters.AddWithValue("@customerId", custID);
                SQLQuery.ExecuteNonQuery();

                // Insert data in Sale table.               
                DateTime purchaseDate = DateTime.Today;
                SQLQuery.CommandText = "INSERT INTO tbSales(customerId,brand,model,purchaseDate,price,carOrdered,discount,specialOffer,finalPrice,employeeID) VALUES(@customerId,@brand,@model,@purchaseDate,@price,@carOrdered,@discount,@specialOffer,@finalPrice,@employeeID)";
                SQLQuery.Parameters.Clear();

                SQLQuery.Parameters.AddWithValue("@customerId", txtCustomerID.Text);
                SQLQuery.Parameters.AddWithValue("@brand", txtCompany.Text);
                SQLQuery.Parameters.AddWithValue("@model", txtModel.Text);
                SQLQuery.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                SQLQuery.Parameters.AddWithValue("@price", txtCarPrice.Text);
                SQLQuery.Parameters.AddWithValue("@carOrdered", txtCarOrdered.Text);
                SQLQuery.Parameters.AddWithValue("@discount", txtDiscount.Text);
                SQLQuery.Parameters.AddWithValue("@specialOffer", txtSpecialOffer.Text);
                SQLQuery.Parameters.AddWithValue("@finalPrice", txtFinalPrice.Text);
                SQLQuery.Parameters.AddWithValue("@employeeID", getEmployeeID);
                SQLQuery.ExecuteNonQuery();

                //Deduct car from availableCars.
                int totalAvailableCars = totalCars - (Convert.ToInt32(txtCarOrdered.Text));
                SQLQuery.CommandText = "UPDATE tbCars SET availableCars=@availableCars WHERE carID='" + carID + "'";
                SQLQuery.Parameters.Clear();

                SQLQuery.Parameters.AddWithValue("@availableCars", totalAvailableCars);
                SQLQuery.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Car sold successfully!", "Car Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}