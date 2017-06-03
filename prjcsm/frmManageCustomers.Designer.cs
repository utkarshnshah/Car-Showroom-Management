namespace prjcsm
{
    partial class frmManageCustomers
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
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.gbManageCustomer = new System.Windows.Forms.GroupBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.licenseNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carPurchasedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csmDSCustomers = new prjcsm.csmDSCustomers();
            this.btnCloseCustomer = new System.Windows.Forms.Button();
            this.tbCustomersTableAdapter = new prjcsm.csmDSCustomersTableAdapters.tbCustomersTableAdapter();
            this.gbManageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnNewCustomer.Location = new System.Drawing.Point(361, 356);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(155, 28);
            this.btnNewCustomer.TabIndex = 1;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEditCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Location = new System.Drawing.Point(522, 356);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(155, 28);
            this.btnEditCustomer.TabIndex = 2;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = false;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(683, 356);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(155, 28);
            this.btnDeleteCustomer.TabIndex = 3;
            this.btnDeleteCustomer.Text = "Delete Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // gbManageCustomer
            // 
            this.gbManageCustomer.Controls.Add(this.dgvCustomers);
            this.gbManageCustomer.Controls.Add(this.btnCloseCustomer);
            this.gbManageCustomer.Controls.Add(this.btnDeleteCustomer);
            this.gbManageCustomer.Controls.Add(this.btnEditCustomer);
            this.gbManageCustomer.Controls.Add(this.btnNewCustomer);
            this.gbManageCustomer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageCustomer.Location = new System.Drawing.Point(12, 12);
            this.gbManageCustomer.Name = "gbManageCustomer";
            this.gbManageCustomer.Size = new System.Drawing.Size(970, 390);
            this.gbManageCustomer.TabIndex = 4;
            this.gbManageCustomer.TabStop = false;
            this.gbManageCustomer.Text = "Manage Customers";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AutoGenerateColumns = false;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.licenseNoDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.carPurchasedDataGridViewTextBoxColumn,
            this.accountCreatedDataGridViewTextBoxColumn});
            this.dgvCustomers.DataSource = this.tbCustomersBindingSource;
            this.dgvCustomers.Location = new System.Drawing.Point(6, 26);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(958, 297);
            this.dgvCustomers.TabIndex = 5;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "customerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // licenseNoDataGridViewTextBoxColumn
            // 
            this.licenseNoDataGridViewTextBoxColumn.DataPropertyName = "licenseNo";
            this.licenseNoDataGridViewTextBoxColumn.HeaderText = "License No";
            this.licenseNoDataGridViewTextBoxColumn.Name = "licenseNoDataGridViewTextBoxColumn";
            this.licenseNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.licenseNoDataGridViewTextBoxColumn.Width = 120;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Width = 250;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.ReadOnly = true;
            this.contactDataGridViewTextBoxColumn.Width = 105;
            // 
            // carPurchasedDataGridViewTextBoxColumn
            // 
            this.carPurchasedDataGridViewTextBoxColumn.DataPropertyName = "carPurchased";
            this.carPurchasedDataGridViewTextBoxColumn.HeaderText = "Car Purchased";
            this.carPurchasedDataGridViewTextBoxColumn.Name = "carPurchasedDataGridViewTextBoxColumn";
            this.carPurchasedDataGridViewTextBoxColumn.ReadOnly = true;
            this.carPurchasedDataGridViewTextBoxColumn.Width = 150;
            // 
            // accountCreatedDataGridViewTextBoxColumn
            // 
            this.accountCreatedDataGridViewTextBoxColumn.DataPropertyName = "accountCreated";
            this.accountCreatedDataGridViewTextBoxColumn.HeaderText = "Account Created";
            this.accountCreatedDataGridViewTextBoxColumn.Name = "accountCreatedDataGridViewTextBoxColumn";
            this.accountCreatedDataGridViewTextBoxColumn.ReadOnly = true;
            this.accountCreatedDataGridViewTextBoxColumn.Visible = false;
            // 
            // tbCustomersBindingSource
            // 
            this.tbCustomersBindingSource.DataMember = "tbCustomers";
            this.tbCustomersBindingSource.DataSource = this.csmDSCustomers;
            // 
            // csmDSCustomers
            // 
            this.csmDSCustomers.DataSetName = "csmDSCustomers";
            this.csmDSCustomers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCloseCustomer
            // 
            this.btnCloseCustomer.BackColor = System.Drawing.Color.Maroon;
            this.btnCloseCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCloseCustomer.Location = new System.Drawing.Point(844, 356);
            this.btnCloseCustomer.Name = "btnCloseCustomer";
            this.btnCloseCustomer.Size = new System.Drawing.Size(120, 28);
            this.btnCloseCustomer.TabIndex = 4;
            this.btnCloseCustomer.Text = "Close";
            this.btnCloseCustomer.UseVisualStyleBackColor = false;
            this.btnCloseCustomer.Click += new System.EventHandler(this.btnCloseCustomer_Click);
            // 
            // tbCustomersTableAdapter
            // 
            this.tbCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 414);
            this.ControlBox = false;
            this.Controls.Add(this.gbManageCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageCustomers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmManageCustomers_Load);
            this.gbManageCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.GroupBox gbManageCustomer;
        private System.Windows.Forms.Button btnCloseCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private csmDSCustomers csmDSCustomers;
        private System.Windows.Forms.BindingSource tbCustomersBindingSource;
        private csmDSCustomersTableAdapters.tbCustomersTableAdapter tbCustomersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn licenseNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carPurchasedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCreatedDataGridViewTextBoxColumn;
    }
}