namespace prjcsm
{
    partial class frmManageEmployees
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passWordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEmployeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csmDSEmployees = new prjcsm.csmDSEmployees();
            this.btnHireEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnFireEmployee = new System.Windows.Forms.Button();
            this.gbManageEmployees = new System.Windows.Forms.GroupBox();
            this.btnCloseEmployees = new System.Windows.Forms.Button();
            this.tbEmployeesTableAdapter = new prjcsm.csmDSEmployeesTableAdapters.tbEmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSEmployees)).BeginInit();
            this.gbManageEmployees.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passWordDataGridViewTextBoxColumn,
            this.employeeFirstNameDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn});
            this.dgvEmployees.DataSource = this.tbEmployeesBindingSource;
            this.dgvEmployees.Location = new System.Drawing.Point(6, 26);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.Size = new System.Drawing.Size(758, 300);
            this.dgvEmployees.TabIndex = 0;
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "employeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // passWordDataGridViewTextBoxColumn
            // 
            this.passWordDataGridViewTextBoxColumn.DataPropertyName = "passWord";
            this.passWordDataGridViewTextBoxColumn.HeaderText = "Pass Word";
            this.passWordDataGridViewTextBoxColumn.Name = "passWordDataGridViewTextBoxColumn";
            this.passWordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passWordDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeeFirstNameDataGridViewTextBoxColumn
            // 
            this.employeeFirstNameDataGridViewTextBoxColumn.DataPropertyName = "employeeFirstName";
            this.employeeFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.employeeFirstNameDataGridViewTextBoxColumn.Name = "employeeFirstNameDataGridViewTextBoxColumn";
            this.employeeFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeFirstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "employeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            this.employeeLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeLastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "userType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "User Type";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            this.userTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.userTypeDataGridViewTextBoxColumn.Width = 120;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 205;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbEmployeesBindingSource
            // 
            this.tbEmployeesBindingSource.DataMember = "tbEmployees";
            this.tbEmployeesBindingSource.DataSource = this.csmDSEmployees;
            // 
            // csmDSEmployees
            // 
            this.csmDSEmployees.DataSetName = "csmDSEmployees";
            this.csmDSEmployees.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnHireEmployee
            // 
            this.btnHireEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHireEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHireEmployee.ForeColor = System.Drawing.Color.White;
            this.btnHireEmployee.Location = new System.Drawing.Point(186, 356);
            this.btnHireEmployee.Name = "btnHireEmployee";
            this.btnHireEmployee.Size = new System.Drawing.Size(140, 28);
            this.btnHireEmployee.TabIndex = 1;
            this.btnHireEmployee.Text = "Hire Employee";
            this.btnHireEmployee.UseVisualStyleBackColor = false;
            this.btnHireEmployee.Click += new System.EventHandler(this.btnHireEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEditEmployee.Location = new System.Drawing.Point(332, 356);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(140, 28);
            this.btnEditEmployee.TabIndex = 2;
            this.btnEditEmployee.Text = "Edit Employee";
            this.btnEditEmployee.UseVisualStyleBackColor = false;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnFireEmployee
            // 
            this.btnFireEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFireEmployee.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFireEmployee.ForeColor = System.Drawing.Color.White;
            this.btnFireEmployee.Location = new System.Drawing.Point(478, 356);
            this.btnFireEmployee.Name = "btnFireEmployee";
            this.btnFireEmployee.Size = new System.Drawing.Size(140, 28);
            this.btnFireEmployee.TabIndex = 3;
            this.btnFireEmployee.Text = "Fire Employee";
            this.btnFireEmployee.UseVisualStyleBackColor = false;
            this.btnFireEmployee.Click += new System.EventHandler(this.btnFireEmployee_Click);
            // 
            // gbManageEmployees
            // 
            this.gbManageEmployees.Controls.Add(this.btnCloseEmployees);
            this.gbManageEmployees.Controls.Add(this.dgvEmployees);
            this.gbManageEmployees.Controls.Add(this.btnFireEmployee);
            this.gbManageEmployees.Controls.Add(this.btnEditEmployee);
            this.gbManageEmployees.Controls.Add(this.btnHireEmployee);
            this.gbManageEmployees.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageEmployees.Location = new System.Drawing.Point(12, 12);
            this.gbManageEmployees.Name = "gbManageEmployees";
            this.gbManageEmployees.Size = new System.Drawing.Size(770, 390);
            this.gbManageEmployees.TabIndex = 5;
            this.gbManageEmployees.TabStop = false;
            this.gbManageEmployees.Text = "Manage Employees";
            // 
            // btnCloseEmployees
            // 
            this.btnCloseEmployees.BackColor = System.Drawing.Color.Maroon;
            this.btnCloseEmployees.ForeColor = System.Drawing.Color.White;
            this.btnCloseEmployees.Location = new System.Drawing.Point(624, 356);
            this.btnCloseEmployees.Name = "btnCloseEmployees";
            this.btnCloseEmployees.Size = new System.Drawing.Size(140, 28);
            this.btnCloseEmployees.TabIndex = 4;
            this.btnCloseEmployees.Text = "Close";
            this.btnCloseEmployees.UseVisualStyleBackColor = false;
            this.btnCloseEmployees.Click += new System.EventHandler(this.btnCloseEmployees_Click);
            // 
            // tbEmployeesTableAdapter
            // 
            this.tbEmployeesTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(794, 414);
            this.ControlBox = false;
            this.Controls.Add(this.gbManageEmployees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageEmployees";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmManageEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSEmployees)).EndInit();
            this.gbManageEmployees.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnHireEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnFireEmployee;
        private System.Windows.Forms.GroupBox gbManageEmployees;
        private System.Windows.Forms.Button btnCloseEmployees;
        private csmDSEmployees csmDSEmployees;
        private System.Windows.Forms.BindingSource tbEmployeesBindingSource;
        private csmDSEmployeesTableAdapters.tbEmployeesTableAdapter tbEmployeesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passWordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
    }
}