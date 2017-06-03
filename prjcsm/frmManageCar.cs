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
    public partial class frmManageCar : Form
    {
        // Declaring variables for using in this class.
        public static int checkAvailability;
        public string currentUserType;
        public int employeeUserID;
        // Parameters for getting User Id and User Type.
        public frmManageCar(int userID, string getUserType)
        {
            InitializeComponent();
            currentUserType = getUserType;
            employeeUserID = userID;
            // Hiding buttons for Salesman.
            if (currentUserType == "Salesman")
            {
                btnNewCar.Visible = false;
                btnUpdateCar.Visible = false;
                btnStartTrading.Visible = false;
                btnStopTrading.Visible = false;
            }
        }

        private void frmManageCar_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'csmDSCars.tbCars' table. You can move, or remove it, as needed.
            this.tbCarsTableAdapter.Fill(this.csmDSCars.tbCars);
        }

        private void btnCloseCars_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Creating objects of forms to pass value and open new form on each click event.
        private void btnNewCar_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dgvCars.CurrentRow.Cells[0].Value);
            string tradeStatus = Convert.ToString(dgvCars.CurrentRow.Cells[8].Value);
            frmCarManagement frmCarManagementForm = new frmCarManagement(sender, id, tradeStatus);
            frmCarManagementForm.Show();
            this.Close();
        }
        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dgvCars.CurrentRow.Cells[0].Value);
            string tradeStatus = Convert.ToString(dgvCars.CurrentRow.Cells[8].Value);
            frmCarManagement frmCarManagementForm = new frmCarManagement(sender, id, tradeStatus);
            frmCarManagementForm.Show();
            this.Close();
        }
        private void btnStartTrading_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dgvCars.CurrentRow.Cells[0].Value);
            string tradeStatus= Convert.ToString(dgvCars.CurrentRow.Cells[8].Value);
            // Checking car trading status.
            if (tradeStatus == "Yes")
            {
                MessageBox.Show("Car is already trading!", "Car Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmCarManagement frmCarManagementForm = new frmCarManagement(sender, id, tradeStatus);
                this.Close();
            }
        }

        private void btnStopTrading_Click(object sender, EventArgs e)
        {
            string id = Convert.ToString(dgvCars.CurrentRow.Cells[0].Value);
            string tradeStatus = Convert.ToString(dgvCars.CurrentRow.Cells[8].Value);
            // Checking car trading status.
            if (tradeStatus == "No")
            {
                MessageBox.Show("Car is trading is already stopped!", "Car Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmCarManagement frmCarManagementForm = new frmCarManagement(sender, id, tradeStatus);
                this.Close();
            }
        }
        private void btnSellCar_Click(object sender, EventArgs e)
        {
            string checkAvailable = Convert.ToString(dgvCars.CurrentRow.Cells[6].Value);
            int checkAvailibility = Convert.ToInt32(checkAvailable);
            // Checking car stock.
            if (checkAvailibility > 0)
            {
                string id = Convert.ToString(dgvCars.CurrentRow.Cells[0].Value);
                string tradeStatus = Convert.ToString(dgvCars.CurrentRow.Cells[8].Value);
                frmSale frmSaleForm = new frmSale(id, tradeStatus,checkAvailibility,employeeUserID);
                frmSaleForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry ! Stock Over for this car!","Car Sale",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
        }
    }
}