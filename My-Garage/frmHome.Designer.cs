namespace My_Garage
{
    partial class frmHome
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
            this.lblMyGarage = new System.Windows.Forms.Label();
            this.btnCarRegistration = new System.Windows.Forms.Button();
            this.btnCustomerRegistration = new System.Windows.Forms.Button();
            this.btnCarRental = new System.Windows.Forms.Button();
            this.btnReminders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMyGarage
            // 
            this.lblMyGarage.AutoSize = true;
            this.lblMyGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyGarage.Location = new System.Drawing.Point(12, 9);
            this.lblMyGarage.Name = "lblMyGarage";
            this.lblMyGarage.Size = new System.Drawing.Size(147, 31);
            this.lblMyGarage.TabIndex = 0;
            this.lblMyGarage.Text = "My Garage";
            // 
            // btnCarRegistration
            // 
            this.btnCarRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCarRegistration.Location = new System.Drawing.Point(12, 60);
            this.btnCarRegistration.Name = "btnCarRegistration";
            this.btnCarRegistration.Size = new System.Drawing.Size(328, 55);
            this.btnCarRegistration.TabIndex = 1;
            this.btnCarRegistration.Text = "Car Registration";
            this.btnCarRegistration.UseVisualStyleBackColor = true;
            this.btnCarRegistration.Click += new System.EventHandler(this.btnCarRegistration_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCustomerRegistration.Location = new System.Drawing.Point(12, 140);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Size = new System.Drawing.Size(328, 55);
            this.btnCustomerRegistration.TabIndex = 2;
            this.btnCustomerRegistration.Text = "Customer Registration";
            this.btnCustomerRegistration.UseVisualStyleBackColor = true;
            this.btnCustomerRegistration.Click += new System.EventHandler(this.btnCustomerRegistration_Click);
            // 
            // btnCarRental
            // 
            this.btnCarRental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCarRental.Location = new System.Drawing.Point(12, 220);
            this.btnCarRental.Name = "btnCarRental";
            this.btnCarRental.Size = new System.Drawing.Size(328, 55);
            this.btnCarRental.TabIndex = 3;
            this.btnCarRental.Text = "Car Rental";
            this.btnCarRental.UseVisualStyleBackColor = true;
            this.btnCarRental.Click += new System.EventHandler(this.btnCarRental_Click);
            // 
            // btnReminders
            // 
            this.btnReminders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReminders.Location = new System.Drawing.Point(12, 300);
            this.btnReminders.Name = "btnReminders";
            this.btnReminders.Size = new System.Drawing.Size(328, 55);
            this.btnReminders.TabIndex = 4;
            this.btnReminders.Text = "Reminders";
            this.btnReminders.UseVisualStyleBackColor = true;
            this.btnReminders.Click += new System.EventHandler(this.btnReminders_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 381);
            this.Controls.Add(this.btnReminders);
            this.Controls.Add(this.btnCarRental);
            this.Controls.Add(this.btnCustomerRegistration);
            this.Controls.Add(this.btnCarRegistration);
            this.Controls.Add(this.lblMyGarage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHome_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyGarage;
        private System.Windows.Forms.Button btnCarRegistration;
        private System.Windows.Forms.Button btnCustomerRegistration;
        private System.Windows.Forms.Button btnCarRental;
        private System.Windows.Forms.Button btnReminders;
    }
}

