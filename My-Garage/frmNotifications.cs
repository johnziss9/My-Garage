using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmReminders : Form
    {
        public frmReminders()
        {
            InitializeComponent();
        }

        private void frmReminders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void frmReminders_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Im working");
            ShowReminders();
        }

        private void ShowReminders()
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.19.0;Data Source=C:\GarageDB.accdb");
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            BindingSource bs = new BindingSource();

            dt = new DataTable();
            da = new OleDbDataAdapter("SELECT * FROM Customers", con);

            da.Fill(dt);
            bs.DataSource = dt;
            dataGridReminders.DataSource = bs;
            //dataGridReminders.Columns[0].Visible = false;

            dataGridReminders.Columns["Customer_ID"].DisplayIndex = 0;
            dataGridReminders.Columns["Customer_ID"].HeaderText = "Αριθμός Πελάτη";
            dataGridReminders.Columns["First_Name_s"].HeaderText = "Πρώτο Όνομα(τα)";
            dataGridReminders.Columns["Last_Name"].HeaderText = "Εμώνυμο";
            dataGridReminders.Columns["Address"].HeaderText = "Διεύθυνση";
        }
    }
}
