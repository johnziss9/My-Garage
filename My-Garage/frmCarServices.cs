using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCarServices : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture");
        SQLiteCommand command;
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();

        int _serviceId = 0;
        int _reminderId = 0;

        public frmCarServices()
        {
            InitializeComponent();
            dateTimeRoadTaxFrom.Enabled = false;
            dateTimeRoadTaxTo.Enabled = false;
            dateTimeMOTFrom.Enabled = false;
            dateTimeMOTTo.Enabled = false;
        }        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();

            // Service Add

            string queryServices = "INSERT INTO CarServices (Id, Car, RoadTaxFrom, RoadTaxTo, MOTFrom, MOTTo, CarId) " +
                "VALUES (@id, @car, @roadTaxFrom, @roadTaxTo, @MOTFrom, @MOTTo, @carId)";

            string queryRoadTax = "INSERT INTO CarServices (Id, Car, RoadTaxFrom, RoadTaxTo, CarId) " +
                "VALUES (@id, @car, @roadTaxFrom, @roadTaxTo, @carId)";

            string queryMOT = "INSERT INTO CarServices (Id, Car, MOTFrom, MOTTo, CarId) " +
                "VALUES (@id, @car, @MOTFrom, @MOTTo, @carId)";

            GetServiceId();

            conn.Open();

            if (chkRoadTax.Checked && chkMOT.Checked)
            {
                command = new SQLiteCommand(queryServices, conn);
    
                command.Parameters.AddWithValue("@id", _serviceId);
                command.Parameters.AddWithValue("@car", cmbCar.Text);
                command.Parameters.AddWithValue("@roadTaxFrom", dateTimeRoadTaxFrom.Value.Date);
                command.Parameters.AddWithValue("@roadTaxTo", dateTimeRoadTaxTo.Value.Date);
                command.Parameters.AddWithValue("@MOTFrom", dateTimeMOTFrom.Value.Date);
                command.Parameters.AddWithValue("@MOTTo", dateTimeMOTTo.Value.Date);
                command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);

                command.ExecuteNonQuery();

                MessageBox.Show("Service Added", "Service Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

                // Reminders Add

                string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn, CarId) " +
                "VALUES (@id, @type, @car, @customer, @notes, @dueOn, @carId)";

                // Runs twice - First time is gets the road tax and second time it gets the MOT
                for (int i = 0; i < 2; i++)
                {
                    conn.Close();

                    GetReminderId();

                    conn.Open();

                    command = new SQLiteCommand(queryReminder, conn);

                    command.Parameters.AddWithValue("@id", _reminderId);
                    command.Parameters.AddWithValue("@type", i == 0 ? "Road Tax Due" : "MOT Due");
                    command.Parameters.AddWithValue("@car", cmbCar.Text.ToUpper());
                    command.Parameters.AddWithValue("@customer", "N/A");
                    command.Parameters.AddWithValue("@notes", "N/A");
                    command.Parameters.AddWithValue("@dueOn", i == 0 ? dateTimeRoadTaxTo.Value.Date : dateTimeMOTTo.Value.Date);
                    command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);

                    command.ExecuteNonQuery();
                }

                conn.Close();

                frmHome home = new frmHome();
                home.Show();
            }
            else if (chkRoadTax.Checked && chkMOT.Checked == false)
            {
                command = new SQLiteCommand(queryRoadTax, conn);

                command.Parameters.AddWithValue("@id", _serviceId);
                command.Parameters.AddWithValue("@car", cmbCar.Text);
                command.Parameters.AddWithValue("@roadTaxFrom", dateTimeRoadTaxFrom.Value.Date);
                command.Parameters.AddWithValue("@roadTaxTo", dateTimeRoadTaxTo.Value.Date);
                command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);

                command.ExecuteNonQuery();

                MessageBox.Show("Service Added", "Service Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

                // Reminders Add

                string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn, CarId) " +
                "VALUES (@id, @type, @car, @customer, @notes, @dueOn, @carId)";

                conn.Close();

                GetReminderId();

                conn.Open();

                command = new SQLiteCommand(queryReminder, conn);

                command.Parameters.AddWithValue("@id", _reminderId);
                command.Parameters.AddWithValue("@type", "Road Tax Due");
                command.Parameters.AddWithValue("@car", cmbCar.Text.ToUpper());
                command.Parameters.AddWithValue("@customer", "N/A");
                command.Parameters.AddWithValue("@notes", "N/A");
                command.Parameters.AddWithValue("@dueOn", dateTimeRoadTaxTo.Value.Date);
                command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);

                command.ExecuteNonQuery();

                conn.Close();

                frmHome home = new frmHome();
                home.Show();
            }
            else if (chkRoadTax.Checked == false && chkMOT.Checked)
            {
                command = new SQLiteCommand(queryMOT, conn);

                command.Parameters.AddWithValue("@id", _serviceId);
                command.Parameters.AddWithValue("@car", cmbCar.Text);
                command.Parameters.AddWithValue("@MOTFrom", dateTimeMOTFrom.Value.Date);
                command.Parameters.AddWithValue("@MOTTo", dateTimeMOTTo.Value.Date);
                command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);

                command.ExecuteNonQuery();

                MessageBox.Show("Service Added", "Service Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

                // Reminders Add

                string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn, CarId) " +
                "VALUES (@id, @type, @car, @customer, @notes, @dueOn, @carId)";

                conn.Close();

                GetReminderId();

                conn.Open();

                command = new SQLiteCommand(queryReminder, conn);

                command.Parameters.AddWithValue("@id", _reminderId);
                command.Parameters.AddWithValue("@type", "MOT Due");
                command.Parameters.AddWithValue("@car", cmbCar.Text.ToUpper());
                command.Parameters.AddWithValue("@customer", "N/A");
                command.Parameters.AddWithValue("@notes", "N/A");
                command.Parameters.AddWithValue("@dueOn", dateTimeMOTTo.Value.Date);
                command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);

                command.ExecuteNonQuery();

                conn.Close();

                frmHome home = new frmHome();
                home.Show();
            }
            else
                MessageBox.Show("Please select at least one service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void frmServices_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void GetServiceId()
        {
            string query = "SELECT Id FROM CarServices ORDER BY Id DESC LIMIT 1";

            conn.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        _serviceId = dr.GetInt32(0) + 1;
                    }
                }
            }

            conn.Close();
        }

        public void GetReminderId()
        {
            string query = "SELECT Id FROM Reminders ORDER BY Id DESC LIMIT 1";

            conn.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        _reminderId = dr.GetInt32(0) + 1;
                    }
                }
            }

            conn.Close();
        }

        private void frmServices_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture"))
            {
                try
                {
                    string query = "SELECT Id, CarMake, CarModel, (CarMake || ' ' || CarModel || ' ' || NumberPlate) AS Car FROM Cars";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, conn);

                    conn.Open();

                    DataSet ds = new DataSet();

                    da.Fill(ds, "Cars");

                    cmbCar.DisplayMember = "Car";
                    cmbCar.ValueMember = "Id";
                    cmbCar.DataSource = ds.Tables["Cars"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
            }
        }

        private void chkRoadTax_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkRoadTax.Checked)
            {
                dateTimeRoadTaxFrom.Enabled = false;
                dateTimeRoadTaxTo.Enabled = false;
            }
            else
            {
                dateTimeRoadTaxFrom.Enabled = true;
                dateTimeRoadTaxTo.Enabled = true;
            }
        }

        private void chkMOT_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!chkMOT.Checked)
            {
                dateTimeMOTFrom.Enabled = false;
                dateTimeMOTTo.Enabled = false;
            }
            else
            {
                dateTimeMOTFrom.Enabled = true;
                dateTimeMOTTo.Enabled = true;
            }
        }
    }
}
