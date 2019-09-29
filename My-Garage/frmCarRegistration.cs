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

        public frmCarRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();

            string query = "INSERT INTO dbo.Cars (Id, CarMake, CarModel, NumberPlate, RoadTax, RoadTaxDuration, MOT, MOTDuration) " +
                "VALUES (@id, @carMake, @carModel, @numberPlate, @roadTax, @roadTaxDuration, @MOT, @MOTDuration)";

            GetCarId();

            conn.Open();

            command = new SqlCommand(query, conn);

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
    }
}
