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
    public partial class frmReports : Form
    {
        // Dynamically loading data source for report viewer at runtime.
        Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new Microsoft.Reporting.WinForms.ReportDataSource();
        private string selectedReport;
        public frmReports()
        {
            InitializeComponent();
        }
        // Constuctor overloading for getting parameter.
        public frmReports(string getSelectedReport)
        {
            InitializeComponent();
            selectedReport = getSelectedReport;            
        }
        // Displaying daily report.
        private void btnTodaysSales_Click(object sender, EventArgs e)
        {
            string getStartDate = Convert.ToString(DateTime.Today);
            if (selectedReport == "salesReport")
            {
                reportDataSource.Name = "csmDSSalesReport";
                reportDataSource.Value = this.tbSalesBindingSource;
                rvAllReports.LocalReport.DataSources.Add(reportDataSource);
                rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptSalesReport.rdlc";
                // This line of code loads data into the 'csmDSSalesReport.tbSales' table. You can move, or remove it, as needed.
                this.tbSalesTableAdapter.Fill(this.csmDSSalesReport.tbSales, getStartDate, getStartDate);
                this.rvAllReports.RefreshReport();
            }
            if (selectedReport == "customerGrowthReport")
            {
                reportDataSource.Name = "csmDSCustomerGrowthReport";
                reportDataSource.Value = this.tbSalesBindingSource;
                rvAllReports.LocalReport.DataSources.Add(reportDataSource);
                rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptCustomerGrowthReport.rdlc";
                this.tbCustomersTableAdapter.Fill(this.csmDSCustomerGrowthReport.tbCustomers, getStartDate, getStartDate);
                this.rvAllReports.RefreshReport();
            }
            if (selectedReport == "employeePerformanceReport")
            {
                reportDataSource.Name = "csmDSEmployeePerformanceReport";
                reportDataSource.Value = this.tbSalesBindingSource;
                rvAllReports.LocalReport.DataSources.Add(reportDataSource);
                rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptEmployeePerformanceReport.rdlc";
                this.tbSalesTableAdapter.Fill(this.csmDSSalesReport.tbSales, getStartDate, getStartDate);
                this.rvAllReports.RefreshReport();
            }
        }
        // Displaying monthly report.
        private void btnMonthlySales_Click(object sender, EventArgs e)
        {
            DateTime getDate = DateTime.Now.AddDays(-30);
            string getStartDate = Convert.ToString(getDate);
            string getEndDate = Convert.ToString(DateTime.Today);
            if (selectedReport == "salesReport")
            {
                reportDataSource.Name = "csmDSSalesReport";
                reportDataSource.Value = this.tbSalesBindingSource;
                rvAllReports.LocalReport.DataSources.Add(reportDataSource);
                rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptSalesReport.rdlc";
                // This line of code loads data into the 'csmDSSalesReport.tbSales' table. You can move, or remove it, as needed.
                this.tbSalesTableAdapter.Fill(this.csmDSSalesReport.tbSales, getStartDate, getEndDate);
                this.rvAllReports.RefreshReport();
            }
            if (selectedReport == "customerGrowthReport")
            {
                reportDataSource.Name = "csmDSCustomerGrowthReport";
                reportDataSource.Value = this.tbSalesBindingSource;
                rvAllReports.LocalReport.DataSources.Add(reportDataSource);
                rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptCustomerGrowthReport.rdlc";
                this.tbCustomersTableAdapter.Fill(this.csmDSCustomerGrowthReport.tbCustomers, getStartDate, getEndDate);
                this.rvAllReports.RefreshReport();
            }
            if (selectedReport == "employeePerformanceReport")
            {
                reportDataSource.Name = "csmDSEmployeePerformanceReport";
                reportDataSource.Value = this.tbSalesBindingSource;
                rvAllReports.LocalReport.DataSources.Add(reportDataSource);
                rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptEmployeePerformanceReport.rdlc";
                this.tbSalesTableAdapter.Fill(this.csmDSSalesReport.tbSales, getStartDate, getEndDate);
                this.rvAllReports.RefreshReport();
            }
        }
        // Displaying Yearly report.
        private void btnYearlySales_Click(object sender, EventArgs e)
        {
            DateTime getDate = DateTime.Now.AddDays(-365);
            string getStartDate = Convert.ToString(getDate);
            string getEndDate = Convert.ToString(DateTime.Today);
            if (selectedReport == "salesReport")
            {
                reportDataSource.Name = "csmDSSalesReport";
                reportDataSource.Value = this.tbSalesBindingSource;
                rvAllReports.LocalReport.DataSources.Add(reportDataSource);
                rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptSalesReport.rdlc";
                // This line of code loads data into the 'csmDSSalesReport.tbSales' table. You can move, or remove it, as needed.
                this.tbSalesTableAdapter.Fill(this.csmDSSalesReport.tbSales, getStartDate, getEndDate);
                this.rvAllReports.RefreshReport();
            }
            if (selectedReport == "customerGrowthReport")
            {
                reportDataSource.Name = "csmDSCustomerGrowthReport";
                reportDataSource.Value = this.tbSalesBindingSource;
                rvAllReports.LocalReport.DataSources.Add(reportDataSource);
                rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptCustomerGrowthReport.rdlc";
                this.tbCustomersTableAdapter.Fill(this.csmDSCustomerGrowthReport.tbCustomers, getStartDate, getEndDate);
                this.rvAllReports.RefreshReport();
            }
            if (selectedReport == "employeePerformanceReport")
            {
                // This line of code loads data into the 'csmDSSalesReport.tbSales' table. You can move, or remove it, as needed                
                reportDataSource.Name = "csmDSEmployeePerformanceReport";
                reportDataSource.Value = this.tbSalesBindingSource;
                rvAllReports.LocalReport.DataSources.Add(reportDataSource);
                rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptEmployeePerformanceReport.rdlc";
                this.tbSalesTableAdapter.Fill(this.csmDSSalesReport.tbSales, getStartDate, getEndDate);
                this.rvAllReports.RefreshReport();
            }
        }
        private void btnCloseReport_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}