namespace prjcsm
{
    partial class frmEmployeeManagement
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtEmployeePassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmployeeUsername = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.gbEmployeeManagement = new System.Windows.Forms.GroupBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtEmployeeContact = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.cmbEmployeeType = new System.Windows.Forms.ComboBox();
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.btnModifyEmployee = new System.Windows.Forms.Button();
            this.btnCancelEmployeeBox = new System.Windows.Forms.Button();
            this.txtEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.txtEmployeeLastName = new System.Windows.Forms.TextBox();
            this.gbEmployeeManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(6, 46);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(98, 18);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Location = new System.Drawing.Point(175, 76);
            this.txtEmployeePassword.MaxLength = 15;
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.PasswordChar = '*';
            this.txtEmployeePassword.Size = new System.Drawing.Size(150, 27);
            this.txtEmployeePassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(6, 79);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(85, 18);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtEmployeeUsername
            // 
            this.txtEmployeeUsername.Location = new System.Drawing.Point(175, 43);
            this.txtEmployeeUsername.MaxLength = 10;
            this.txtEmployeeUsername.Name = "txtEmployeeUsername";
            this.txtEmployeeUsername.Size = new System.Drawing.Size(150, 27);
            this.txtEmployeeUsername.TabIndex = 0;
            this.txtEmployeeUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeUsername_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 112);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(97, 18);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(6, 145);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(96, 18);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 210);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(73, 18);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // gbEmployeeManagement
            // 
            this.gbEmployeeManagement.Controls.Add(this.lblContact);
            this.gbEmployeeManagement.Controls.Add(this.txtEmployeeContact);
            this.gbEmployeeManagement.Controls.Add(this.txtEmployeeAddress);
            this.gbEmployeeManagement.Controls.Add(this.cmbEmployeeType);
            this.gbEmployeeManagement.Controls.Add(this.lblEmployeeType);
            this.gbEmployeeManagement.Controls.Add(this.btnModifyEmployee);
            this.gbEmployeeManagement.Controls.Add(this.btnCancelEmployeeBox);
            this.gbEmployeeManagement.Controls.Add(this.txtEmployeeFirstName);
            this.gbEmployeeManagement.Controls.Add(this.txtEmployeeLastName);
            this.gbEmployeeManagement.Controls.Add(this.lblUserName);
            this.gbEmployeeManagement.Controls.Add(this.txtEmployeePassword);
            this.gbEmployeeManagement.Controls.Add(this.lblPassword);
            this.gbEmployeeManagement.Controls.Add(this.txtEmployeeUsername);
            this.gbEmployeeManagement.Controls.Add(this.lblFirstName);
            this.gbEmployeeManagement.Controls.Add(this.lblLastName);
            this.gbEmployeeManagement.Controls.Add(this.lblAddress);
            this.gbEmployeeManagement.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployeeManagement.Location = new System.Drawing.Point(12, 12);
            this.gbEmployeeManagement.Name = "gbEmployeeManagement";
            this.gbEmployeeManagement.Size = new System.Drawing.Size(340, 350);
            this.gbEmployeeManagement.TabIndex = 11;
            this.gbEmployeeManagement.TabStop = false;
            this.gbEmployeeManagement.Text = "Employee Management";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(6, 276);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(71, 18);
            this.lblContact.TabIndex = 17;
            this.lblContact.Text = "Contact";
            // 
            // txtEmployeeContact
            // 
            this.txtEmployeeContact.Location = new System.Drawing.Point(175, 273);
            this.txtEmployeeContact.MaxLength = 9;
            this.txtEmployeeContact.Name = "txtEmployeeContact";
            this.txtEmployeeContact.Size = new System.Drawing.Size(150, 27);
            this.txtEmployeeContact.TabIndex = 6;
            this.txtEmployeeContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeContact_KeyPress);
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Location = new System.Drawing.Point(175, 207);
            this.txtEmployeeAddress.MaxLength = 50;
            this.txtEmployeeAddress.Multiline = true;
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(150, 60);
            this.txtEmployeeAddress.TabIndex = 5;
            // 
            // cmbEmployeeType
            // 
            this.cmbEmployeeType.FormattingEnabled = true;
            this.cmbEmployeeType.Items.AddRange(new object[] {
            "Select",
            "Manager",
            "Salesman"});
            this.cmbEmployeeType.Location = new System.Drawing.Point(175, 175);
            this.cmbEmployeeType.Name = "cmbEmployeeType";
            this.cmbEmployeeType.Size = new System.Drawing.Size(150, 26);
            this.cmbEmployeeType.TabIndex = 4;
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.Location = new System.Drawing.Point(6, 178);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(130, 18);
            this.lblEmployeeType.TabIndex = 13;
            this.lblEmployeeType.Text = "Employee Type";
            // 
            // btnModifyEmployee
            // 
            this.btnModifyEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnModifyEmployee.ForeColor = System.Drawing.Color.White;
            this.btnModifyEmployee.Location = new System.Drawing.Point(119, 316);
            this.btnModifyEmployee.Name = "btnModifyEmployee";
            this.btnModifyEmployee.Size = new System.Drawing.Size(100, 28);
            this.btnModifyEmployee.TabIndex = 7;
            this.btnModifyEmployee.Text = "Modify";
            this.btnModifyEmployee.UseVisualStyleBackColor = false;
            this.btnModifyEmployee.Click += new System.EventHandler(this.btnModifyEmployee_Click);
            // 
            // btnCancelEmployeeBox
            // 
            this.btnCancelEmployeeBox.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelEmployeeBox.ForeColor = System.Drawing.Color.White;
            this.btnCancelEmployeeBox.Location = new System.Drawing.Point(225, 316);
            this.btnCancelEmployeeBox.Name = "btnCancelEmployeeBox";
            this.btnCancelEmployeeBox.Size = new System.Drawing.Size(100, 28);
            this.btnCancelEmployeeBox.TabIndex = 8;
            this.btnCancelEmployeeBox.Text = "Cancel";
            this.btnCancelEmployeeBox.UseVisualStyleBackColor = false;
            this.btnCancelEmployeeBox.Click += new System.EventHandler(this.btnCancelEmployeeBox_Click);
            // 
            // txtEmployeeFirstName
            // 
            this.txtEmployeeFirstName.Location = new System.Drawing.Point(175, 109);
            this.txtEmployeeFirstName.MaxLength = 10;
            this.txtEmployeeFirstName.Name = "txtEmployeeFirstName";
            this.txtEmployeeFirstName.Size = new System.Drawing.Size(150, 27);
            this.txtEmployeeFirstName.TabIndex = 2;
            this.txtEmployeeFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeFirstName_KeyPress);
            // 
            // txtEmployeeLastName
            // 
            this.txtEmployeeLastName.Location = new System.Drawing.Point(175, 142);
            this.txtEmployeeLastName.MaxLength = 10;
            this.txtEmployeeLastName.Name = "txtEmployeeLastName";
            this.txtEmployeeLastName.Size = new System.Drawing.Size(150, 27);
            this.txtEmployeeLastName.TabIndex = 3;
            this.txtEmployeeLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployeeLastName_KeyPress);
            // 
            // frmEmployeeManagement
            // 
            this.AcceptButton = this.btnModifyEmployee;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 374);
            this.ControlBox = false;
            this.Controls.Add(this.gbEmployeeManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmEmployeeManagement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.gbEmployeeManagement.ResumeLayout(false);
            this.gbEmployeeManagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtEmployeePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmployeeUsername;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox gbEmployeeManagement;
        private System.Windows.Forms.Button btnModifyEmployee;
        private System.Windows.Forms.Button btnCancelEmployeeBox;
        private System.Windows.Forms.TextBox txtEmployeeFirstName;
        private System.Windows.Forms.TextBox txtEmployeeLastName;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.ComboBox cmbEmployeeType;
        private System.Windows.Forms.Label lblEmployeeType;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtEmployeeContact;
    }
}