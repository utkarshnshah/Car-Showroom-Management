namespace prjcsm
{
    partial class frmCustomerManagement
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
            this.txtCustomerContact = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCarsPurchased = new System.Windows.Forms.Label();
            this.btnModifyCustomer = new System.Windows.Forms.Button();
            this.btnCancelCustomerBox = new System.Windows.Forms.Button();
            this.txtCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txtCustomerLastName = new System.Windows.Forms.TextBox();
            this.lblLicenceNo = new System.Windows.Forms.Label();
            this.txtCarPurchased = new System.Windows.Forms.TextBox();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtCustomerLicenceNo = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gbCustomerManagement = new System.Windows.Forms.GroupBox();
            this.gbCustomerManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerContact
            // 
            this.txtCustomerContact.Location = new System.Drawing.Point(180, 208);
            this.txtCustomerContact.MaxLength = 9;
            this.txtCustomerContact.Name = "txtCustomerContact";
            this.txtCustomerContact.Size = new System.Drawing.Size(150, 27);
            this.txtCustomerContact.TabIndex = 4;
            this.txtCustomerContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerContact_KeyPress);
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Location = new System.Drawing.Point(180, 142);
            this.txtCustomerAddress.MaxLength = 100;
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(150, 60);
            this.txtCustomerAddress.TabIndex = 3;
            // 
            // lblCarsPurchased
            // 
            this.lblCarsPurchased.AutoSize = true;
            this.lblCarsPurchased.Location = new System.Drawing.Point(6, 244);
            this.lblCarsPurchased.Name = "lblCarsPurchased";
            this.lblCarsPurchased.Size = new System.Drawing.Size(124, 18);
            this.lblCarsPurchased.TabIndex = 13;
            this.lblCarsPurchased.Text = "Car Purchased";
            // 
            // btnModifyCustomer
            // 
            this.btnModifyCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifyCustomer.ForeColor = System.Drawing.Color.White;
            this.btnModifyCustomer.Location = new System.Drawing.Point(124, 311);
            this.btnModifyCustomer.Name = "btnModifyCustomer";
            this.btnModifyCustomer.Size = new System.Drawing.Size(100, 28);
            this.btnModifyCustomer.TabIndex = 6;
            this.btnModifyCustomer.Text = "Modify";
            this.btnModifyCustomer.UseVisualStyleBackColor = false;
            this.btnModifyCustomer.Click += new System.EventHandler(this.btnModifyCustomer_Click);
            // 
            // btnCancelCustomerBox
            // 
            this.btnCancelCustomerBox.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelCustomerBox.ForeColor = System.Drawing.Color.White;
            this.btnCancelCustomerBox.Location = new System.Drawing.Point(230, 311);
            this.btnCancelCustomerBox.Name = "btnCancelCustomerBox";
            this.btnCancelCustomerBox.Size = new System.Drawing.Size(100, 28);
            this.btnCancelCustomerBox.TabIndex = 7;
            this.btnCancelCustomerBox.Text = "Cancel";
            this.btnCancelCustomerBox.UseVisualStyleBackColor = false;
            this.btnCancelCustomerBox.Click += new System.EventHandler(this.btnCancelCustomerBox_Click);
            // 
            // txtCustomerFirstName
            // 
            this.txtCustomerFirstName.Location = new System.Drawing.Point(180, 43);
            this.txtCustomerFirstName.MaxLength = 10;
            this.txtCustomerFirstName.Name = "txtCustomerFirstName";
            this.txtCustomerFirstName.Size = new System.Drawing.Size(150, 27);
            this.txtCustomerFirstName.TabIndex = 0;
            this.txtCustomerFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerFirstName_KeyPress);
            // 
            // txtCustomerLastName
            // 
            this.txtCustomerLastName.Location = new System.Drawing.Point(180, 76);
            this.txtCustomerLastName.MaxLength = 10;
            this.txtCustomerLastName.Name = "txtCustomerLastName";
            this.txtCustomerLastName.Size = new System.Drawing.Size(150, 27);
            this.txtCustomerLastName.TabIndex = 1;
            this.txtCustomerLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerLastName_KeyPress);
            // 
            // lblLicenceNo
            // 
            this.lblLicenceNo.AutoSize = true;
            this.lblLicenceNo.Location = new System.Drawing.Point(6, 112);
            this.lblLicenceNo.Name = "lblLicenceNo";
            this.lblLicenceNo.Size = new System.Drawing.Size(137, 18);
            this.lblLicenceNo.TabIndex = 0;
            this.lblLicenceNo.Text = "Licence Number";
            // 
            // txtCarPurchased
            // 
            this.txtCarPurchased.Location = new System.Drawing.Point(180, 241);
            this.txtCarPurchased.MaxLength = 2;
            this.txtCarPurchased.Name = "txtCarPurchased";
            this.txtCarPurchased.ReadOnly = true;
            this.txtCarPurchased.Size = new System.Drawing.Size(150, 27);
            this.txtCarPurchased.TabIndex = 5;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(6, 211);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(71, 18);
            this.lblContactNo.TabIndex = 1;
            this.lblContactNo.Text = "Contact";
            // 
            // txtCustomerLicenceNo
            // 
            this.txtCustomerLicenceNo.Location = new System.Drawing.Point(180, 109);
            this.txtCustomerLicenceNo.MaxLength = 9;
            this.txtCustomerLicenceNo.Name = "txtCustomerLicenceNo";
            this.txtCustomerLicenceNo.Size = new System.Drawing.Size(150, 27);
            this.txtCustomerLicenceNo.TabIndex = 2;
            this.txtCustomerLicenceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerLicenceNo_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 46);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 18);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 79);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(96, 18);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 145);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(73, 18);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // gbCustomerManagement
            // 
            this.gbCustomerManagement.Controls.Add(this.txtCustomerLicenceNo);
            this.gbCustomerManagement.Controls.Add(this.txtCarPurchased);
            this.gbCustomerManagement.Controls.Add(this.lblCarsPurchased);
            this.gbCustomerManagement.Controls.Add(this.lblContactNo);
            this.gbCustomerManagement.Controls.Add(this.txtCustomerContact);
            this.gbCustomerManagement.Controls.Add(this.txtCustomerAddress);
            this.gbCustomerManagement.Controls.Add(this.lblLicenceNo);
            this.gbCustomerManagement.Controls.Add(this.btnModifyCustomer);
            this.gbCustomerManagement.Controls.Add(this.btnCancelCustomerBox);
            this.gbCustomerManagement.Controls.Add(this.txtCustomerFirstName);
            this.gbCustomerManagement.Controls.Add(this.txtCustomerLastName);
            this.gbCustomerManagement.Controls.Add(this.lblFirstName);
            this.gbCustomerManagement.Controls.Add(this.lblLastName);
            this.gbCustomerManagement.Controls.Add(this.lblAddress);
            this.gbCustomerManagement.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCustomerManagement.Location = new System.Drawing.Point(12, 12);
            this.gbCustomerManagement.Name = "gbCustomerManagement";
            this.gbCustomerManagement.Size = new System.Drawing.Size(350, 345);
            this.gbCustomerManagement.TabIndex = 12;
            this.gbCustomerManagement.TabStop = false;
            this.gbCustomerManagement.Text = "Customer Management";
            // 
            // frmCustomerManagement
            // 
            this.AcceptButton = this.btnModifyCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 369);
            this.ControlBox = false;
            this.Controls.Add(this.gbCustomerManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmCustomerManagement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.gbCustomerManagement.ResumeLayout(false);
            this.gbCustomerManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCustomerContact;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label lblCarsPurchased;
        private System.Windows.Forms.Button btnModifyCustomer;
        private System.Windows.Forms.Button btnCancelCustomerBox;
        private System.Windows.Forms.TextBox txtCustomerFirstName;
        private System.Windows.Forms.TextBox txtCustomerLastName;
        private System.Windows.Forms.Label lblLicenceNo;
        private System.Windows.Forms.TextBox txtCarPurchased;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtCustomerLicenceNo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox gbCustomerManagement;
    }
}