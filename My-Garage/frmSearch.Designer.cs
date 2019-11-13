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
            this.lblFrom = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
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
            this.lblSearchCarReg = new System.Windows.Forms.Label();
            this.txtSearchNumberPlate = new System.Windows.Forms.TextBox();
            this.lblSearchModel = new System.Windows.Forms.Label();
            this.txtSearchModel = new System.Windows.Forms.TextBox();
            this.dataGridCars = new System.Windows.Forms.DataGridView();
            this.txtVNumber = new System.Windows.Forms.TextBox();
            this.lblVNumber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchMake
            // 
            this.txtSearchMake.Location = new System.Drawing.Point(54, 12);
            this.txtSearchMake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchMake.Name = "txtSearchMake";
            this.txtSearchMake.Size = new System.Drawing.Size(115, 20);
            this.txtSearchMake.TabIndex = 1;
            this.txtSearchMake.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchMake_KeyPress);
            // 
            // lblSearchMake
            // 
            this.lblSearchMake.AutoSize = true;
            this.lblSearchMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchMake.Location = new System.Drawing.Point(9, 12);
            this.lblSearchMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchMake.Name = "lblSearchMake";
            this.lblSearchMake.Size = new System.Drawing.Size(46, 17);
            this.lblSearchMake.TabIndex = 1;
            this.lblSearchMake.Text = "Make:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtVNumber);
            this.panel1.Controls.Add(this.lblVNumber);
            this.panel1.Controls.Add(this.txtFrom);
            this.panel1.Controls.Add(this.lblFrom);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.lblTo);
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
            this.panel1.Location = new System.Drawing.Point(12, 340);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 251);
            this.panel1.TabIndex = 2;
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(104, 220);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(138, 20);
            this.txtFrom.TabIndex = 23;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrom.Location = new System.Drawing.Point(12, 220);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 17);
            this.lblFrom.TabIndex = 22;
            this.lblFrom.Text = "From:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(375, 220);
            this.txtTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(138, 20);
            this.txtTo.TabIndex = 21;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTo.Location = new System.Drawing.Point(261, 220);
            this.lblTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 17);
            this.lblTo.TabIndex = 20;
            this.lblTo.Text = "To:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(104, 197);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(138, 20);
            this.txtCustomer.TabIndex = 19;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(12, 197);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(72, 17);
            this.lblCustomer.TabIndex = 18;
            this.lblCustomer.Text = "Customer:";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(202, 173);
            this.radioNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(39, 17);
            this.radioNo.TabIndex = 17;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "No";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // lblCarCurrentlyRented
            // 
            this.lblCarCurrentlyRented.AutoSize = true;
            this.lblCarCurrentlyRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarCurrentlyRented.Location = new System.Drawing.Point(12, 172);
            this.lblCarCurrentlyRented.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarCurrentlyRented.Name = "lblCarCurrentlyRented";
            this.lblCarCurrentlyRented.Size = new System.Drawing.Size(149, 17);
            this.lblCarCurrentlyRented.TabIndex = 16;
            this.lblCarCurrentlyRented.Text = "Car Currently Rented?";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(158, 173);
            this.radioYes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(43, 17);
            this.radioYes.TabIndex = 15;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Yes";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // lblCarRentalDetails
            // 
            this.lblCarRentalDetails.AutoSize = true;
            this.lblCarRentalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblCarRentalDetails.Location = new System.Drawing.Point(12, 144);
            this.lblCarRentalDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarRentalDetails.Name = "lblCarRentalDetails";
            this.lblCarRentalDetails.Size = new System.Drawing.Size(126, 17);
            this.lblCarRentalDetails.TabIndex = 14;
            this.lblCarRentalDetails.Text = "Car Rental Details:";
            // 
            // txtMOTExpires
            // 
            this.txtMOTExpires.Location = new System.Drawing.Point(375, 64);
            this.txtMOTExpires.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMOTExpires.Name = "txtMOTExpires";
            this.txtMOTExpires.Size = new System.Drawing.Size(138, 20);
            this.txtMOTExpires.TabIndex = 13;
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblCarDetails.Location = new System.Drawing.Point(12, 11);
            this.lblCarDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(81, 17);
            this.lblCarDetails.TabIndex = 8;
            this.lblCarDetails.Text = "Car Details:";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(104, 62);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(138, 20);
            this.txtCarModel.TabIndex = 7;
            // 
            // lblMOTExpires
            // 
            this.lblMOTExpires.AutoSize = true;
            this.lblMOTExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMOTExpires.Location = new System.Drawing.Point(261, 64);
            this.lblMOTExpires.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMOTExpires.Name = "lblMOTExpires";
            this.lblMOTExpires.Size = new System.Drawing.Size(93, 17);
            this.lblMOTExpires.TabIndex = 12;
            this.lblMOTExpires.Text = "MOT Expires:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarModel.Location = new System.Drawing.Point(12, 62);
            this.lblCarModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(76, 17);
            this.lblCarModel.TabIndex = 6;
            this.lblCarModel.Text = "Car Model:";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Location = new System.Drawing.Point(104, 84);
            this.txtNumberPlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(138, 20);
            this.txtNumberPlate.TabIndex = 5;
            // 
            // txtRoadTaxExpires
            // 
            this.txtRoadTaxExpires.Location = new System.Drawing.Point(375, 39);
            this.txtRoadTaxExpires.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoadTaxExpires.Name = "txtRoadTaxExpires";
            this.txtRoadTaxExpires.Size = new System.Drawing.Size(138, 20);
            this.txtRoadTaxExpires.TabIndex = 11;
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumberPlate.Location = new System.Drawing.Point(12, 84);
            this.lblNumberPlate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(98, 17);
            this.lblNumberPlate.TabIndex = 4;
            this.lblNumberPlate.Text = "Number Plate:";
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(104, 39);
            this.txtCarMake.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(138, 20);
            this.txtCarMake.TabIndex = 3;
            // 
            // lblRoadTaxExpires
            // 
            this.lblRoadTaxExpires.AutoSize = true;
            this.lblRoadTaxExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRoadTaxExpires.Location = new System.Drawing.Point(261, 41);
            this.lblRoadTaxExpires.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoadTaxExpires.Name = "lblRoadTaxExpires";
            this.lblRoadTaxExpires.Size = new System.Drawing.Size(123, 17);
            this.lblRoadTaxExpires.TabIndex = 10;
            this.lblRoadTaxExpires.Text = "Road Tax Expires:";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarMake.Location = new System.Drawing.Point(12, 39);
            this.lblCarMake.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(72, 17);
            this.lblCarMake.TabIndex = 2;
            this.lblCarMake.Text = "Car Make:";
            // 
            // lblCarServices
            // 
            this.lblCarServices.AutoSize = true;
            this.lblCarServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblCarServices.Location = new System.Drawing.Point(261, 11);
            this.lblCarServices.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarServices.Name = "lblCarServices";
            this.lblCarServices.Size = new System.Drawing.Size(92, 17);
            this.lblCarServices.TabIndex = 9;
            this.lblCarServices.Text = "Car Services:";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDone.Location = new System.Drawing.Point(429, 595);
            this.btnDone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(109, 28);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(424, 37);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(114, 24);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchCarReg
            // 
            this.lblSearchCarReg.AutoSize = true;
            this.lblSearchCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchCarReg.Location = new System.Drawing.Point(365, 12);
            this.lblSearchCarReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchCarReg.Name = "lblSearchCarReg";
            this.lblSearchCarReg.Size = new System.Drawing.Size(62, 17);
            this.lblSearchCarReg.TabIndex = 13;
            this.lblSearchCarReg.Text = "Numera:";
            // 
            // txtSearchNumberPlate
            // 
            this.txtSearchNumberPlate.Location = new System.Drawing.Point(424, 12);
            this.txtSearchNumberPlate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchNumberPlate.Name = "txtSearchNumberPlate";
            this.txtSearchNumberPlate.Size = new System.Drawing.Size(115, 20);
            this.txtSearchNumberPlate.TabIndex = 3;
            this.txtSearchNumberPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchNumberPlate_KeyPress);
            // 
            // lblSearchModel
            // 
            this.lblSearchModel.AutoSize = true;
            this.lblSearchModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchModel.Location = new System.Drawing.Point(185, 14);
            this.lblSearchModel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchModel.Name = "lblSearchModel";
            this.lblSearchModel.Size = new System.Drawing.Size(50, 17);
            this.lblSearchModel.TabIndex = 15;
            this.lblSearchModel.Text = "Model:";
            // 
            // txtSearchModel
            // 
            this.txtSearchModel.Location = new System.Drawing.Point(234, 12);
            this.txtSearchModel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchModel.Name = "txtSearchModel";
            this.txtSearchModel.Size = new System.Drawing.Size(115, 20);
            this.txtSearchModel.TabIndex = 2;
            this.txtSearchModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchModel_KeyPress);
            // 
            // dataGridCars
            // 
            this.dataGridCars.AllowUserToAddRows = false;
            this.dataGridCars.AllowUserToDeleteRows = false;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(12, 66);
            this.dataGridCars.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.ReadOnly = true;
            this.dataGridCars.RowTemplate.Height = 24;
            this.dataGridCars.Size = new System.Drawing.Size(526, 258);
            this.dataGridCars.TabIndex = 11;
            this.dataGridCars.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCars_RowHeaderMouseDoubleClick);
            // 
            // txtVNumber
            // 
            this.txtVNumber.Enabled = false;
            this.txtVNumber.Location = new System.Drawing.Point(104, 108);
            this.txtVNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtVNumber.Name = "txtVNumber";
            this.txtVNumber.Size = new System.Drawing.Size(138, 20);
            this.txtVNumber.TabIndex = 25;
            // 
            // lblVNumber
            // 
            this.lblVNumber.AutoSize = true;
            this.lblVNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVNumber.Location = new System.Drawing.Point(12, 108);
            this.lblVNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVNumber.Name = "lblVNumber";
            this.lblVNumber.Size = new System.Drawing.Size(79, 17);
            this.lblVNumber.TabIndex = 24;
            this.lblVNumber.Text = "V. Number:";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 630);
            this.Controls.Add(this.lblSearchModel);
            this.Controls.Add(this.txtSearchModel);
            this.Controls.Add(this.lblSearchCarReg);
            this.Controls.Add(this.txtSearchNumberPlate);
            this.Controls.Add(this.dataGridCars);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearchMake);
            this.Controls.Add(this.txtSearchMake);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearchCarReg;
        private System.Windows.Forms.TextBox txtSearchNumberPlate;
        private System.Windows.Forms.Label lblSearchModel;
        private System.Windows.Forms.TextBox txtSearchModel;
        private System.Windows.Forms.DataGridView dataGridCars;
        private System.Windows.Forms.TextBox txtVNumber;
        private System.Windows.Forms.Label lblVNumber;
    }
}