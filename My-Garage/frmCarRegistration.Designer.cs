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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarRegistration));
            this.lblCarMake = new System.Windows.Forms.Label();
            this.lblNumberPlate = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtVNumber = new System.Windows.Forms.TextBox();
            this.lblVNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarMake.Location = new System.Drawing.Point(9, 12);
            this.lblCarMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(54, 17);
            this.lblCarMake.TabIndex = 2;
            this.lblCarMake.Text = "Μάρκα:";
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberPlate.Location = new System.Drawing.Point(9, 76);
            this.lblNumberPlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(101, 17);
            this.lblNumberPlate.TabIndex = 6;
            this.lblNumberPlate.Text = "Αρ. Εγγραφής:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarModel.Location = new System.Drawing.Point(9, 45);
            this.lblCarModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(67, 17);
            this.lblCarModel.TabIndex = 7;
            this.lblCarModel.Text = "Μοντέλο:";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNumberPlate.Location = new System.Drawing.Point(114, 76);
            this.txtNumberPlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(200, 23);
            this.txtNumberPlate.TabIndex = 3;
            this.txtNumberPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberPlate_KeyPress);
            // 
            // txtCarModel
            // 
            this.txtCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCarModel.Location = new System.Drawing.Point(114, 44);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(200, 23);
            this.txtCarModel.TabIndex = 2;
            this.txtCarModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarModel_KeyPress);
            // 
            // txtCarMake
            // 
            this.txtCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCarMake.Location = new System.Drawing.Point(114, 12);
            this.txtCarMake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(200, 23);
            this.txtCarMake.TabIndex = 1;
            this.txtCarMake.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCarMake_KeyPress);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegister.Location = new System.Drawing.Point(205, 143);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 28);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Εγγραφή";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(11, 143);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 28);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Ακύρωση";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtVNumber
            // 
            this.txtVNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtVNumber.Location = new System.Drawing.Point(114, 108);
            this.txtVNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtVNumber.Name = "txtVNumber";
            this.txtVNumber.Size = new System.Drawing.Size(200, 23);
            this.txtVNumber.TabIndex = 4;
            // 
            // lblVNumber
            // 
            this.lblVNumber.AutoSize = true;
            this.lblVNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVNumber.Location = new System.Drawing.Point(9, 109);
            this.lblVNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVNumber.Name = "lblVNumber";
            this.lblVNumber.Size = new System.Drawing.Size(92, 17);
            this.lblVNumber.TabIndex = 9;
            this.lblVNumber.Text = "Αρ. Πλαισίου:";
            // 
            // frmCarRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 182);
            this.Controls.Add(this.txtVNumber);
            this.Controls.Add(this.lblVNumber);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtCarMake);
            this.Controls.Add(this.txtCarModel);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.lblCarModel);
            this.Controls.Add(this.lblNumberPlate);
            this.Controls.Add(this.lblCarMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmCarRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Εγγραφή Αυτοκινήτου";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCarRegistration_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.Label lblNumberPlate;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtVNumber;
        private System.Windows.Forms.Label lblVNumber;
    }
}