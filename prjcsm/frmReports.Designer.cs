namespace prjcsm
{
    partial class frmReports
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csmDSCustomerGrowthReport = new prjcsm.csmDSCustomerGrowthReport();
            this.tbSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csmDSSalesReport = new prjcsm.csmDSSalesReport();
            this.rvAllReports = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnTodaysSales = new System.Windows.Forms.Button();
            this.btnMonthlySales = new System.Windows.Forms.Button();
            this.btnYearlySales = new System.Windows.Forms.Button();
            this.btnCloseReport = new System.Windows.Forms.Button();
            this.tbSalesTableAdapter = new prjcsm.csmDSSalesReportTableAdapters.tbSalesTableAdapter();
            this.tbCustomersTableAdapter = new prjcsm.csmDSCustomerGrowthReportTableAdapters.tbCustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSCustomerGrowthReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCustomersBindingSource
            // 
            this.tbCustomersBindingSource.DataMember = "tbCustomers";
            this.tbCustomersBindingSource.DataSource = this.csmDSCustomerGrowthReport;
            // 
            // csmDSCustomerGrowthReport
            // 
            this.csmDSCustomerGrowthReport.DataSetName = "csmDSCustomerGrowthReport";
            this.csmDSCustomerGrowthReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbSalesBindingSource
            // 
            this.tbSalesBindingSource.DataMember = "tbSales";
            this.tbSalesBindingSource.DataSource = this.csmDSSalesReport;
            // 
            // csmDSSalesReport
            // 
            this.csmDSSalesReport.DataSetName = "csmDSSalesReport";
            this.csmDSSalesReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvAllReports
            // 
            this.rvAllReports.AutoSize = true;
            this.rvAllReports.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "csmDSCustomerGrowthReport";
            reportDataSource1.Value = this.tbCustomersBindingSource;
            this.rvAllReports.LocalReport.DataSources.Add(reportDataSource1);
            this.rvAllReports.LocalReport.ReportEmbeddedResource = "prjcsm.rptCustomerGrowthReport.rdlc";
            this.rvAllReports.Location = new System.Drawing.Point(0, 0);
            this.rvAllReports.Name = "rvAllReports";
            this.rvAllReports.Size = new System.Drawing.Size(1184, 436);
            this.rvAllReports.TabIndex = 0;
            this.rvAllReports.WaitControlDisplayAfter = 0;
            // 
            // btnTodaysSales
            // 
            this.btnTodaysSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTodaysSales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodaysSales.ForeColor = System.Drawing.Color.White;
            this.btnTodaysSales.Location = new System.Drawing.Point(11, 37);
            this.btnTodaysSales.Name = "btnTodaysSales";
            this.btnTodaysSales.Size = new System.Drawing.Size(80, 27);
            this.btnTodaysSales.TabIndex = 1;
            this.btnTodaysSales.Text = "Todays";
            this.btnTodaysSales.UseVisualStyleBackColor = false;
            this.btnTodaysSales.Click += new System.EventHandler(this.btnTodaysSales_Click);
            // 
            // btnMonthlySales
            // 
            this.btnMonthlySales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMonthlySales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlySales.ForeColor = System.Drawing.Color.White;
            this.btnMonthlySales.Location = new System.Drawing.Point(97, 37);
            this.btnMonthlySales.Name = "btnMonthlySales";
            this.btnMonthlySales.Size = new System.Drawing.Size(80, 27);
            this.btnMonthlySales.TabIndex = 2;
            this.btnMonthlySales.Text = "Monthly";
            this.btnMonthlySales.UseVisualStyleBackColor = false;
            this.btnMonthlySales.Click += new System.EventHandler(this.btnMonthlySales_Click);
            // 
            // btnYearlySales
            // 
            this.btnYearlySales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnYearlySales.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearlySales.ForeColor = System.Drawing.Color.White;
            this.btnYearlySales.Location = new System.Drawing.Point(183, 37);
            this.btnYearlySales.Name = "btnYearlySales";
            this.btnYearlySales.Size = new System.Drawing.Size(80, 27);
            this.btnYearlySales.TabIndex = 3;
            this.btnYearlySales.Text = "Yearly";
            this.btnYearlySales.UseVisualStyleBackColor = false;
            this.btnYearlySales.Click += new System.EventHandler(this.btnYearlySales_Click);
            // 
            // btnCloseReport
            // 
            this.btnCloseReport.BackColor = System.Drawing.Color.Maroon;
            this.btnCloseReport.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseReport.ForeColor = System.Drawing.Color.White;
            this.btnCloseReport.Location = new System.Drawing.Point(1056, 37);
            this.btnCloseReport.Name = "btnCloseReport";
            this.btnCloseReport.Size = new System.Drawing.Size(80, 27);
            this.btnCloseReport.TabIndex = 4;
            this.btnCloseReport.Text = "Close";
            this.btnCloseReport.UseVisualStyleBackColor = false;
            this.btnCloseReport.Click += new System.EventHandler(this.btnCloseReport_Click);
            // 
            // tbSalesTableAdapter
            // 
            this.tbSalesTableAdapter.ClearBeforeFill = true;
            // 
            // tbCustomersTableAdapter
            // 
            this.tbCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 436);
            this.ControlBox = false;
            this.Controls.Add(this.btnCloseReport);
            this.Controls.Add(this.btnYearlySales);
            this.Controls.Add(this.btnMonthlySales);
            this.Controls.Add(this.btnTodaysSales);
            this.Controls.Add(this.rvAllReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmReports";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSCustomerGrowthReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rvAllReports;
        private System.Windows.Forms.Button btnTodaysSales;
        private System.Windows.Forms.Button btnMonthlySales;
        private System.Windows.Forms.Button btnYearlySales;
        private System.Windows.Forms.Button btnCloseReport;
        private System.Windows.Forms.BindingSource tbSalesBindingSource;
        private csmDSSalesReport csmDSSalesReport;
        private csmDSSalesReportTableAdapters.tbSalesTableAdapter tbSalesTableAdapter;
        private System.Windows.Forms.BindingSource tbCustomersBindingSource;
        private csmDSCustomerGrowthReport csmDSCustomerGrowthReport;
        private csmDSCustomerGrowthReportTableAdapters.tbCustomersTableAdapter tbCustomersTableAdapter;
    }
}