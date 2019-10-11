using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCarServices : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\jzissimou\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture");
        SQLiteCommand command;
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();

        int _serviceId = 0;
        int _reminderId = 0;

        public frmCarServices()
        {
            InitializeComponent();
            dateTimeRoadTax.Enabled = false;
            cmbRTDuration.Enabled = false;
            dateTimeMOT.Enabled = false;
            cmbMOTDuration.Enabled = false;
        }        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();

            // Service Add

            string queryServices = "INSERT INTO CarServices (Id, Car, RoadTax, RoadTaxDuration, MOT, MOTDuration, CarId) " +
                "VALUES (@id, @car, @roadTax, @roadTaxDuration, @MOT, @MOTDuration, @carId)";

            string queryRoadTax = "INSERT INTO CarServices (Id, Car, RoadTax, RoadTaxDuration, CarId) " +
                "VALUES (@id, @car, @roadTax, @roadTaxDuration, @carId)";

            string queryMOT = "INSERT INTO CarServices (Id, Car, MOT, MOTDuration, CarId) " +
                "VALUES (@id, @car, @MOT, @MOTDuration, @carId)";

            GetServiceId();

            conn.Open();

            if (chkRoadTax.Checked && chkMOT.Checked)
            {
                command = new SQLiteCommand(queryServices, conn);

                if (cmbRTDuration.Text != "" || cmbMOTDuration.Text != "")
                {
                    command.Parameters.AddWithValue("@id", _serviceId);
                    command.Parameters.AddWithValue("@car", cmbCar.Text);
                    command.Parameters.AddWithValue("@roadTax", dateTimeRoadTax.Value.Date);
                    command.Parameters.AddWithValue("@roadTaxDuration", cmbRTDuration.Text);
                    command.Parameters.AddWithValue("@MOT", dateTimeMOT.Value.Date);
                    command.Parameters.AddWithValue("@MOTDuration", cmbMOTDuration.Text);
                    command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Service Added", "Service Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

                    // Reminders Add

                    string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn, ServiceId) " +
                    "VALUES (@id, @type, @car, @customer, @notes, @dueOn, @serviceId)";

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
                        command.Parameters.AddWithValue("@dueOn", i == 0 ? GetRoadTaxDate(dateTimeRoadTax.Value).Date : GetMOTDate(dateTimeMOT.Value).Date);
                        command.Parameters.AddWithValue("@serviceId", _serviceId);

                        command.ExecuteNonQuery();
                    }

                    conn.Close();

                    frmHome home = new frmHome();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    frmCarServices services = new frmCarServices();
                    services.Show();
                }

            }
            else if (chkRoadTax.Checked && chkMOT.Checked == false)
            {
                command = new SQLiteCommand(queryRoadTax, conn);

                if (cmbRTDuration.Text != "")
                {
                    command.Parameters.AddWithValue("@id", _serviceId);
                    command.Parameters.AddWithValue("@car", cmbCar.Text);
                    command.Parameters.AddWithValue("@roadTax", dateTimeRoadTax.Value.Date);
                    command.Parameters.AddWithValue("@roadTaxDuration", cmbRTDuration.Text);
                    command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Service Added", "Service Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

                    // Reminders Add

                    string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn, ServiceId) " +
                    "VALUES (@id, @type, @car, @customer, @notes, @dueOn, @serviceId)";

                    conn.Close();

                    GetReminderId();

                    conn.Open();

                    command = new SQLiteCommand(queryReminder, conn);

                    command.Parameters.AddWithValue("@id", _reminderId);
                    command.Parameters.AddWithValue("@type", "Road Tax Due");
                    command.Parameters.AddWithValue("@car", cmbCar.Text.ToUpper());
                    command.Parameters.AddWithValue("@customer", "N/A");
                    command.Parameters.AddWithValue("@notes", "N/A");
                    command.Parameters.AddWithValue("@dueOn", GetRoadTaxDate(dateTimeRoadTax.Value).Date);
                    command.Parameters.AddWithValue("@serviceId", _serviceId);

                    command.ExecuteNonQuery();

                    conn.Close();

                    frmHome home = new frmHome();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    frmCarServices services = new frmCarServices();
                    services.Show();
                }
            }
            else if (chkRoadTax.Checked == false && chkMOT.Checked)
            {
                command = new SQLiteCommand(queryMOT, conn);

                if (cmbMOTDuration.Text != "")
                {
                    command.Parameters.AddWithValue("@id", _serviceId);
                    command.Parameters.AddWithValue("@car", cmbCar.Text);
                    command.Parameters.AddWithValue("@MOT", dateTimeMOT.Value.Date);
                    command.Parameters.AddWithValue("@MOTDuration", cmbMOTDuration.Text);
                    command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Service Added", "Service Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

                    // Reminders Add

                    string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn, ServiceId) " +
                    "VALUES (@id, @type, @car, @customer, @notes, @dueOn, @serviceId)";

                    conn.Close();

                    GetReminderId();

                    conn.Open();

                    command = new SQLiteCommand(queryReminder, conn);

                    command.Parameters.AddWithValue("@id", _reminderId);
                    command.Parameters.AddWithValue("@type", "MOT Due");
                    command.Parameters.AddWithValue("@car", cmbCar.Text.ToUpper());
                    command.Parameters.AddWithValue("@customer", "N/A");
                    command.Parameters.AddWithValue("@notes", "N/A");
                    command.Parameters.AddWithValue("@dueOn", GetMOTDate(dateTimeMOT.Value).Date);
                    command.Parameters.AddWithValue("@serviceId", _serviceId);

                    command.ExecuteNonQuery();

                    conn.Close();

                    frmHome home = new frmHome();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a duration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    frmCarServices services = new frmCarServices();
                    services.Show();
                }
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

        public DateTime GetRoadTaxDate(DateTime roadTaxStartDate)
        {
            DateTime roadTaxEndDate = new DateTime();
            string duration = cmbRTDuration.Text;

            switch (duration)
            {
                case "3 Months":
                    roadTaxEndDate = roadTaxStartDate.AddMonths(3);
                    break;
                case "6 Months":
                    roadTaxEndDate = roadTaxStartDate.AddMonths(6);
                    break;
                case "9 Months":
                    roadTaxEndDate = roadTaxStartDate.AddMonths(9);
                    break;
                case "12 Months":
                    roadTaxEndDate = roadTaxStartDate.AddMonths(12);
                    break;
                default:
                    break;
            }

            return roadTaxEndDate;
        }

        public DateTime GetMOTDate(DateTime MOTStartDate)
        {
            DateTime MOTEndDate = new DateTime();
            string duration = cmbMOTDuration.Text;

            switch (duration)
            {
                case "1 Year":
                    MOTEndDate = MOTStartDate.AddYears(1);
                    break;
                case "2 Years":
                    MOTEndDate = MOTStartDate.AddYears(2);
                    break;
                default:
                    break;
            }

            return MOTEndDate;
        }

        private void frmServices_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\jzissimou\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture"))
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
                dateTimeRoadTax.Enabled = false;
                cmbRTDuration.Enabled = false;
            }
            else
            {
                dateTimeRoadTax.Enabled = true;
                cmbRTDuration.Enabled = true;
            }
        }

        private void chkMOT_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMOT.Checked)
            {
                dateTimeMOT.Enabled = false;
                cmbMOTDuration.Enabled = false;
            }
            else
            {
                dateTimeMOT.Enabled = true;
                cmbMOTDuration.Enabled = true;
            }
        }
    }
}
