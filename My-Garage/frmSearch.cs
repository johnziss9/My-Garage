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

            dataGridCars.Columns[1].HeaderText = "Μάρκα";
            dataGridCars.Columns[2].HeaderText = "Μοντέλο";
            dataGridCars.Columns[3].HeaderText = "Αρ. Εγγραφής";
            dataGridCars.Columns[4].HeaderText = "Αρ. Πλαισίου";
        }

        private void dataGridCars_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture");

            SQLiteCommand command;
            SQLiteDataReader dr;

            var currentRow = dataGridCars.CurrentRow.Cells[0].Value;

            // Clear fields
            txtCarMake.Text = "";
            txtCarModel.Text = "";
            txtNumberPlate.Text = "";
            txtVNumber.Text = "";
            txtRoadTaxExpires.Text = "";
            txtMOTExpires.Text = "";
            radioYes.Checked = false;
            radioNo.Checked = false;
            txtCustomer.Text = "";
            txtFrom.Text = "";
            txtTo.Text = "";

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

            string queryServicesRT = "SELECT * FROM CarServices WHERE CarId = " + currentRow + " AND Type = 'Άδεια Κυκλοφορίας' AND Renewal = false ORDER BY Id DESC LIMIT 1";
            string queryServicesMOT = "SELECT * FROM CarServices WHERE CarId = " + currentRow + " AND Type = 'M.O.T.' AND Renewal = false ORDER BY Id DESC LIMIT 1";

            conn.Open();

            // Road Tax

            command = new SQLiteCommand(queryServicesRT, conn);

            dr = command.ExecuteReader();

            while (dr.Read())
                txtRoadTaxExpires.Text = Convert.ToDateTime(dr["ToDate"]).ToShortDateString();

            // MOT

            command = new SQLiteCommand(queryServicesMOT, conn);

            dr = command.ExecuteReader();

            while (dr.Read())
                txtMOTExpires.Text = Convert.ToDateTime(dr["ToDate"]).ToShortDateString();

            conn.Close();

            // Fill in rental services

            string queryRental = "SELECT * FROM Rentals WHERE CarId = " + currentRow + " ORDER BY Id DESC LIMIT 1";

            conn.Open();

            command = new SQLiteCommand(queryRental, conn);

            dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (Convert.ToBoolean(dr["Rented"]) == true)
                {
                    radioYes.Checked = true;
                    lblRentalDetails.Text = "Ενοικιαστής:";
                }
                else
                {
                    radioNo.Checked = true;
                    lblRentalDetails.Text = "Τελευταίος Ενοικιαστής:";
                }

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
