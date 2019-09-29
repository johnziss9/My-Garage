namespace My_Garage
{
    partial class frmReminders
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
            this.dataGridReminders = new System.Windows.Forms.DataGridView();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridReminders
            // 
            this.dataGridReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReminders.Location = new System.Drawing.Point(12, 12);
            this.dataGridReminders.Name = "dataGridReminders";
            this.dataGridReminders.Size = new System.Drawing.Size(653, 307);
            this.dataGridReminders.TabIndex = 0;
            this.dataGridReminders.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridReminders_RowHeaderMouseDoubleClick);
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDone.Location = new System.Drawing.Point(520, 325);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(145, 35);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // frmReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 372);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dataGridReminders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmReminders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmReminders_FormClosing);
            this.Shown += new System.EventHandler(this.frmReminders_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridReminders;
        private System.Windows.Forms.Button btnDone;
    }
}