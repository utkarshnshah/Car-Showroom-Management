using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjcsm
{
    public partial class mdiHome : Form
    {
        // Declaring variables to use in this class.
        private string userName,userType;
        private int userId;

        // Parameters for User ID, User Name and User Type.
        public mdiHome(int userId,string uName,string uType)
        {
            InitializeComponent();
            this.userName = uName;
            this.userId = userId;
            this.userType = uType;
            lblWelcome.Text = "Welcome " + userName + " !";
            // Hiding controls for Salesman.
            if (uType == "Salesman")
            {
                miEmployees.Visible = false;
                gbGenerateReport.Visible = false;
            }
        }
        // Creating objects of all forms for showing new form on each click event.
        private void miCars_Click(object sender, EventArgs e)
        {
            frmManageCar newMDIChild = new frmManageCar(userId, userType);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void miCustomer_Click(object sender, EventArgs e)
        {
            frmManageCustomers newMDIChild = new frmManageCustomers(userType);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void miEmployee_Click(object sender, EventArgs e)
        {
            frmManageEmployees newMDIChild = new frmManageEmployees();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void btnFullSalesReports_Click(object sender, EventArgs e)
        {
            string selectedReport = "salesReport";
            frmReports newMDIChild = new frmReports(selectedReport);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void btnCustomerGrowthReport_Click(object sender, EventArgs e)
        {
            string selectedReport = "customerGrowthReport";
            frmReports newMDIChild = new frmReports(selectedReport);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void btnEmployeePerformance_Click(object sender, EventArgs e)
        {
            string selectedReport = "employeePerformanceReport";
            frmReports newMDIChild = new frmReports(selectedReport);
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
        // On click logout from the application.
        private void miLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            userId = 0;
            userName = string.Empty;
        }
    }
}