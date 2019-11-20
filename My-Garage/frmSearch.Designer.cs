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
            this.txtVNumber = new System.Windows.Forms.TextBox();
            this.lblVNumber = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCars)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchMake
            // 
            this.txtSearchMake.Location = new System.Drawing.Point(84, 15);
            this.txtSearchMake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchMake.Name = "txtSearchMake";
            this.txtSearchMake.Size = new System.Drawing.Size(152, 22);
            this.txtSearchMake.TabIndex = 1;
            this.txtSearchMake.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchMake_KeyPress);
            // 
            // lblSearchMake
            // 
            this.lblSearchMake.AutoSize = true;
            this.lblSearchMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchMake.Location = new System.Drawing.Point(12, 15);
            this.lblSearchMake.Name = "lblSearchMake";
            this.lblSearchMake.Size = new System.Drawing.Size(63, 20);
            this.lblSearchMake.TabIndex = 1;
            this.lblSearchMake.Text = "Μάρκα:";
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
            this.panel1.Location = new System.Drawing.Point(16, 418);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 341);
            this.panel1.TabIndex = 2;
            // 
            // txtVNumber
            // 
            this.txtVNumber.Enabled = false;
            this.txtVNumber.Location = new System.Drawing.Point(149, 131);
            this.txtVNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVNumber.Name = "txtVNumber";
            this.txtVNumber.Size = new System.Drawing.Size(210, 22);
            this.txtVNumber.TabIndex = 25;
            // 
            // lblVNumber
            // 
            this.lblVNumber.AutoSize = true;
            this.lblVNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVNumber.Location = new System.Drawing.Point(16, 131);
            this.lblVNumber.Name = "lblVNumber";
            this.lblVNumber.Size = new System.Drawing.Size(109, 20);
            this.lblVNumber.TabIndex = 24;
            this.lblVNumber.Text = "Αρ. Πλαισίου:";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(149, 271);
            this.txtFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(210, 22);
            this.txtFrom.TabIndex = 23;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFrom.Location = new System.Drawing.Point(16, 271);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(43, 20);
            this.lblFrom.TabIndex = 22;
            this.lblFrom.Text = "Από:";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(149, 300);
            this.txtTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(210, 22);
            this.txtTo.TabIndex = 21;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTo.Location = new System.Drawing.Point(16, 300);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(58, 20);
            this.lblTo.TabIndex = 20;
            this.lblTo.Text = "Μέχρι:";
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(149, 242);
            this.txtCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(210, 22);
            this.txtCustomer.TabIndex = 19;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCustomer.Location = new System.Drawing.Point(16, 242);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(78, 20);
            this.lblCustomer.TabIndex = 18;
            this.lblCustomer.Text = "Πελάτης:";
            // 
            // radioNo
            // 
            this.radioNo.AutoSize = true;
            this.radioNo.Location = new System.Drawing.Point(205, 213);
            this.radioNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioNo.Name = "radioNo";
            this.radioNo.Size = new System.Drawing.Size(50, 21);
            this.radioNo.TabIndex = 17;
            this.radioNo.TabStop = true;
            this.radioNo.Text = "Όχι";
            this.radioNo.UseVisualStyleBackColor = true;
            // 
            // lblCarCurrentlyRented
            // 
            this.lblCarCurrentlyRented.AutoSize = true;
            this.lblCarCurrentlyRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarCurrentlyRented.Location = new System.Drawing.Point(16, 212);
            this.lblCarCurrentlyRented.Name = "lblCarCurrentlyRented";
            this.lblCarCurrentlyRented.Size = new System.Drawing.Size(111, 20);
            this.lblCarCurrentlyRented.TabIndex = 16;
            this.lblCarCurrentlyRented.Text = "Ενοικιασμένο;";
            // 
            // radioYes
            // 
            this.radioYes.AutoSize = true;
            this.radioYes.Location = new System.Drawing.Point(149, 213);
            this.radioYes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioYes.Name = "radioYes";
            this.radioYes.Size = new System.Drawing.Size(50, 21);
            this.radioYes.TabIndex = 15;
            this.radioYes.TabStop = true;
            this.radioYes.Text = "Ναι";
            this.radioYes.UseVisualStyleBackColor = true;
            // 
            // lblCarRentalDetails
            // 
            this.lblCarRentalDetails.AutoSize = true;
            this.lblCarRentalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblCarRentalDetails.Location = new System.Drawing.Point(16, 177);
            this.lblCarRentalDetails.Name = "lblCarRentalDetails";
            this.lblCarRentalDetails.Size = new System.Drawing.Size(202, 20);
            this.lblCarRentalDetails.TabIndex = 14;
            this.lblCarRentalDetails.Text = "Πληροφορίες Ενοικίασης:";
            // 
            // txtMOTExpires
            // 
            this.txtMOTExpires.Location = new System.Drawing.Point(560, 79);
            this.txtMOTExpires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMOTExpires.Name = "txtMOTExpires";
            this.txtMOTExpires.Size = new System.Drawing.Size(210, 22);
            this.txtMOTExpires.TabIndex = 13;
            // 
            // lblCarDetails
            // 
            this.lblCarDetails.AutoSize = true;
            this.lblCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblCarDetails.Location = new System.Drawing.Point(16, 14);
            this.lblCarDetails.Name = "lblCarDetails";
            this.lblCarDetails.Size = new System.Drawing.Size(194, 20);
            this.lblCarDetails.TabIndex = 8;
            this.lblCarDetails.Text = "Πληροφορίες Οχήματος:";
            // 
            // txtCarModel
            // 
            this.txtCarModel.Location = new System.Drawing.Point(149, 76);
            this.txtCarModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarModel.Name = "txtCarModel";
            this.txtCarModel.Size = new System.Drawing.Size(210, 22);
            this.txtCarModel.TabIndex = 7;
            // 
            // lblMOTExpires
            // 
            this.lblMOTExpires.AutoSize = true;
            this.lblMOTExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMOTExpires.Location = new System.Drawing.Point(383, 79);
            this.lblMOTExpires.Name = "lblMOTExpires";
            this.lblMOTExpires.Size = new System.Drawing.Size(63, 20);
            this.lblMOTExpires.TabIndex = 12;
            this.lblMOTExpires.Text = "M.O.T.:";
            // 
            // lblCarModel
            // 
            this.lblCarModel.AutoSize = true;
            this.lblCarModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarModel.Location = new System.Drawing.Point(16, 76);
            this.lblCarModel.Name = "lblCarModel";
            this.lblCarModel.Size = new System.Drawing.Size(79, 20);
            this.lblCarModel.TabIndex = 6;
            this.lblCarModel.Text = "Μοντέλο:";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Location = new System.Drawing.Point(149, 103);
            this.txtNumberPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(210, 22);
            this.txtNumberPlate.TabIndex = 5;
            // 
            // txtRoadTaxExpires
            // 
            this.txtRoadTaxExpires.Location = new System.Drawing.Point(560, 48);
            this.txtRoadTaxExpires.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRoadTaxExpires.Name = "txtRoadTaxExpires";
            this.txtRoadTaxExpires.Size = new System.Drawing.Size(210, 22);
            this.txtRoadTaxExpires.TabIndex = 11;
            // 
            // lblNumberPlate
            // 
            this.lblNumberPlate.AutoSize = true;
            this.lblNumberPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNumberPlate.Location = new System.Drawing.Point(16, 103);
            this.lblNumberPlate.Name = "lblNumberPlate";
            this.lblNumberPlate.Size = new System.Drawing.Size(122, 20);
            this.lblNumberPlate.TabIndex = 4;
            this.lblNumberPlate.Text = "Αρ. Εγγραφής:";
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(149, 48);
            this.txtCarMake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(210, 22);
            this.txtCarMake.TabIndex = 3;
            // 
            // lblRoadTaxExpires
            // 
            this.lblRoadTaxExpires.AutoSize = true;
            this.lblRoadTaxExpires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRoadTaxExpires.Location = new System.Drawing.Point(383, 50);
            this.lblRoadTaxExpires.Name = "lblRoadTaxExpires";
            this.lblRoadTaxExpires.Size = new System.Drawing.Size(162, 20);
            this.lblRoadTaxExpires.TabIndex = 10;
            this.lblRoadTaxExpires.Text = "Άδεια Κυκλοφορίας:";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCarMake.Location = new System.Drawing.Point(16, 48);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(63, 20);
            this.lblCarMake.TabIndex = 2;
            this.lblCarMake.Text = "Μάρκα:";
            // 
            // lblCarServices
            // 
            this.lblCarServices.AutoSize = true;
            this.lblCarServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline);
            this.lblCarServices.Location = new System.Drawing.Point(383, 14);
            this.lblCarServices.Name = "lblCarServices";
            this.lblCarServices.Size = new System.Drawing.Size(322, 20);
            this.lblCarServices.TabIndex = 9;
            this.lblCarServices.Text = "Στοιχεία Οχήματος (Ημερομηνίες Λήξης):";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDone.Location = new System.Drawing.Point(656, 763);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(145, 34);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Oλοκλήρωση";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnSearch.Location = new System.Drawing.Point(16, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(785, 30);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Αναζήτηση";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchCarReg
            // 
            this.lblSearchCarReg.AutoSize = true;
            this.lblSearchCarReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchCarReg.Location = new System.Drawing.Point(512, 15);
            this.lblSearchCarReg.Name = "lblSearchCarReg";
            this.lblSearchCarReg.Size = new System.Drawing.Size(122, 20);
            this.lblSearchCarReg.TabIndex = 13;
            this.lblSearchCarReg.Text = "Αρ. Εγγραφής:";
            // 
            // txtSearchNumberPlate
            // 
            this.txtSearchNumberPlate.Location = new System.Drawing.Point(649, 15);
            this.txtSearchNumberPlate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchNumberPlate.Name = "txtSearchNumberPlate";
            this.txtSearchNumberPlate.Size = new System.Drawing.Size(152, 22);
            this.txtSearchNumberPlate.TabIndex = 3;
            this.txtSearchNumberPlate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchNumberPlate_KeyPress);
            // 
            // lblSearchModel
            // 
            this.lblSearchModel.AutoSize = true;
            this.lblSearchModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSearchModel.Location = new System.Drawing.Point(250, 17);
            this.lblSearchModel.Name = "lblSearchModel";
            this.lblSearchModel.Size = new System.Drawing.Size(79, 20);
            this.lblSearchModel.TabIndex = 15;
            this.lblSearchModel.Text = "Μοντέλο:";
            // 
            // txtSearchModel
            // 
            this.txtSearchModel.Location = new System.Drawing.Point(342, 15);
            this.txtSearchModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchModel.Name = "txtSearchModel";
            this.txtSearchModel.Size = new System.Drawing.Size(152, 22);
            this.txtSearchModel.TabIndex = 2;
            this.txtSearchModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchModel_KeyPress);
            // 
            // dataGridCars
            // 
            this.dataGridCars.AllowUserToAddRows = false;
            this.dataGridCars.AllowUserToDeleteRows = false;
            this.dataGridCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCars.Location = new System.Drawing.Point(16, 81);
            this.dataGridCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridCars.Name = "dataGridCars";
            this.dataGridCars.ReadOnly = true;
            this.dataGridCars.RowTemplate.Height = 24;
            this.dataGridCars.Size = new System.Drawing.Size(785, 318);
            this.dataGridCars.TabIndex = 11;
            this.dataGridCars.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCars_RowHeaderMouseDoubleClick);
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 808);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Αναζήτηση";
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