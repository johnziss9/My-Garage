using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            txtCarMake.Enabled = false;
            txtCarModel.Enabled = false;
            txtNumberPlate.Enabled = false;
            txtRoadTaxExpires.Enabled = false;
            txtMOTExpires.Enabled = false;
            radioYes.Enabled = false;
            radioNo.Enabled = false;
            txtCustomer.Enabled = false;
            txtFrom.Enabled = false;
            txtTo.Enabled = false;
        }

        private void frmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture";
            SQLiteConnection conn = new SQLiteConnection(connString);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            BindingSource bs = new BindingSource();

            dt = new DataTable();
            da = new SQLiteDataAdapter("SELECT * FROM Cars WHERE CarMake LIKE '%" + txtSearchMake.Text + "%' AND CarModel LIKE '%" + txtSearchModel.Text + "%' AND NumberPlate LIKE '%" + txtSearchNumberPlate.Text + "%'", conn);

            da.Fill(dt);
            bs.DataSource = dt;
            dataGridCars.DataSource = bs;

            dataGridCars.Columns[0].Visible = false;
        }

        private void dataGridCars_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture");

            var currentRow = dataGridCars.CurrentRow.Cells[0].Value;

            string query = "SELECT * FROM Cars WHERE Id = " + currentRow;

            conn.Open();

            SQLiteCommand command = new SQLiteCommand(query, conn);

            SQLiteDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                txtCarMake.Text = dr["CarMake"].ToString();
                txtCarModel.Text = dr["CarModel"].ToString();
                txtNumberPlate.Text = dr["NumberPlate"].ToString();
            }

            conn.Close();
        }
    }
}
