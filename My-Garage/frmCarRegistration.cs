using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCarRegistration : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GarageDB; Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        int _carId = 0;
        int _reminderId = 0;

        public frmCarRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();

            // Cars Add

            string queryCar = "INSERT INTO dbo.Cars (Id, CarMake, CarModel, NumberPlate, RoadTax, RoadTaxDuration, MOT, MOTDuration) " +
                "VALUES (@id, @carMake, @carModel, @numberPlate, @roadTax, @roadTaxDuration, @MOT, @MOTDuration)";

            GetCarId();

            conn.Open();

            command = new SqlCommand(queryCar, conn);

            command.Parameters.AddWithValue("@id", _carId);
            command.Parameters.AddWithValue("@carMake", txtCarMake.Text);
            command.Parameters.AddWithValue("@carModel", txtCarModel.Text);
            command.Parameters.AddWithValue("@numberPlate", txtNumberPlate.Text);
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
                string queryReminder = "INSERT INTO dbo.Reminders (Id, Type, Car, Customer, Notes, DueOn) " +
                "VALUES (@id, @type, @car, @customer, @notes, @dueOn)";


                for (int i = 0; i < 2; i++)
                {
                    conn.Close();

                    GetReminderId();

                    conn.Open();

                    command = new SqlCommand(queryReminder, conn);

                    command.Parameters.AddWithValue("@id", _reminderId);
                    command.Parameters.AddWithValue("@type", i == 0 ? "Road Tax Due" : "MOT Due");
                    command.Parameters.AddWithValue("@car", txtCarMake.Text);
                    command.Parameters.AddWithValue("@customer", "NA");
                    command.Parameters.AddWithValue("@notes", "NA");
                    command.Parameters.AddWithValue("@dueOn", i == 0 ? GetRoadTaxDate(dateTimeRoadTax.Value) : GetMOTDate(dateTimeMOT.Value));

                    command.ExecuteNonQuery();
                }
            }

            conn.Close();
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
            using (command = new SqlCommand("SELECT TOP 1 [Id] FROM dbo.Cars ORDER BY Id DESC", conn))
            {
                conn.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    _carId = Convert.ToInt32(dr["Id"]) + 1;
                }
                else
                {
                    _carId = 1;
                }
                conn.Close();
            }
        }

        public void GetReminderId()
        {
            using (command = new SqlCommand("SELECT TOP 1 [Id] FROM dbo.Reminders ORDER BY Id DESC", conn))
            {
                conn.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    _reminderId = Convert.ToInt32(dr["Id"]) + 1;
                }
                else
                {
                    _reminderId = 1001;
                }
                conn.Close();
            }
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
                case "10 Months":
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
