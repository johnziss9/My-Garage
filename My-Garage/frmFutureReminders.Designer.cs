namespace My_Garage
{
    partial class frmFutureReminders
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
            this.dataGridFutureReminders = new System.Windows.Forms.DataGridView();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFutureReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridFutureReminders
            // 
            this.dataGridFutureReminders.AllowUserToAddRows = false;
            this.dataGridFutureReminders.AllowUserToDeleteRows = false;
            this.dataGridFutureReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFutureReminders.Location = new System.Drawing.Point(12, 12);
            this.dataGridFutureReminders.Name = "dataGridFutureReminders";
            this.dataGridFutureReminders.ReadOnly = true;
            this.dataGridFutureReminders.Size = new System.Drawing.Size(653, 307);
            this.dataGridFutureReminders.TabIndex = 1;
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDone.Location = new System.Drawing.Point(520, 325);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(145, 35);
            this.btnDone.TabIndex = 8;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmFutureReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 370);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dataGridFutureReminders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFutureReminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Reminders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFutureReminders_FormClosing);
            this.Shown += new System.EventHandler(this.frmFutureReminders_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFutureReminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFutureReminders;
        private System.Windows.Forms.Button btnDone;
    }
}