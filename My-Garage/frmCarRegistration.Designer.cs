namespace My_Garage
{
    partial class frmCarRegistration
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
            this.lblCarMake = new System.Windows.Forms.Label();
            this.lblRoadTax = new System.Windows.Forms.Label();
            this.lblNumberPlate = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.lblMOT = new System.Windows.Forms.Label();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dateTimeRoadTax = new System.Windows.Forms.DateTimePicker();
            this.dateTimeMOT = new System.Windows.Forms.DateTimePicker();
            this.cmbRTDuration = new System.Windows.Forms.ComboBox();
            this.lblForRT = new System.Windows.Forms.Label();
            this.lblForMOT = new System.Windows.Forms.Label();
            this.cmbMOTDuration = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMake.Location = new System.Drawing.Point(12, 15);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(86, 20);
            this.lblCarMake.TabIndex = 2;
            this.lblCarMake.Text = "Car Make:";
            // 
            // lblRoadTax
            // 
            this.lblRoadTax.AutoSize = true;
            this.lblRoadTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoadTax.Location = new System.Drawing.Point(12, 135);
            this.lblRoadTax.Name = "lblRoadTax";
            this.lblRoadTax.Size = new System.Drawing.Size(130, 20);
            this.lblRoadTax.TabIndex = 5;
            this.lblRoadTax.Text = "Adia Kikloforias:";
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPlate.Location = new System.Drawing.Point(12, 95);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(116, 20);
            this.lblNumberPlate.TabIndex = 6;
            this.lblNumberPlate.Text = "Number Plate:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(12, 55);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(91, 20);
            this.lblCarModel.TabIndex = 7;
            this.lblCarModel.Text = "Car Model:";
            // 
            // lblMOT
            // 
            this.lblMOT.AutoSize = true;
            this.lblMOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOT.Location = new System.Drawing.Point(12, 175);
            this.lblMOT.Name = "lblMOT";
            this.lblMOT.Size = new System.Drawing.Size(51, 20);
            this.lblMOT.TabIndex = 9;
            this.lblMOT.Text = "MOT:";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumberPlate.Location = new System.Drawing.Point(163, 92);
            this.txtNumberPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(265, 26);
            this.txtNumberPlate.TabIndex = 3;
            // 
            // txtCarModel
            // 
            this.txtCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCarModel.Location = new System.Drawing.Point(163, 52);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(265, 26);
            this.txtCarModel.TabIndex = 2;
            // 
            // txtCarMake
            // 
            this.txtCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCarMake.Location = new System.Drawing.Point(163, 12);
            this.txtCarMake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(265, 26);
            this.txtCarMake.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegister.Location = new System.Drawing.Point(445, 211);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(145, 34);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(12, 211);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 34);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dateTimeRoadTax
            // 
            this.dateTimeRoadTax.Location = new System.Drawing.Point(161, 132);
            this.dateTimeRoadTax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeRoadTax.Name = "dateTimeRoadTax";
            this.dateTimeRoadTax.Size = new System.Drawing.Size(265, 22);
            this.dateTimeRoadTax.TabIndex = 10;
            // 
            // dateTimeMOT
            // 
            this.dateTimeMOT.Location = new System.Drawing.Point(161, 171);
            this.dateTimeMOT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeMOT.Name = "dateTimeMOT";
            this.dateTimeMOT.Size = new System.Drawing.Size(265, 22);
            this.dateTimeMOT.TabIndex = 11;
            // 
            // cmbRTDuration
            // 
            this.cmbRTDuration.FormattingEnabled = true;
            this.cmbRTDuration.Items.AddRange(new object[] {
            "3 Months",
            "6 Months",
            "9 Months",
            "12 Months"});
            this.cmbRTDuration.Location = new System.Drawing.Point(464, 132);
            this.cmbRTDuration.Name = "cmbRTDuration";
            this.cmbRTDuration.Size = new System.Drawing.Size(121, 24);
            this.cmbRTDuration.TabIndex = 13;
            // 
            // lblForRT
            // 
            this.lblForRT.AutoSize = true;
            this.lblForRT.Location = new System.Drawing.Point(433, 135);
            this.lblForRT.Name = "lblForRT";
            this.lblForRT.Size = new System.Drawing.Size(25, 17);
            this.lblForRT.TabIndex = 14;
            this.lblForRT.Text = "for";
            // 
            // lblForMOT
            // 
            this.lblForMOT.AutoSize = true;
            this.lblForMOT.Location = new System.Drawing.Point(433, 172);
            this.lblForMOT.Name = "lblForMOT";
            this.lblForMOT.Size = new System.Drawing.Size(25, 17);
            this.lblForMOT.TabIndex = 16;
            this.lblForMOT.Text = "for";
            // 
            // cmbMOTDuration
            // 
            this.cmbMOTDuration.FormattingEnabled = true;
            this.cmbMOTDuration.Items.AddRange(new object[] {
            "1 Year",
            "2 Years"});
            this.cmbMOTDuration.Location = new System.Drawing.Point(464, 169);
            this.cmbMOTDuration.Name = "cmbMOTDuration";
            this.cmbMOTDuration.Size = new System.Drawing.Size(121, 24);
            this.cmbMOTDuration.TabIndex = 15;
            // 
            // frmCarRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 259);
            this.Controls.Add(this.lblForMOT);
            this.Controls.Add(this.cmbMOTDuration);
            this.Controls.Add(this.lblForRT);
            this.Controls.Add(this.cmbRTDuration);
            this.Controls.Add(this.dateTimeMOT);
            this.Controls.Add(this.dateTimeRoadTax);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtCarMake);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.lblMOT);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblNumberPlate);
            this.Controls.Add(this.lblRoadTax);
            this.Controls.Add(this.lblCarMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmCarRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCarRegistration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.Label lblRoadTax;
        private System.Windows.Forms.Label lblNumberPlate;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.Label lblMOT;
        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dateTimeRoadTax;
        private System.Windows.Forms.DateTimePicker dateTimeMOT;
        private System.Windows.Forms.ComboBox cmbRTDuration;
        private System.Windows.Forms.Label lblForRT;
        private System.Windows.Forms.Label lblForMOT;
        private System.Windows.Forms.ComboBox cmbMOTDuration;
    }
}