namespace prjcsm
{
    partial class frmManageCar
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
            this.btnNewCar = new System.Windows.Forms.Button();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.btnStopTrading = new System.Windows.Forms.Button();
            this.btnStartTrading = new System.Windows.Forms.Button();
            this.gbManageCars = new System.Windows.Forms.GroupBox();
            this.dgvCars = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCarsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csmDSCars = new prjcsm.csmDSCars();
            this.btnSellCar = new System.Windows.Forms.Button();
            this.btnCloseCars = new System.Windows.Forms.Button();
            this.tbCarsTableAdapter = new prjcsm.csmDSCarsTableAdapters.tbCarsTableAdapter();
            this.gbManageCars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCarsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSCars)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewCar
            // 
            this.btnNewCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNewCar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCar.ForeColor = System.Drawing.Color.White;
            this.btnNewCar.Location = new System.Drawing.Point(545, 356);
            this.btnNewCar.Name = "btnNewCar";
            this.btnNewCar.Size = new System.Drawing.Size(120, 28);
            this.btnNewCar.TabIndex = 2;
            this.btnNewCar.Text = "New Car";
            this.btnNewCar.UseVisualStyleBackColor = false;
            this.btnNewCar.Click += new System.EventHandler(this.btnNewCar_Click);
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdateCar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCar.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCar.Location = new System.Drawing.Point(671, 356);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(120, 28);
            this.btnUpdateCar.TabIndex = 3;
            this.btnUpdateCar.Text = "Update Car";
            this.btnUpdateCar.UseVisualStyleBackColor = false;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // btnStopTrading
            // 
            this.btnStopTrading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStopTrading.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTrading.ForeColor = System.Drawing.Color.White;
            this.btnStopTrading.Location = new System.Drawing.Point(928, 356);
            this.btnStopTrading.Name = "btnStopTrading";
            this.btnStopTrading.Size = new System.Drawing.Size(120, 28);
            this.btnStopTrading.TabIndex = 5;
            this.btnStopTrading.Text = "Stop Trading";
            this.btnStopTrading.UseVisualStyleBackColor = false;
            this.btnStopTrading.Click += new System.EventHandler(this.btnStopTrading_Click);
            // 
            // btnStartTrading
            // 
            this.btnStartTrading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStartTrading.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTrading.ForeColor = System.Drawing.Color.White;
            this.btnStartTrading.Location = new System.Drawing.Point(797, 356);
            this.btnStartTrading.Name = "btnStartTrading";
            this.btnStartTrading.Size = new System.Drawing.Size(125, 28);
            this.btnStartTrading.TabIndex = 4;
            this.btnStartTrading.Text = "Start Trading";
            this.btnStartTrading.UseVisualStyleBackColor = false;
            this.btnStartTrading.Click += new System.EventHandler(this.btnStartTrading_Click);
            // 
            // gbManageCars
            // 
            this.gbManageCars.Controls.Add(this.dgvCars);
            this.gbManageCars.Controls.Add(this.btnSellCar);
            this.gbManageCars.Controls.Add(this.btnCloseCars);
            this.gbManageCars.Controls.Add(this.btnNewCar);
            this.gbManageCars.Controls.Add(this.btnStartTrading);
            this.gbManageCars.Controls.Add(this.btnUpdateCar);
            this.gbManageCars.Controls.Add(this.btnStopTrading);
            this.gbManageCars.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbManageCars.Location = new System.Drawing.Point(12, 12);
            this.gbManageCars.Name = "gbManageCars";
            this.gbManageCars.Size = new System.Drawing.Size(1180, 390);
            this.gbManageCars.TabIndex = 7;
            this.gbManageCars.TabStop = false;
            this.gbManageCars.Text = "Manage Cars";
            // 
            // dgvCars
            // 
            this.dgvCars.AllowUserToAddRows = false;
            this.dgvCars.AllowUserToDeleteRows = false;
            this.dgvCars.AutoGenerateColumns = false;
            this.dgvCars.BackgroundColor = System.Drawing.Color.White;
            this.dgvCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dgvCars.DataSource = this.tbCarsBindingSource;
            this.dgvCars.Location = new System.Drawing.Point(6, 26);
            this.dgvCars.Name = "dgvCars";
            this.dgvCars.ReadOnly = true;
            this.dgvCars.Size = new System.Drawing.Size(1168, 285);
            this.dgvCars.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "carID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "carCompany";
            this.dataGridViewTextBoxColumn11.HeaderText = "Company";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 155;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "model";
            this.dataGridViewTextBoxColumn12.HeaderText = "Model";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 150;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "launchDate";
            this.dataGridViewTextBoxColumn13.HeaderText = "Launch On";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 120;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "specifications";
            this.dataGridViewTextBoxColumn14.HeaderText = "Specifications";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 350;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn15.HeaderText = "Price";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 90;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "availableCars";
            this.dataGridViewTextBoxColumn16.HeaderText = "Available";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 90;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "setDiscount";
            this.dataGridViewTextBoxColumn17.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 90;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "tradeStatus";
            this.dataGridViewTextBoxColumn18.HeaderText = "Trading";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 80;
            // 
            // tbCarsBindingSource
            // 
            this.tbCarsBindingSource.DataMember = "tbCars";
            this.tbCarsBindingSource.DataSource = this.csmDSCars;
            // 
            // csmDSCars
            // 
            this.csmDSCars.DataSetName = "csmDSCars";
            this.csmDSCars.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSellCar
            // 
            this.btnSellCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSellCar.ForeColor = System.Drawing.Color.White;
            this.btnSellCar.Location = new System.Drawing.Point(6, 356);
            this.btnSellCar.Name = "btnSellCar";
            this.btnSellCar.Size = new System.Drawing.Size(120, 28);
            this.btnSellCar.TabIndex = 1;
            this.btnSellCar.Text = "Sell Car";
            this.btnSellCar.UseVisualStyleBackColor = false;
            this.btnSellCar.Click += new System.EventHandler(this.btnSellCar_Click);
            // 
            // btnCloseCars
            // 
            this.btnCloseCars.BackColor = System.Drawing.Color.Maroon;
            this.btnCloseCars.ForeColor = System.Drawing.Color.White;
            this.btnCloseCars.Location = new System.Drawing.Point(1054, 356);
            this.btnCloseCars.Name = "btnCloseCars";
            this.btnCloseCars.Size = new System.Drawing.Size(120, 28);
            this.btnCloseCars.TabIndex = 6;
            this.btnCloseCars.Text = "Close";
            this.btnCloseCars.UseVisualStyleBackColor = false;
            this.btnCloseCars.Click += new System.EventHandler(this.btnCloseCars_Click);
            // 
            // tbCarsTableAdapter
            // 
            this.tbCarsTableAdapter.ClearBeforeFill = true;
            // 
            // frmManageCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1204, 414);
            this.ControlBox = false;
            this.Controls.Add(this.gbManageCars);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmManageCar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmManageCar_Load);
            this.gbManageCars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCarsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csmDSCars)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNewCar;
        private System.Windows.Forms.Button btnUpdateCar;
        private System.Windows.Forms.Button btnStopTrading;
        private System.Windows.Forms.Button btnStartTrading;
        private System.Windows.Forms.GroupBox gbManageCars;
        private System.Windows.Forms.Button btnCloseCars;
        private System.Windows.Forms.Button btnSellCar;
        private System.Windows.Forms.DataGridView dgvCars;
        private csmDSCars csmDSCars;
        private System.Windows.Forms.BindingSource tbCarsBindingSource;
        private csmDSCarsTableAdapters.tbCarsTableAdapter tbCarsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}