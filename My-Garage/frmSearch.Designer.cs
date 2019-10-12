namespace My_Garage
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.txtSearchMake = new System.Windows.Forms.TextBox();
            this.lblSearchMake = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.radioNo = new System.Windows.Forms.RadioButton();
            this.lblCarCurrentlyRented = new System.Windows.Forms.Label();
            this.radioYes = new System.Windows.Forms.RadioButton();
            this.lblCarRentalDetails = new System.Windows.Forms.Label();
            this.txtMOTExpires = new System.Windows.Forms.TextBox();
            this.lblCarDetails = new System.Windows.Forms.Label();
            this.txtCarModel = new System.Windows.Forms.TextBox();
            this.lblMOTExpires = new System.Windows.Forms.Label();
            this.lblCarModel = new System.Windows.Forms.Label();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.txtRoadTaxExpires = new System.Windows.Forms.TextBox();
            this.lblNumberPlate = new System.Windows.Forms.Label();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.lblRoadTaxExpires = new System.Windows.Forms.Label();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.lblCarServices = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearchNumberPlate = new System.Windows.Forms.TextBox();
            this.lblSearchModel = new System.Windows.Forms.Label();
            this.txtSearchModel = new System.Windows.Forms.TextBox();
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchMake
            // 
            this.txtSearchMake.Location = new System.Drawing.Point(72, 15);
            this.txtSearchMake.Name = "txtSearchMake";
            this.txtSearchMake.Size = new System.Drawing.Size(152, 22);
            this.txtSearchMake.TabIndex = 0;
            // 
            // lblSearchMake
            // 
            this.lblSearchMake.AutoSize = true;
            this.lblSearchMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchMake.Location = new System.Drawing.Point(12, 15);
            this.lblSearchMake.Name = "lblSearchMake";
            this.lblSearchMake.Size = new System.Drawing.Size(54, 20);
            this.lblSearchMake.TabIndex = 1;
            this.lblSearchMake.Text = "Make:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCustomer);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.radioNo);
            this.panel1.Controls.Add(this.lblCarCurrentlyRented);
            this.panel1.Controls.Add(this.radioYes);
            this.panel1.Controls.Add(this.lblCarRentalDetails);
            this.panel1.Controls.Add(this.txtMOTExpires);
            this.panel1.Controls.Add(this.lblCarDetails);
            this.panel1.Controls.Add(this.txtCarModel);
            this.panel1.Controls.Add(this.lblMOTExpires);
            this.panel1.Controls.Add(this.lblCarModel);
            this.panel1.Controls.Add(this.txtNumberPlate);
            this.panel1.Controls.Add(this.txtRoadTaxExpires);
            this.panel1.Controls.Add(this.lblNumberPlate);
            this.panel1.Controls.Add(this.txtCarMake);
            this.panel1.Controls.Add(this.lblRoadTaxExpires);
            this.panel1.Controls.Add(this.lblCarMake);
            this.panel1.Controls.Add(this.lblCarServices);
            this.panel1.Location = new System.Drawing.Point(16, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 279);
            this.panel1.TabIndex = 2;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(138, 239);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(182, 22);
            this.txtFrom.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "From:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(500, 239);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(182, 22);
            this.txtTo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(348, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "To:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(138, 211);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(182, 22);
            this.txtCustomer.TabIndex = 19;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(16, 211);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(87, 20);
            this.lblCustomer.TabIndex = 18;
            this.lblCustomer.Text = "Customer:";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(269, 181);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(47, 21);
            this.radioNo.TabIndex = 17;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // lblCarCurrentlyRented
            // 
            this.lblCarCurrentlyRented.AutoSize = true;
            this.lblCarCurrentlyRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarCurrentlyRented.Location = new System.Drawing.Point(16, 180);
            this.lblCarCurrentlyRented.Name = "lblCarCurrentlyRented";
            this.lblCarCurrentlyRented.Size = new System.Drawing.Size(176, 20);
            this.lblCarCurrentlyRented.TabIndex = 16;
            this.lblCarCurrentlyRented.Text = "Car Currently Rented?";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(210, 181);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(53, 21);
            this.radioYes.TabIndex = 15;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // lblCarRentalDetails
            // 
            this.lblCarRentalDetails.AutoSize = true;
            this.lblCarRentalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblCarRentalDetails.Location = new System.Drawing.Point(16, 145);
            this.lblCarRentalDetails.Name = "lblCarRentalDetails";
            this.lblCarRentalDetails.Size = new System.Drawing.Size(152, 20);
            this.lblCarRentalDetails.TabIndex = 14;
            this.lblCarRentalDetails.Text = "Car Rental Details:";
            // 
            // txtMOTExpires
            // 
            this.txtMOTExpires.Location = new System.Drawing.Point(500, 79);
            this.txtMOTExpires.Name = "txtMOTExpires";
            this.txtMOTExpires.Size = new System.Drawing.Size(182, 22);
            this.txtMOTExpires.TabIndex = 13;
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblCarDetails.Location = new System.Drawing.Point(16, 14);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(99, 20);
            this.lblCarDetails.TabIndex = 8;
            this.lblCarDetails.Text = "Car Details:";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(138, 76);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(182, 22);
            this.txtCarModel.TabIndex = 7;
            // 
            // lblMOTExpires
            // 
            this.lblMOTExpires.AutoSize = true;
            this.lblMOTExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMOTExpires.Location = new System.Drawing.Point(348, 79);
            this.lblMOTExpires.Name = "lblMOTExpires";
            this.lblMOTExpires.Size = new System.Drawing.Size(112, 20);
            this.lblMOTExpires.TabIndex = 12;
            this.lblMOTExpires.Text = "MOT Expires:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarModel.Location = new System.Drawing.Point(16, 76);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(91, 20);
            this.lblCarModel.TabIndex = 6;
            this.lblCarModel.Text = "Car Model:";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Location = new System.Drawing.Point(138, 104);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(182, 22);
            this.txtNumberPlate.TabIndex = 5;
            // 
            // txtRoadTaxExpires
            // 
            this.txtRoadTaxExpires.Location = new System.Drawing.Point(500, 48);
            this.txtRoadTaxExpires.Name = "txtRoadTaxExpires";
            this.txtRoadTaxExpires.Size = new System.Drawing.Size(182, 22);
            this.txtRoadTaxExpires.TabIndex = 11;
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumberPlate.Location = new System.Drawing.Point(16, 104);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(116, 20);
            this.lblNumberPlate.TabIndex = 4;
            this.lblNumberPlate.Text = "Number Plate:";
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(138, 48);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(182, 22);
            this.txtCarMake.TabIndex = 3;
            // 
            // lblRoadTaxExpires
            // 
            this.lblRoadTaxExpires.AutoSize = true;
            this.lblRoadTaxExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRoadTaxExpires.Location = new System.Drawing.Point(348, 51);
            this.lblRoadTaxExpires.Name = "lblRoadTaxExpires";
            this.lblRoadTaxExpires.Size = new System.Drawing.Size(146, 20);
            this.lblRoadTaxExpires.TabIndex = 10;
            this.lblRoadTaxExpires.Text = "Road Tax Expires:";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarMake.Location = new System.Drawing.Point(16, 48);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(86, 20);
            this.lblCarMake.TabIndex = 2;
            this.lblCarMake.Text = "Car Make:";
            // 
            // lblCarServices
            // 
            this.lblCarServices.AutoSize = true;
            this.lblCarServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblCarServices.Location = new System.Drawing.Point(348, 14);
            this.lblCarServices.Name = "lblCarServices";
            this.lblCarServices.Size = new System.Drawing.Size(111, 20);
            this.lblCarServices.TabIndex = 9;
            this.lblCarServices.Text = "Car Services:";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDone.Location = new System.Drawing.Point(573, 707);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(145, 35);
            this.btnDone.TabIndex = 9;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(566, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(152, 30);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(487, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Numera:";
            // 
            // txtSearchNumberPlate
            // 
            this.txtSearchNumberPlate.Location = new System.Drawing.Point(566, 15);
            this.txtSearchNumberPlate.Name = "txtSearchNumberPlate";
            this.txtSearchNumberPlate.Size = new System.Drawing.Size(152, 22);
            this.txtSearchNumberPlate.TabIndex = 12;
            // 
            // lblSearchModel
            // 
            this.lblSearchModel.AutoSize = true;
            this.lblSearchModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchModel.Location = new System.Drawing.Point(247, 17);
            this.lblSearchModel.Name = "lblSearchModel";
            this.lblSearchModel.Size = new System.Drawing.Size(59, 20);
            this.lblSearchModel.TabIndex = 15;
            this.lblSearchModel.Text = "Model:";
            // 
            // txtSearchModel
            // 
            this.txtSearchModel.Location = new System.Drawing.Point(312, 15);
            this.txtSearchModel.Name = "txtSearchModel";
            this.txtSearchModel.Size = new System.Drawing.Size(152, 22);
            this.txtSearchModel.TabIndex = 14;
            // 
            // dataGridCars
            // 
            this.dataGridCars.AllowUserToAddRows = false;
            this.dataGridCars.AllowUserToDeleteRows = false;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(16, 81);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.ReadOnly = true;
            this.dataGridCars.RowTemplate.Height = 24;
            this.dataGridCars.Size = new System.Drawing.Size(702, 318);
            this.dataGridCars.TabIndex = 11;
            this.dataGridCars.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCars_RowHeaderMouseDoubleClick);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 754);
            this.Controls.Add(this.lblSearchModel);
            this.Controls.Add(this.txtSearchModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchNumberPlate);
            this.Controls.Add(this.dataGridCars);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearchMake);
            this.Controls.Add(this.txtSearchMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearch_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchMake;
        private System.Windows.Forms.Label lblSearchMake;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioNo;
        private System.Windows.Forms.Label lblCarCurrentlyRented;
        private System.Windows.Forms.RadioButton radioYes;
        private System.Windows.Forms.Label lblCarRentalDetails;
        private System.Windows.Forms.TextBox txtMOTExpires;
        private System.Windows.Forms.Label lblCarDetails;
        private System.Windows.Forms.TextBox txtCarModel;
        private System.Windows.Forms.Label lblMOTExpires;
        private System.Windows.Forms.Label lblCarModel;
        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.TextBox txtRoadTaxExpires;
        private System.Windows.Forms.Label lblNumberPlate;
        private System.Windows.Forms.TextBox txtCarMake;
        private System.Windows.Forms.Label lblRoadTaxExpires;
        private System.Windows.Forms.Label lblCarMake;
        private System.Windows.Forms.Label lblCarServices;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearchNumberPlate;
        private System.Windows.Forms.Label lblSearchModel;
        private System.Windows.Forms.TextBox txtSearchModel;
        private System.Windows.Forms.DataGridView dataGridCars;
    }
}