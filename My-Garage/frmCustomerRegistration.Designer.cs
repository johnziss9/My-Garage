﻿namespace My_Garage
{
    partial class frmCustomerRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRegistration));
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFirstName.Location = new System.Drawing.Point(89, 10);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(156, 23);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(9, 12);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(55, 17);
            this.lblFirstName.TabIndex = 16;
            this.lblFirstName.Text = "Όνομα:";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLastName.Location = new System.Drawing.Point(89, 42);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(156, 23);
            this.txtLastName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(9, 45);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 17);
            this.lblLastName.TabIndex = 18;
            this.lblLastName.Text = "Επώνυμο:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAddress.Location = new System.Drawing.Point(89, 75);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(156, 23);
            this.txtAddress.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(9, 77);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(78, 17);
            this.lblAddress.TabIndex = 20;
            this.lblAddress.Text = "Διεύθυνση:";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPhoneNo.Location = new System.Drawing.Point(89, 107);
            this.txtPhoneNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(156, 23);
            this.txtPhoneNo.TabIndex = 4;
            this.txtPhoneNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNo_KeyPress);
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNo.Location = new System.Drawing.Point(9, 110);
            this.lblPhoneNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(76, 17);
            this.lblPhoneNo.TabIndex = 33;
            this.lblPhoneNo.Text = "Τηλέφωνο:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(9, 139);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Ακύρωση";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegister.Location = new System.Drawing.Point(136, 139);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 28);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Εγγραφή";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // frmCustomerRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmCustomerRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Εγγραφή Πελάτη";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomerRegistration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
    }
}