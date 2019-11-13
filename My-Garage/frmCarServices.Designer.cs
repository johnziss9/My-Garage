namespace My_Garage
{
    partial class frmCarServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarServices));
            this.dateTimeRoadTaxFrom = new System.Windows.Forms.DateTimePicker();
            this.lblRoadTax = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.cmbCar = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.chkRoadTax = new System.Windows.Forms.CheckBox();
            this.lblRTFrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeRoadTaxTo = new System.Windows.Forms.DateTimePicker();
            this.chkMOT = new System.Windows.Forms.CheckBox();
            this.lblMOT = new System.Windows.Forms.Label();
            this.dateTimeMOTTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeMOTFrom = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // dateTimeRoadTaxFrom
            // 
            this.dateTimeRoadTaxFrom.Location = new System.Drawing.Point(63, 101);
            this.dateTimeRoadTaxFrom.Name = "dateTimeRoadTaxFrom";
            this.dateTimeRoadTaxFrom.Size = new System.Drawing.Size(140, 20);
            this.dateTimeRoadTaxFrom.TabIndex = 3;
            // 
            // lblRoadTax
            // 
            this.lblRoadTax.AutoSize = true;
            this.lblRoadTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoadTax.Location = new System.Drawing.Point(11, 75);
            this.lblRoadTax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoadTax.Name = "lblRoadTax";
            this.lblRoadTax.Size = new System.Drawing.Size(127, 16);
            this.lblRoadTax.TabIndex = 19;
            this.lblRoadTax.Text = "Άδεια Κυκλοφορίας:";
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCar.Location = new System.Drawing.Point(9, 9);
            this.lblCar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(84, 17);
            this.lblCar.TabIndex = 25;
            this.lblCar.Text = "Αυτοκίνητο:";
            // 
            // cmbCar
            // 
            this.cmbCar.FormattingEnabled = true;
            this.cmbCar.Location = new System.Drawing.Point(121, 9);
            this.cmbCar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCar.Name = "cmbCar";
            this.cmbCar.Size = new System.Drawing.Size(322, 21);
            this.cmbCar.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(11, 233);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegister.Location = new System.Drawing.Point(334, 233);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(109, 28);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // chkRoadTax
            // 
            this.chkRoadTax.AutoSize = true;
            this.chkRoadTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkRoadTax.Location = new System.Drawing.Point(14, 46);
            this.chkRoadTax.Name = "chkRoadTax";
            this.chkRoadTax.Size = new System.Drawing.Size(230, 21);
            this.chkRoadTax.TabIndex = 2;
            this.chkRoadTax.Text = "Πρόσθεση Άδειας Κυκλοφορίας:";
            this.chkRoadTax.UseVisualStyleBackColor = true;
            this.chkRoadTax.CheckedChanged += new System.EventHandler(this.chkRoadTax_CheckedChanged);
            // 
            // lblRTFrom
            // 
            this.lblRTFrom.AutoSize = true;
            this.lblRTFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTFrom.Location = new System.Drawing.Point(11, 101);
            this.lblRTFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRTFrom.Name = "lblRTFrom";
            this.lblRTFrom.Size = new System.Drawing.Size(37, 17);
            this.lblRTFrom.TabIndex = 26;
            this.lblRTFrom.Text = "Από:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Μέχρι:";
            // 
            // dateTimeRoadTaxTo
            // 
            this.dateTimeRoadTaxTo.Location = new System.Drawing.Point(272, 101);
            this.dateTimeRoadTaxTo.Name = "dateTimeRoadTaxTo";
            this.dateTimeRoadTaxTo.Size = new System.Drawing.Size(140, 20);
            this.dateTimeRoadTaxTo.TabIndex = 4;
            // 
            // chkMOT
            // 
            this.chkMOT.AutoSize = true;
            this.chkMOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkMOT.Location = new System.Drawing.Point(14, 143);
            this.chkMOT.Name = "chkMOT";
            this.chkMOT.Size = new System.Drawing.Size(143, 21);
            this.chkMOT.TabIndex = 5;
            this.chkMOT.Text = "Πρόσθεση M.O.T.:";
            this.chkMOT.UseVisualStyleBackColor = true;
            this.chkMOT.CheckedChanged += new System.EventHandler(this.chkMOT_CheckedChanged_1);
            // 
            // lblMOT
            // 
            this.lblMOT.AutoSize = true;
            this.lblMOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOT.Location = new System.Drawing.Point(11, 172);
            this.lblMOT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMOT.Name = "lblMOT";
            this.lblMOT.Size = new System.Drawing.Size(127, 16);
            this.lblMOT.TabIndex = 30;
            this.lblMOT.Text = "Άδεια Κυκλοφορίας:";
            // 
            // dateTimeMOTTo
            // 
            this.dateTimeMOTTo.Location = new System.Drawing.Point(272, 199);
            this.dateTimeMOTTo.Name = "dateTimeMOTTo";
            this.dateTimeMOTTo.Size = new System.Drawing.Size(140, 20);
            this.dateTimeMOTTo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 199);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Μέχρι:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "Από:";
            // 
            // dateTimeMOTFrom
            // 
            this.dateTimeMOTFrom.Location = new System.Drawing.Point(63, 199);
            this.dateTimeMOTFrom.Name = "dateTimeMOTFrom";
            this.dateTimeMOTFrom.Size = new System.Drawing.Size(140, 20);
            this.dateTimeMOTFrom.TabIndex = 6;
            // 
            // frmCarServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 273);
            this.Controls.Add(this.dateTimeMOTTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeMOTFrom);
            this.Controls.Add(this.lblMOT);
            this.Controls.Add(this.chkMOT);
            this.Controls.Add(this.dateTimeRoadTaxTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRTFrom);
            this.Controls.Add(this.chkRoadTax);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cmbCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.dateTimeRoadTaxFrom);
            this.Controls.Add(this.lblRoadTax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmCarServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Πληροφορίες Αυτοκινήτου";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServices_FormClosing);
            this.Load += new System.EventHandler(this.frmServices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimeRoadTaxFrom;
        private System.Windows.Forms.Label lblRoadTax;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.ComboBox cmbCar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.CheckBox chkRoadTax;
        private System.Windows.Forms.Label lblRTFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeRoadTaxTo;
        private System.Windows.Forms.CheckBox chkMOT;
        private System.Windows.Forms.Label lblMOT;
        private System.Windows.Forms.DateTimePicker dateTimeMOTTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeMOTFrom;
    }
}