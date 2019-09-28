using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
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
            ShowReminders();
        }

        private void ShowReminders()
        {
            string sqlConnection = "Data Source=.;Initial Catalog=GarageDB; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(sqlConnection);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            BindingSource bs = new BindingSource();

            dt = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM Rentals", conn);

            da.Fill(dt);
            bs.DataSource = dt;
            dataGridReminders.DataSource = bs;

            dataGridReminders.Columns[0].Visible = false;
        }
    }
}
