namespace prjcsm
{
    partial class mdiHome
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.msMainMenu = new System.Windows.Forms.MenuStrip();
            this.miCars = new System.Windows.Forms.ToolStripMenuItem();
            this.miCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.miEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.miLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.gbGenerateReport = new System.Windows.Forms.GroupBox();
            this.btnEmployeePerformance = new System.Windows.Forms.Button();
            this.btnCustomerGrowthReport = new System.Windows.Forms.Button();
            this.btnFullSalesReports = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.msMainMenu.SuspendLayout();
            this.gbGenerateReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1360, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // msMainMenu
            // 
            this.msMainMenu.BackColor = System.Drawing.Color.Maroon;
            this.msMainMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCars,
            this.miCustomers,
            this.miEmployees,
            this.miLogOut});
            this.msMainMenu.Location = new System.Drawing.Point(0, 0);
            this.msMainMenu.Name = "msMainMenu";
            this.msMainMenu.Padding = new System.Windows.Forms.Padding(6, 8, 0, 8);
            this.msMainMenu.Size = new System.Drawing.Size(1360, 38);
            this.msMainMenu.TabIndex = 0;
            // 
            // miCars
            // 
            this.miCars.BackColor = System.Drawing.Color.Maroon;
            this.miCars.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miCars.ForeColor = System.Drawing.Color.White;
            this.miCars.Name = "miCars";
            this.miCars.Size = new System.Drawing.Size(60, 22);
            this.miCars.Text = "&Cars";
            this.miCars.Click += new System.EventHandler(this.miCars_Click);
            // 
            // miCustomers
            // 
            this.miCustomers.BackColor = System.Drawing.Color.Maroon;
            this.miCustomers.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miCustomers.ForeColor = System.Drawing.Color.White;
            this.miCustomers.Name = "miCustomers";
            this.miCustomers.Size = new System.Drawing.Size(114, 22);
            this.miCustomers.Text = "C&ustomers";
            this.miCustomers.Click += new System.EventHandler(this.miCustomer_Click);
            // 
            // miEmployees
            // 
            this.miEmployees.BackColor = System.Drawing.Color.Maroon;
            this.miEmployees.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miEmployees.ForeColor = System.Drawing.Color.White;
            this.miEmployees.Name = "miEmployees";
            this.miEmployees.Size = new System.Drawing.Size(114, 22);
            this.miEmployees.Text = "&Employees";
            this.miEmployees.Click += new System.EventHandler(this.miEmployee_Click);
            // 
            // miLogOut
            // 
            this.miLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.miLogOut.BackColor = System.Drawing.Color.Maroon;
            this.miLogOut.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miLogOut.ForeColor = System.Drawing.Color.White;
            this.miLogOut.Name = "miLogOut";
            this.miLogOut.Size = new System.Drawing.Size(89, 22);
            this.miLogOut.Text = "&Log Out";
            this.miLogOut.Click += new System.EventHandler(this.miLogOut_Click);
            // 
            // gbGenerateReport
            // 
            this.gbGenerateReport.BackColor = System.Drawing.Color.White;
            this.gbGenerateReport.Controls.Add(this.btnEmployeePerformance);
            this.gbGenerateReport.Controls.Add(this.btnCustomerGrowthReport);
            this.gbGenerateReport.Controls.Add(this.btnFullSalesReports);
            this.gbGenerateReport.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGenerateReport.Location = new System.Drawing.Point(803, 51);
            this.gbGenerateReport.Name = "gbGenerateReport";
            this.gbGenerateReport.Size = new System.Drawing.Size(545, 68);
            this.gbGenerateReport.TabIndex = 10;
            this.gbGenerateReport.TabStop = false;
            this.gbGenerateReport.Text = "Generate Reports";
            // 
            // btnEmployeePerformance
            // 
            this.btnEmployeePerformance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEmployeePerformance.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeePerformance.ForeColor = System.Drawing.Color.White;
            this.btnEmployeePerformance.Location = new System.Drawing.Point(314, 26);
            this.btnEmployeePerformance.Name = "btnEmployeePerformance";
            this.btnEmployeePerformance.Size = new System.Drawing.Size(225, 28);
            this.btnEmployeePerformance.TabIndex = 6;
            this.btnEmployeePerformance.Text = "Employee Performance";
            this.btnEmployeePerformance.UseVisualStyleBackColor = false;
            this.btnEmployeePerformance.Click += new System.EventHandler(this.btnEmployeePerformance_Click);
            // 
            // btnCustomerGrowthReport
            // 
            this.btnCustomerGrowthReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCustomerGrowthReport.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerGrowthReport.ForeColor = System.Drawing.Color.White;
            this.btnCustomerGrowthReport.Location = new System.Drawing.Point(148, 26);
            this.btnCustomerGrowthReport.Name = "btnCustomerGrowthReport";
            this.btnCustomerGrowthReport.Size = new System.Drawing.Size(160, 28);
            this.btnCustomerGrowthReport.TabIndex = 4;
            this.btnCustomerGrowthReport.Text = "Customer Growth";
            this.btnCustomerGrowthReport.UseVisualStyleBackColor = false;
            this.btnCustomerGrowthReport.Click += new System.EventHandler(this.btnCustomerGrowthReport_Click);
            // 
            // btnFullSalesReports
            // 
            this.btnFullSalesReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFullSalesReports.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFullSalesReports.ForeColor = System.Drawing.Color.White;
            this.btnFullSalesReports.Location = new System.Drawing.Point(7, 26);
            this.btnFullSalesReports.Name = "btnFullSalesReports";
            this.btnFullSalesReports.Size = new System.Drawing.Size(135, 28);
            this.btnFullSalesReports.TabIndex = 1;
            this.btnFullSalesReports.Text = "Sales Report";
            this.btnFullSalesReports.UseVisualStyleBackColor = false;
            this.btnFullSalesReports.Click += new System.EventHandler(this.btnFullSalesReports_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.White;
            this.lblWelcome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 51);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(5);
            this.lblWelcome.Size = new System.Drawing.Size(10, 28);
            this.lblWelcome.TabIndex = 12;
            // 
            // mdiHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::prjcsm.Properties.Resources.Homepage_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1360, 453);
            this.ControlBox = false;
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.msMainMenu);
            this.Controls.Add(this.gbGenerateReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdiHome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.msMainMenu.ResumeLayout(false);
            this.msMainMenu.PerformLayout();
            this.gbGenerateReport.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip msMainMenu;
        private System.Windows.Forms.ToolStripMenuItem miCars;
        private System.Windows.Forms.ToolStripMenuItem miEmployees;
        private System.Windows.Forms.ToolStripMenuItem miLogOut;
        private System.Windows.Forms.ToolStripMenuItem miCustomers;
        private System.Windows.Forms.GroupBox gbGenerateReport;
        private System.Windows.Forms.Button btnFullSalesReports;
        private System.Windows.Forms.Button btnEmployeePerformance;
        private System.Windows.Forms.Button btnCustomerGrowthReport;
        private System.Windows.Forms.Label lblWelcome;
    }
}



