﻿namespace My_Garage
{
    partial class frmServices
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
            this.lblForMOT = new System.Windows.Forms.Label();
            this.cmbMOTDuration = new System.Windows.Forms.ComboBox();
            this.lblForRT = new System.Windows.Forms.Label();
            this.cmbRTDuration = new System.Windows.Forms.ComboBox();
            this.dateTimeMOT = new System.Windows.Forms.DateTimePicker();
            this.dateTimeRoadTax = new System.Windows.Forms.DateTimePicker();
            this.lblMOT = new System.Windows.Forms.Label();
            this.lblRoadTax = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chkRoadTax = new System.Windows.Forms.CheckBox();
            this.chkMOT = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblForMOT
            // 
            this.lblForMOT.AutoSize = true;
            this.lblForMOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblForMOT.Location = new System.Drawing.Point(433, 142);
            this.lblForMOT.Name = "lblForMOT";
            this.lblForMOT.Size = new System.Drawing.Size(29, 20);
            this.lblForMOT.TabIndex = 24;
            this.lblForMOT.Text = "for";
            // 
            // cmbMOTDuration
            // 
            this.cmbMOTDuration.FormattingEnabled = true;
            this.cmbMOTDuration.Items.AddRange(new object[] {
            "1 Year",
            "2 Years"});
            this.cmbMOTDuration.Location = new System.Drawing.Point(468, 142);
            this.cmbMOTDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMOTDuration.Name = "cmbMOTDuration";
            this.cmbMOTDuration.Size = new System.Drawing.Size(121, 24);
            this.cmbMOTDuration.TabIndex = 5;
            // 
            // lblForRT
            // 
            this.lblForRT.AutoSize = true;
            this.lblForRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblForRT.Location = new System.Drawing.Point(433, 79);
            this.lblForRT.Name = "lblForRT";
            this.lblForRT.Size = new System.Drawing.Size(29, 20);
            this.lblForRT.TabIndex = 23;
            this.lblForRT.Text = "for";
            // 
            // cmbRTDuration
            // 
            this.cmbRTDuration.FormattingEnabled = true;
            this.cmbRTDuration.Items.AddRange(new object[] {
            "3 Months",
            "6 Months",
            "9 Months",
            "12 Months"});
            this.cmbRTDuration.Location = new System.Drawing.Point(468, 78);
            this.cmbRTDuration.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRTDuration.Name = "cmbRTDuration";
            this.cmbRTDuration.Size = new System.Drawing.Size(121, 24);
            this.cmbRTDuration.TabIndex = 3;
            // 
            // dateTimeMOT
            // 
            this.dateTimeMOT.Location = new System.Drawing.Point(161, 144);
            this.dateTimeMOT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeMOT.Name = "dateTimeMOT";
            this.dateTimeMOT.Size = new System.Drawing.Size(265, 22);
            this.dateTimeMOT.TabIndex = 4;
            // 
            // dateTimeRoadTax
            // 
            this.dateTimeRoadTax.Location = new System.Drawing.Point(161, 79);
            this.dateTimeRoadTax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeRoadTax.Name = "dateTimeRoadTax";
            this.dateTimeRoadTax.Size = new System.Drawing.Size(265, 22);
            this.dateTimeRoadTax.TabIndex = 2;
            // 
            // lblMOT
            // 
            this.lblMOT.AutoSize = true;
            this.lblMOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOT.Location = new System.Drawing.Point(15, 146);
            this.lblMOT.Name = "lblMOT";
            this.lblMOT.Size = new System.Drawing.Size(51, 20);
            this.lblMOT.TabIndex = 22;
            this.lblMOT.Text = "MOT:";
            // 
            // lblRoadTax
            // 
            this.lblRoadTax.AutoSize = true;
            this.lblRoadTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoadTax.Location = new System.Drawing.Point(15, 79);
            this.lblRoadTax.Name = "lblRoadTax";
            this.lblRoadTax.Size = new System.Drawing.Size(130, 20);
            this.lblRoadTax.TabIndex = 19;
            this.lblRoadTax.Text = "Adia Kikloforias:";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(12, 11);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(83, 20);
            this.lblCar.TabIndex = 25;
            this.lblCar.Text = "Aftokinito:";
            // 
            // cmbCar
            // 
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Location = new System.Drawing.Point(161, 11);
            this.cmbCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(265, 24);
            this.cmbCar.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(12, 183);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegister.Location = new System.Drawing.Point(444, 183);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(145, 34);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chkRoadTax
            // 
            this.chkRoadTax.AutoSize = true;
            this.chkRoadTax.Location = new System.Drawing.Point(16, 47);
            this.chkRoadTax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRoadTax.Name = "chkRoadTax";
            this.chkRoadTax.Size = new System.Drawing.Size(124, 21);
            this.chkRoadTax.TabIndex = 26;
            this.chkRoadTax.Text = "Add Road Tax:";
            this.chkRoadTax.UseVisualStyleBackColor = true;
            this.chkRoadTax.CheckedChanged += new System.EventHandler(this.chkRoadTax_CheckedChanged);
            // 
            // chkMOT
            // 
            this.chkMOT.AutoSize = true;
            this.chkMOT.Location = new System.Drawing.Point(16, 113);
            this.chkMOT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkMOT.Name = "chkMOT";
            this.chkMOT.Size = new System.Drawing.Size(94, 21);
            this.chkMOT.TabIndex = 27;
            this.chkMOT.Text = "Add MOT:";
            this.chkMOT.UseVisualStyleBackColor = true;
            this.chkMOT.CheckedChanged += new System.EventHandler(this.chkMOT_CheckedChanged);
            // 
            // frmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 231);
            this.Controls.Add(this.chkMOT);
            this.Controls.Add(this.chkRoadTax);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblForMOT);
            this.Controls.Add(this.cmbMOTDuration);
            this.Controls.Add(this.lblForRT);
            this.Controls.Add(this.cmbRTDuration);
            this.Controls.Add(this.dateTimeMOT);
            this.Controls.Add(this.dateTimeRoadTax);
            this.Controls.Add(this.lblMOT);
            this.Controls.Add(this.lblRoadTax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServices_FormClosing);
            this.Load += new System.EventHandler(this.frmServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForMOT;
        private System.Windows.Forms.ComboBox cmbMOTDuration;
        private System.Windows.Forms.Label lblForRT;
        private System.Windows.Forms.ComboBox cmbRTDuration;
        private System.Windows.Forms.DateTimePicker dateTimeMOT;
        private System.Windows.Forms.DateTimePicker dateTimeRoadTax;
        private System.Windows.Forms.Label lblMOT;
        private System.Windows.Forms.Label lblRoadTax;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chkRoadTax;
        private System.Windows.Forms.CheckBox chkMOT;
    }
}