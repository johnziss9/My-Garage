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
            this.btnNotifications = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMyGarage
            // 
            this.lblMyGarage.AutoSize = true;
            this.lblMyGarage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyGarage.Location = new System.Drawing.Point(91, 32);
            this.lblMyGarage.Name = "lblMyGarage";
            this.lblMyGarage.Size = new System.Drawing.Size(156, 31);
            this.lblMyGarage.TabIndex = 0;
            this.lblMyGarage.Text = "My Garage";
            // 
            // btnCarRegistration
            // 
            this.btnCarRegistration.Location = new System.Drawing.Point(70, 91);
            this.btnCarRegistration.Name = "btnCarRegistration";
            this.btnCarRegistration.Size = new System.Drawing.Size(212, 55);
            this.btnCarRegistration.TabIndex = 1;
            this.btnCarRegistration.Text = "Car Registration";
            this.btnCarRegistration.UseVisualStyleBackColor = true;
            this.btnCarRegistration.Click += new System.EventHandler(this.btnCarRegistration_Click);
            // 
            // btnCustomerRegistration
            // 
            this.btnCustomerRegistration.Location = new System.Drawing.Point(70, 179);
            this.btnCustomerRegistration.Name = "btnCustomerRegistration";
            this.btnCustomerRegistration.Size = new System.Drawing.Size(212, 55);
            this.btnCustomerRegistration.TabIndex = 2;
            this.btnCustomerRegistration.Text = "Customer Registration";
            this.btnCustomerRegistration.UseVisualStyleBackColor = true;
            // 
            // btnCarRental
            // 
            this.btnCarRental.Location = new System.Drawing.Point(70, 265);
            this.btnCarRental.Name = "btnCarRental";
            this.btnCarRental.Size = new System.Drawing.Size(212, 55);
            this.btnCarRental.TabIndex = 3;
            this.btnCarRental.Text = "Car Rental";
            this.btnCarRental.UseVisualStyleBackColor = true;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Location = new System.Drawing.Point(70, 352);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(212, 55);
            this.btnNotifications.TabIndex = 4;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 450);
            this.Controls.Add(this.btnNotifications);
            this.Controls.Add(this.btnCarRental);
            this.Controls.Add(this.btnCustomerRegistration);
            this.Controls.Add(this.btnCarRegistration);
            this.Controls.Add(this.lblMyGarage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyGarage;
        private System.Windows.Forms.Button btnCarRegistration;
        private System.Windows.Forms.Button btnCustomerRegistration;
        private System.Windows.Forms.Button btnCarRental;
        private System.Windows.Forms.Button btnNotifications;
    }
}

