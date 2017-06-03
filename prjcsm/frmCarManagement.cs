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
    public partial class frmCarManagement : Form
    {
        // Setting relative path for database so that project can run from any folder.
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\csm.mdf;Integrated Security=True;Connect Timeout=30";
        SqlCommand SQLQuery = new SqlCommand();
        // Declaring variables to use in this class.
        private bool newFlag=false;
        private bool updateFlag = false;
        private string carID;
        private string currentTradeStatus;
        public frmCarManagement()
        {
            InitializeComponent();
        }
        // Constructor overriding for getting parameters.
        public frmCarManagement(object _sender, string id,string tradeStatus)
        {
            InitializeComponent();
            carID = id;
            currentTradeStatus = tradeStatus;
            // Declaring button object to get name of the button clicked.
            Button button = (Button) _sender;
            if (button.Name == "btnNewCar")
            {
                btnModifyCars.Text = "Add New";
                clearControls();
                newFlag = true;
            }
            if(button.Name=="btnUpdateCar"){
                // Loading selected car details into Car Management form.
                btnModifyCars.Text = "Update";
                string sql = "SELECT * FROM tbCars WHERE (carID='" + carID + "')";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();

                txtCarCompany.Text = Convert.ToString(dataReader.GetValue(1));
                txtCarModel.Text = Convert.ToString(dataReader.GetValue(2));
                dtpLaunchDate.Text = Convert.ToString(dataReader.GetValue(3));
                txtCarSpecification.Text = Convert.ToString(dataReader.GetValue(4));
                txtPrice.Text = Convert.ToString(dataReader.GetValue(5));
                txtAvailableCars.Text = Convert.ToString(dataReader.GetValue(6));
                txtSetDiscount.Text = Convert.ToString(dataReader.GetValue(7));

                connection.Close();
                updateFlag = true;
            }
            // If car trading status is "No" then setting it to "Yes".
            if (button.Name == "btnStartTrading")
            {
                string newTradingStatus = "Yes";
                SqlConnection connection = new SqlConnection(connectionString);
                SQLQuery.Connection = connection;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SQLQuery.Transaction = transaction;

                SQLQuery.CommandText = "UPDATE tbCars SET tradeStatus=@newTradingStatus WHERE carID=@carID";
                SQLQuery.Parameters.Clear();

                SQLQuery.Parameters.AddWithValue("@newTradingStatus", newTradingStatus);
                SQLQuery.Parameters.AddWithValue("@carID", carID);
                SQLQuery.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Car trading is on!", "Car Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // If car trading status is "Yes" then setting it to "No".
            if (button.Name == "btnStopTrading")
            {
                string newTradingStatus = "No";
                SqlConnection connection = new SqlConnection(connectionString);
                SQLQuery.Connection = connection;
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SQLQuery.Transaction = transaction;

                SQLQuery.CommandText = "UPDATE tbCars SET tradeStatus=@newStatus WHERE carID=@carID";
                SQLQuery.Parameters.Clear();

                SQLQuery.Parameters.AddWithValue("@newStatus", newTradingStatus);
                SQLQuery.Parameters.AddWithValue("@carID", carID);
                SQLQuery.ExecuteNonQuery();

                transaction.Commit();
                MessageBox.Show("Car is now not trading!", "Car Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Function for clearing all controls.
        private void clearControls()
        {
            txtCarCompany.Text = string.Empty;
            txtCarModel.Text = string.Empty;
            dtpLaunchDate.Text = string.Empty;
            txtCarSpecification.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtAvailableCars.Text = string.Empty;
            txtSetDiscount.Text = string.Empty;
        }
        // Validatating text boxes so it only allows numeric entry.
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtAvailableCars_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtSetDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Closing the form and clearing all controls.
        private void btnCancelCarBox_Click(object sender, EventArgs e)
        {
            this.Close();
            newFlag = false;
            updateFlag = false;
            clearControls();
        }
        private void btnModifyCars_Click(object sender, EventArgs e)
        {
            // If Add New button is clicked it will insert data.
            if (newFlag == true)
            {
                if (txtCarCompany.Text == string.Empty || txtCarModel.Text == string.Empty || dtpLaunchDate.Text == string.Empty || txtCarSpecification.Text == string.Empty)
                {
                    MessageBox.Show("Please enter all fields!", "Car Management", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string company = txtCarCompany.Text;
                    string model = txtCarModel.Text;
                    DateTime launchDate = Convert.ToDateTime(dtpLaunchDate.Text);
                    string specifications = txtCarSpecification.Text;
                    string price = txtPrice.Text;
                    string availableCars = txtAvailableCars.Text;
                    //Setting default value of setDiscount to 0 if TryParse does not work.
                    int setDiscount = 0;
                    int.TryParse(txtSetDiscount.Text, out setDiscount);

                    SqlConnection connection = new SqlConnection(connectionString);
                    SQLQuery.Connection = connection;
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SQLQuery.Transaction = transaction;

                    SQLQuery.CommandText = "INSERT INTO tbCars(carCompany,model,launchDate,specifications,price,availableCars,setDiscount) values(@company,@model,@launchDate,@specifications,@price,@availableCars,@setDiscount)";
                    SQLQuery.Parameters.Clear();

                    SQLQuery.Parameters.AddWithValue("@company", company);
                    SQLQuery.Parameters.AddWithValue("@model", model);
                    SQLQuery.Parameters.AddWithValue("@launchDate", launchDate);
                    SQLQuery.Parameters.AddWithValue("@specifications", specifications);
                    SQLQuery.Parameters.AddWithValue("@price", price);
                    SQLQuery.Parameters.AddWithValue("@availableCars", availableCars);
                    SQLQuery.Parameters.AddWithValue("@setDiscount", setDiscount);
                    SQLQuery.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("New Car added successfully!", "Car Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Clearing all controls for next insertion.
                    clearControls();
                }
            }
            // If Update button is clicked it will update data.
            if (updateFlag == true)
            {
                // Checking if fields are not empty.
                if (txtCarCompany.Text==string.Empty || txtCarModel.Text==string.Empty || dtpLaunchDate.Text==string.Empty || txtCarSpecification.Text==string.Empty || txtAvailableCars.Text==string.Empty || txtPrice.Text==string.Empty)
                {
                    MessageBox.Show("Please enter all values!", "Car Management", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    string company = txtCarCompany.Text;
                    string model = txtCarModel.Text;
                    DateTime launchDate = Convert.ToDateTime(dtpLaunchDate.Text);
                    string specifications = txtCarSpecification.Text;
                    string price = txtPrice.Text;
                    string availableCars = txtAvailableCars.Text;
                    //Set default value of setDiscount to 0 if TryParse does not work.
                    int setDiscount = 0;
                    int.TryParse(txtSetDiscount.Text, out setDiscount);
                    SqlConnection connection = new SqlConnection(connectionString);
                    SQLQuery.Connection = connection;
                    connection.Open();
                    SqlTransaction transaction = connection.BeginTransaction();
                    SQLQuery.Transaction = transaction;

                    SQLQuery.CommandText = "UPDATE tbCars SET carCompany=@company,model=@model,launchDate=@launchDate,specifications=@specifications,price=@price,availableCars=@availableCars,setDiscount=@setDiscount WHERE carID=@carID";
                    SQLQuery.Parameters.Clear();

                    SQLQuery.Parameters.AddWithValue("@company", company);
                    SQLQuery.Parameters.AddWithValue("@model", model);
                    SQLQuery.Parameters.AddWithValue("@launchDate", launchDate);
                    SQLQuery.Parameters.AddWithValue("@specifications", specifications);
                    SQLQuery.Parameters.AddWithValue("@price", price);
                    SQLQuery.Parameters.AddWithValue("@availableCars", availableCars);
                    SQLQuery.Parameters.AddWithValue("@setDiscount", setDiscount);
                    SQLQuery.Parameters.AddWithValue("@carID", carID );
                    SQLQuery.ExecuteNonQuery();
                    
                    transaction.Commit();
                    MessageBox.Show("Car Updated successfully!", "Car Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // Clearing all controls for next update.
                    clearControls();
                }
            }
        }
    }
}