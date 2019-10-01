using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCarRegistration : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\jzissimou\Downloads\GarageDB.db;Version=3;");
        SQLiteCommand command;
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();

        int _carId = 0;
        int _reminderId = 0;

        public frmCarRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();

            // Cars Add

            string queryCar = "INSERT INTO Cars (Id, CarMake, CarModel, NumberPlate, RoadTax, RoadTaxDuration, MOT, MOTDuration) " +
                "VALUES (@id, @carMake, @carModel, @numberPlate, @roadTax, @roadTaxDuration, @MOT, @MOTDuration)";

            GetCarId();

            conn.Open();

            command = new SQLiteCommand(queryCar, conn);

            command.Parameters.AddWithValue("@id", _carId);
            command.Parameters.AddWithValue("@carMake", txtCarMake.Text.ToUpper());
            command.Parameters.AddWithValue("@carModel", txtCarModel.Text.ToUpper());
            command.Parameters.AddWithValue("@numberPlate", txtNumberPlate.Text.ToUpper());
            command.Parameters.AddWithValue("@roadTax", dateTimeRoadTax.Value);
            command.Parameters.AddWithValue("@roadTaxDuration", cmbRTDuration.Text);
            command.Parameters.AddWithValue("@MOT", dateTimeMOT.Value);
            command.Parameters.AddWithValue("@MOTDuration", cmbMOTDuration.Text);

            if (txtCarMake.Text == "" || txtCarModel.Text == "")
                MessageBox.Show("Please enter the car make and model.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                command.ExecuteNonQuery();

            // Reminders Add

            if (cmbRTDuration.Text != "" || cmbMOTDuration.Text != "")
            {
                string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn) " +
                "VALUES (@id, @type, @car, @customer, @notes, @dueOn)";


                for (int i = 0; i < 2; i++)
                {
                    conn.Close();

                    GetReminderId();

                    conn.Open();

                    command = new SQLiteCommand(queryReminder, conn);

                    command.Parameters.AddWithValue("@id", _reminderId);
                    command.Parameters.AddWithValue("@type", i == 0 ? "Road Tax Due" : "MOT Due");
                    command.Parameters.AddWithValue("@car", txtCarMake.Text.ToUpper() + " " + txtCarModel.Text.ToUpper());
                    command.Parameters.AddWithValue("@customer", "N/A");
                    command.Parameters.AddWithValue("@notes", "N/A");
                    command.Parameters.AddWithValue("@dueOn", i == 0 ? GetRoadTaxDate(dateTimeRoadTax.Value) : GetMOTDate(dateTimeMOT.Value));

                    command.ExecuteNonQuery();
                }
            }

            conn.Close();

            MessageBox.Show("Car Added", "Car Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

            frmHome home = new frmHome();
            home.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void frmCarRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void GetCarId()
        {
            string query = "SELECT Id FROM Cars ORDER BY Id DESC LIMIT 1";

            conn.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        _carId = dr.GetInt32(0) + 1;
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
                    roadTaxEndDate = roadTaxStartDate.AddMonths(3);
                    break;
                case "9 Months":
                    roadTaxEndDate = roadTaxStartDate.AddMonths(3);
                    break;
                case "12 Months":
                    roadTaxEndDate = roadTaxStartDate.AddMonths(3);
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
    }
}
