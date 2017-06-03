namespace prjcsm
{
    partial class frmCarManagement
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
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblLaunchDate = new System.Windows.Forms.Label();
            this.lblSpecification = new System.Windows.Forms.Label();
            this.lblAvailableCars = new System.Windows.Forms.Label();
            this.txtCarCompany = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.gbCarsManagement = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtSetDiscount = new System.Windows.Forms.TextBox();
            this.lblSetDiscount = new System.Windows.Forms.Label();
            this.btnModifyCars = new System.Windows.Forms.Button();
            this.btnCancelCarBox = new System.Windows.Forms.Button();
            this.txtCarSpecification = new System.Windows.Forms.TextBox();
            this.txtAvailableCars = new System.Windows.Forms.TextBox();
            this.dtpLaunchDate = new System.Windows.Forms.DateTimePicker();
            this.gbCarsManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(6, 46);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(83, 18);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "Company";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(6, 79);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(56, 18);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblLaunchDate
            // 
            this.lblLaunchDate.AutoSize = true;
            this.lblLaunchDate.Location = new System.Drawing.Point(6, 115);
            this.lblLaunchDate.Name = "lblLaunchDate";
            this.lblLaunchDate.Size = new System.Drawing.Size(94, 18);
            this.lblLaunchDate.TabIndex = 2;
            this.lblLaunchDate.Text = "Launch On";
            // 
            // lblSpecification
            // 
            this.lblSpecification.AutoSize = true;
            this.lblSpecification.Location = new System.Drawing.Point(6, 145);
            this.lblSpecification.Name = "lblSpecification";
            this.lblSpecification.Size = new System.Drawing.Size(112, 18);
            this.lblSpecification.TabIndex = 3;
            this.lblSpecification.Text = "Specification";
            // 
            // lblAvailableCars
            // 
            this.lblAvailableCars.AutoSize = true;
            this.lblAvailableCars.Location = new System.Drawing.Point(6, 244);
            this.lblAvailableCars.Name = "lblAvailableCars";
            this.lblAvailableCars.Size = new System.Drawing.Size(139, 18);
            this.lblAvailableCars.TabIndex = 4;
            this.lblAvailableCars.Text = "Available Car(s)";
            // 
            // txtCarCompany
            // 
            this.txtCarCompany.Location = new System.Drawing.Point(208, 43);
            this.txtCarCompany.MaxLength = 15;
            this.txtCarCompany.Name = "txtCarCompany";
            this.txtCarCompany.Size = new System.Drawing.Size(150, 27);
            this.txtCarCompany.TabIndex = 0;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(208, 76);
            this.txtCarModel.MaxLength = 25;
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(150, 27);
            this.txtCarModel.TabIndex = 1;
            // 
            // gbCarsManagement
            // 
            this.gbCarsManagement.Controls.Add(this.txtPrice);
            this.gbCarsManagement.Controls.Add(this.lblPrice);
            this.gbCarsManagement.Controls.Add(this.txtSetDiscount);
            this.gbCarsManagement.Controls.Add(this.lblSetDiscount);
            this.gbCarsManagement.Controls.Add(this.btnModifyCars);
            this.gbCarsManagement.Controls.Add(this.btnCancelCarBox);
            this.gbCarsManagement.Controls.Add(this.txtCarSpecification);
            this.gbCarsManagement.Controls.Add(this.txtAvailableCars);
            this.gbCarsManagement.Controls.Add(this.dtpLaunchDate);
            this.gbCarsManagement.Controls.Add(this.lblCompany);
            this.gbCarsManagement.Controls.Add(this.txtCarModel);
            this.gbCarsManagement.Controls.Add(this.lblModel);
            this.gbCarsManagement.Controls.Add(this.txtCarCompany);
            this.gbCarsManagement.Controls.Add(this.lblLaunchDate);
            this.gbCarsManagement.Controls.Add(this.lblSpecification);
            this.gbCarsManagement.Controls.Add(this.lblAvailableCars);
            this.gbCarsManagement.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCarsManagement.Location = new System.Drawing.Point(12, 12);
            this.gbCarsManagement.Name = "gbCarsManagement";
            this.gbCarsManagement.Size = new System.Drawing.Size(427, 360);
            this.gbCarsManagement.TabIndex = 10;
            this.gbCarsManagement.TabStop = false;
            this.gbCarsManagement.Text = "Car Management";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(208, 208);
            this.txtPrice.MaxLength = 8;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(150, 27);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(6, 211);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(47, 18);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price";
            // 
            // txtSetDiscount
            // 
            this.txtSetDiscount.Location = new System.Drawing.Point(208, 274);
            this.txtSetDiscount.MaxLength = 2;
            this.txtSetDiscount.Name = "txtSetDiscount";
            this.txtSetDiscount.Size = new System.Drawing.Size(150, 27);
            this.txtSetDiscount.TabIndex = 6;
            this.txtSetDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSetDiscount_KeyPress);
            // 
            // lblSetDiscount
            // 
            this.lblSetDiscount.AutoSize = true;
            this.lblSetDiscount.Location = new System.Drawing.Point(6, 277);
            this.lblSetDiscount.Name = "lblSetDiscount";
            this.lblSetDiscount.Size = new System.Drawing.Size(112, 18);
            this.lblSetDiscount.TabIndex = 12;
            this.lblSetDiscount.Text = "Set Discount";
            // 
            // btnModifyCars
            // 
            this.btnModifyCars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifyCars.ForeColor = System.Drawing.Color.White;
            this.btnModifyCars.Location = new System.Drawing.Point(208, 322);
            this.btnModifyCars.Name = "btnModifyCars";
            this.btnModifyCars.Size = new System.Drawing.Size(100, 28);
            this.btnModifyCars.TabIndex = 7;
            this.btnModifyCars.Text = "Modify";
            this.btnModifyCars.UseVisualStyleBackColor = false;
            this.btnModifyCars.Click += new System.EventHandler(this.btnModifyCars_Click);
            // 
            // btnCancelCarBox
            // 
            this.btnCancelCarBox.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelCarBox.ForeColor = System.Drawing.Color.White;
            this.btnCancelCarBox.Location = new System.Drawing.Point(314, 322);
            this.btnCancelCarBox.Name = "btnCancelCarBox";
            this.btnCancelCarBox.Size = new System.Drawing.Size(100, 28);
            this.btnCancelCarBox.TabIndex = 8;
            this.btnCancelCarBox.Text = "Cancel";
            this.btnCancelCarBox.UseVisualStyleBackColor = false;
            this.btnCancelCarBox.Click += new System.EventHandler(this.btnCancelCarBox_Click);
            // 
            // txtCarSpecification
            // 
            this.txtCarSpecification.Location = new System.Drawing.Point(208, 142);
            this.txtCarSpecification.MaxLength = 250;
            this.txtCarSpecification.Multiline = true;
            this.txtCarSpecification.Name = "txtCarSpecification";
            this.txtCarSpecification.Size = new System.Drawing.Size(206, 60);
            this.txtCarSpecification.TabIndex = 3;
            // 
            // txtAvailableCars
            // 
            this.txtAvailableCars.Location = new System.Drawing.Point(208, 241);
            this.txtAvailableCars.MaxLength = 3;
            this.txtAvailableCars.Name = "txtAvailableCars";
            this.txtAvailableCars.Size = new System.Drawing.Size(150, 27);
            this.txtAvailableCars.TabIndex = 5;
            this.txtAvailableCars.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAvailableCars_KeyPress);
            // 
            // dtpLaunchDate
            // 
            this.dtpLaunchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLaunchDate.Location = new System.Drawing.Point(208, 109);
            this.dtpLaunchDate.Name = "dtpLaunchDate";
            this.dtpLaunchDate.Size = new System.Drawing.Size(206, 27);
            this.dtpLaunchDate.TabIndex = 2;
            // 
            // frmCarManagement
            // 
            this.AcceptButton = this.btnModifyCars;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(451, 384);
            this.ControlBox = false;
            this.Controls.Add(this.gbCarsManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCarManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.gbCarsManagement.ResumeLayout(false);
            this.gbCarsManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblLaunchDate;
        private System.Windows.Forms.Label lblSpecification;
        private System.Windows.Forms.Label lblAvailableCars;
        private System.Windows.Forms.TextBox txtCarCompany;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.GroupBox gbCarsManagement;
        private System.Windows.Forms.TextBox txtCarSpecification;
        private System.Windows.Forms.TextBox txtAvailableCars;
        private System.Windows.Forms.DateTimePicker dtpLaunchDate;
        private System.Windows.Forms.Button btnModifyCars;
        private System.Windows.Forms.Button btnCancelCarBox;
        private System.Windows.Forms.TextBox txtSetDiscount;
        private System.Windows.Forms.Label lblSetDiscount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
    }
}