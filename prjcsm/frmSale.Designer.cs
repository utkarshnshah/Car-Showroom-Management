namespace prjcsm
{
    partial class frmSale
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
            this.gbSaleForm = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblDollarIcon1 = new System.Windows.Forms.Label();
            this.lblDollarIcon2 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblPercentageIcon1 = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCarPrice = new System.Windows.Forms.Label();
            this.txtCarPrice = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblCustomerList = new System.Windows.Forms.Label();
            this.lblPercentageIcon2 = new System.Windows.Forms.Label();
            this.lblSpecialOffer = new System.Windows.Forms.Label();
            this.txtSpecialOffer = new System.Windows.Forms.TextBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtCarOrdered = new System.Windows.Forms.TextBox();
            this.lblCarsOrdered = new System.Windows.Forms.Label();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.gbSaleForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSaleForm
            // 
            this.gbSaleForm.Controls.Add(this.btnDone);
            this.gbSaleForm.Controls.Add(this.lblDollarIcon1);
            this.gbSaleForm.Controls.Add(this.lblDollarIcon2);
            this.gbSaleForm.Controls.Add(this.txtModel);
            this.gbSaleForm.Controls.Add(this.txtCompany);
            this.gbSaleForm.Controls.Add(this.btnSelect);
            this.gbSaleForm.Controls.Add(this.lblPercentageIcon1);
            this.gbSaleForm.Controls.Add(this.lblDiscount);
            this.gbSaleForm.Controls.Add(this.txtDiscount);
            this.gbSaleForm.Controls.Add(this.txtFinalPrice);
            this.gbSaleForm.Controls.Add(this.label1);
            this.gbSaleForm.Controls.Add(this.lblCarPrice);
            this.gbSaleForm.Controls.Add(this.txtCarPrice);
            this.gbSaleForm.Controls.Add(this.txtLastName);
            this.gbSaleForm.Controls.Add(this.txtCustomerID);
            this.gbSaleForm.Controls.Add(this.txtFirstName);
            this.gbSaleForm.Controls.Add(this.lblLastName);
            this.gbSaleForm.Controls.Add(this.lblFirstName);
            this.gbSaleForm.Controls.Add(this.lblCustomerList);
            this.gbSaleForm.Controls.Add(this.lblPercentageIcon2);
            this.gbSaleForm.Controls.Add(this.lblSpecialOffer);
            this.gbSaleForm.Controls.Add(this.txtSpecialOffer);
            this.gbSaleForm.Controls.Add(this.lblCompany);
            this.gbSaleForm.Controls.Add(this.lblModel);
            this.gbSaleForm.Controls.Add(this.txtCarOrdered);
            this.gbSaleForm.Controls.Add(this.lblCarsOrdered);
            this.gbSaleForm.Controls.Add(this.btnSale);
            this.gbSaleForm.Controls.Add(this.btnCancelSale);
            this.gbSaleForm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSaleForm.Location = new System.Drawing.Point(12, 12);
            this.gbSaleForm.Name = "gbSaleForm";
            this.gbSaleForm.Size = new System.Drawing.Size(440, 430);
            this.gbSaleForm.TabIndex = 13;
            this.gbSaleForm.TabStop = false;
            this.gbSaleForm.Text = "Sale Form";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(352, 33);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(68, 27);
            this.btnDone.TabIndex = 44;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // lblDollarIcon1
            // 
            this.lblDollarIcon1.AutoSize = true;
            this.lblDollarIcon1.Location = new System.Drawing.Point(256, 202);
            this.lblDollarIcon1.Name = "lblDollarIcon1";
            this.lblDollarIcon1.Size = new System.Drawing.Size(18, 18);
            this.lblDollarIcon1.TabIndex = 43;
            this.lblDollarIcon1.Text = "$";
            // 
            // lblDollarIcon2
            // 
            this.lblDollarIcon2.AutoSize = true;
            this.lblDollarIcon2.Location = new System.Drawing.Point(352, 334);
            this.lblDollarIcon2.Name = "lblDollarIcon2";
            this.lblDollarIcon2.Size = new System.Drawing.Size(18, 18);
            this.lblDollarIcon2.TabIndex = 42;
            this.lblDollarIcon2.Text = "$";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(170, 165);
            this.txtModel.MaxLength = 25;
            this.txtModel.Name = "txtModel";
            this.txtModel.ReadOnly = true;
            this.txtModel.Size = new System.Drawing.Size(200, 27);
            this.txtModel.TabIndex = 3;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(170, 132);
            this.txtCompany.MaxLength = 15;
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.ReadOnly = true;
            this.txtCompany.Size = new System.Drawing.Size(200, 27);
            this.txtCompany.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(276, 33);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(70, 27);
            this.btnSelect.TabIndex = 38;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblPercentageIcon1
            // 
            this.lblPercentageIcon1.AutoSize = true;
            this.lblPercentageIcon1.Location = new System.Drawing.Point(252, 301);
            this.lblPercentageIcon1.Name = "lblPercentageIcon1";
            this.lblPercentageIcon1.Size = new System.Drawing.Size(25, 18);
            this.lblPercentageIcon1.TabIndex = 37;
            this.lblPercentageIcon1.Text = "%";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(6, 265);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(79, 18);
            this.lblDiscount.TabIndex = 36;
            this.lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(170, 264);
            this.txtDiscount.MaxLength = 2;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(80, 27);
            this.txtDiscount.TabIndex = 6;
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.Location = new System.Drawing.Point(170, 330);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.ReadOnly = true;
            this.txtFinalPrice.Size = new System.Drawing.Size(176, 27);
            this.txtFinalPrice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 33;
            this.label1.Text = "Final Price";
            // 
            // lblCarPrice
            // 
            this.lblCarPrice.AutoSize = true;
            this.lblCarPrice.Location = new System.Drawing.Point(6, 202);
            this.lblCarPrice.Name = "lblCarPrice";
            this.lblCarPrice.Size = new System.Drawing.Size(47, 18);
            this.lblCarPrice.TabIndex = 32;
            this.lblCarPrice.Text = "Price";
            // 
            // txtCarPrice
            // 
            this.txtCarPrice.Location = new System.Drawing.Point(170, 198);
            this.txtCarPrice.MaxLength = 8;
            this.txtCarPrice.Name = "txtCarPrice";
            this.txtCarPrice.ReadOnly = true;
            this.txtCarPrice.Size = new System.Drawing.Size(80, 27);
            this.txtCarPrice.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(170, 99);
            this.txtLastName.MaxLength = 10;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 27);
            this.txtLastName.TabIndex = 1;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(170, 33);
            this.txtCustomerID.MaxLength = 25000;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(100, 27);
            this.txtCustomerID.TabIndex = 11;
            this.txtCustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerID_KeyPress);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(170, 66);
            this.txtFirstName.MaxLength = 10;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 27);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 104);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(96, 18);
            this.lblLastName.TabIndex = 27;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 69);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 18);
            this.lblFirstName.TabIndex = 26;
            this.lblFirstName.Text = "First Name";
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.AutoSize = true;
            this.lblCustomerList.Location = new System.Drawing.Point(6, 36);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(111, 18);
            this.lblCustomerList.TabIndex = 25;
            this.lblCustomerList.Text = "Customer ID";
            // 
            // lblPercentageIcon2
            // 
            this.lblPercentageIcon2.AutoSize = true;
            this.lblPercentageIcon2.Location = new System.Drawing.Point(252, 267);
            this.lblPercentageIcon2.Name = "lblPercentageIcon2";
            this.lblPercentageIcon2.Size = new System.Drawing.Size(25, 18);
            this.lblPercentageIcon2.TabIndex = 21;
            this.lblPercentageIcon2.Text = "%";
            // 
            // lblSpecialOffer
            // 
            this.lblSpecialOffer.AutoSize = true;
            this.lblSpecialOffer.Location = new System.Drawing.Point(6, 301);
            this.lblSpecialOffer.Name = "lblSpecialOffer";
            this.lblSpecialOffer.Size = new System.Drawing.Size(113, 18);
            this.lblSpecialOffer.TabIndex = 14;
            this.lblSpecialOffer.Text = "Special Offer";
            // 
            // txtSpecialOffer
            // 
            this.txtSpecialOffer.Location = new System.Drawing.Point(170, 297);
            this.txtSpecialOffer.MaxLength = 2;
            this.txtSpecialOffer.Name = "txtSpecialOffer";
            this.txtSpecialOffer.Size = new System.Drawing.Size(80, 27);
            this.txtSpecialOffer.TabIndex = 7;
            this.txtSpecialOffer.TextChanged += new System.EventHandler(this.txtSpecialOffer_TextChanged);
            this.txtSpecialOffer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSpecialOffer_KeyPress);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(6, 135);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(83, 18);
            this.lblCompany.TabIndex = 17;
            this.lblCompany.Text = "Company";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(6, 167);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(56, 18);
            this.lblModel.TabIndex = 18;
            this.lblModel.Text = "Model";
            // 
            // txtCarOrdered
            // 
            this.txtCarOrdered.Location = new System.Drawing.Point(170, 231);
            this.txtCarOrdered.MaxLength = 2;
            this.txtCarOrdered.Name = "txtCarOrdered";
            this.txtCarOrdered.Size = new System.Drawing.Size(80, 27);
            this.txtCarOrdered.TabIndex = 5;
            this.txtCarOrdered.TextChanged += new System.EventHandler(this.txtCarOrdered_TextChanged);
            this.txtCarOrdered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarOrdered_KeyPress);
            // 
            // lblCarsOrdered
            // 
            this.lblCarsOrdered.AutoSize = true;
            this.lblCarsOrdered.Location = new System.Drawing.Point(6, 234);
            this.lblCarsOrdered.Name = "lblCarsOrdered";
            this.lblCarsOrdered.Size = new System.Drawing.Size(106, 18);
            this.lblCarsOrdered.TabIndex = 13;
            this.lblCarsOrdered.Text = "Car Ordered";
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Location = new System.Drawing.Point(170, 396);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(100, 28);
            this.btnSale.TabIndex = 9;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelSale.ForeColor = System.Drawing.Color.White;
            this.btnCancelSale.Location = new System.Drawing.Point(276, 396);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(100, 28);
            this.btnCancelSale.TabIndex = 10;
            this.btnCancelSale.Text = "Cancel";
            this.btnCancelSale.UseVisualStyleBackColor = false;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // frmSale
            // 
            this.AcceptButton = this.btnSale;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 454);
            this.ControlBox = false;
            this.Controls.Add(this.gbSaleForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSale";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.gbSaleForm.ResumeLayout(false);
            this.gbSaleForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSaleForm;
        private System.Windows.Forms.TextBox txtCarOrdered;
        private System.Windows.Forms.Label lblCarsOrdered;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblSpecialOffer;
        private System.Windows.Forms.TextBox txtSpecialOffer;
        private System.Windows.Forms.Label lblPercentageIcon2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblCustomerList;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCarPrice;
        private System.Windows.Forms.TextBox txtCarPrice;
        private System.Windows.Forms.Label lblPercentageIcon1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label lblDollarIcon2;
        private System.Windows.Forms.Label lblDollarIcon1;
        private System.Windows.Forms.Button btnDone;
    }
}