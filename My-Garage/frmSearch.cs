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
            Search();
        }

        private void dataGridCars_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture");

            SQLiteCommand command;
            SQLiteDataReader dr;

            var currentRow = dataGridCars.CurrentRow.Cells[0].Value;

            // Fill in cars

            string queryCars = "SELECT * FROM Cars WHERE Id = " + currentRow;

            conn.Open();

            command = new SQLiteCommand(queryCars, conn);

            dr = command.ExecuteReader();

            while (dr.Read())
            {
                txtCarMake.Text = dr["CarMake"].ToString();
                txtCarModel.Text = dr["CarModel"].ToString();
                txtNumberPlate.Text = dr["NumberPlate"].ToString();
                txtVNumber.Text = dr["VNumber"].ToString();
            }

            conn.Close();

            // Fill in services

            string queryServices = "SELECT * FROM CarServices WHERE CarId = " + currentRow + " ORDER BY Id DESC LIMIT 1";

            conn.Open();

            command = new SQLiteCommand(queryServices, conn);

            dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (dr["RoadTax"] != DBNull.Value)
                {
                    var roadTaxDate = Convert.ToDateTime(dr["RoadTax"]);
                    string[] roadTaxDurationSplit = dr["RoadTaxDuration"].ToString().Split(' ');
                    var roadTaxDuration = Convert.ToInt32(roadTaxDurationSplit[0]);

                    txtRoadTaxExpires.Text = roadTaxDate.AddMonths(roadTaxDuration).ToShortDateString();
                }
                else
                    txtRoadTaxExpires.Text = "Not Added";


                if (dr["MOT"] != DBNull.Value)
                {
                    var MOTDate = Convert.ToDateTime(dr["MOT"]);
                    string[] MOTDurationSplit = dr["MOTDuration"].ToString().Split(' ');
                    var MOTDuration = Convert.ToInt32(MOTDurationSplit[0]);

                    txtMOTExpires.Text = MOTDate.AddMonths(MOTDuration).ToShortDateString();
                }
                else
                    txtMOTExpires.Text = "Not Added";
            }

            conn.Close();

            // Fill in rental services

            string queryRental = "SELECT * FROM Rentals WHERE CarId = " + currentRow + " ORDER BY Id DESC LIMIT 1";

            conn.Open();

            command = new SQLiteCommand(queryRental, conn);

            dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (Convert.ToBoolean(dr["Rented"]) == true)
                    radioYes.Checked = true;
                else
                    radioNo.Checked = true;

                txtCustomer.Text = dr["Customer"].ToString();
                txtFrom.Text = Convert.ToDateTime(dr["FromDate"]).ToShortDateString();
                txtTo.Text = Convert.ToDateTime(dr["ToDate"]).ToShortDateString();
            }
        }

        public void Search()
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

        private void txtSearchMake_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Search();
            }
        }

        private void txtSearchModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Search();
            }
        }

        private void txtSearchNumberPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                Search();
            }
        }
    }
}
