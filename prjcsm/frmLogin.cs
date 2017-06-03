using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjcsm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            cmbUserType.SelectedIndex=0;
        }
        // Function to clear all controls of the form.
        private void clearControls()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            cmbUserType.Text = string.Empty;
        }
        // Validating textbox so it only allows alphabets.
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Coding for validation User Name and Password with User Type.
            if (txtUserName.Text==string.Empty || txtPassword.Text == string.Empty || cmbUserType.SelectedIndex==0)
            {
                MessageBox.Show("Please enter valid User Name, Password and User Type!","Login Failed!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                clearControls();
                txtUserName.Focus();
            }
            else
            {
                // Code for SQL Connection
                string uName = txtUserName.Text;
                string pass = txtPassword.Text;
                string uType = cmbUserType.Text;
                // Setting relative path for database so that project can run from any folder.
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\csm.mdf;Integrated Security=True;Connect Timeout=30";
                // Query for getting User Name and Password.
                string sql = "SELECT * FROM tbEmployees WHERE (userName='"+uName+"') AND (passWord='"+pass+"') AND (userType='"+uType+"')";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                // If Employee is found in the database than execute else display message.
                if (dataReader.HasRows == true) {
                    while (dataReader.Read())
                    {
                        try
                        {
                            // If UserName & Password are correct than display Home Page else show error.
                            if (Convert.ToString(dataReader.GetValue(1)) == uName && Convert.ToString(dataReader.GetValue(2)) == pass && Convert.ToString(dataReader.GetValue(5)) == uType)
                            {
                                int userId = Convert.ToInt32(dataReader.GetValue(0));
                                mdiHome newHome = new mdiHome(userId, uName, uType);
                                newHome.Show();
                                clearControls();
                            }
                            else
                            {
                                MessageBox.Show("Please enter valid User Name, Password and User Type!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                clearControls();
                                txtUserName.Focus();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error connecting database.");
                        }
                    }
                    dataReader.Close();
                    command.Dispose();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("No such Employee found! "+Environment.NewLine+"Please check User Name, Password and User Type.", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}