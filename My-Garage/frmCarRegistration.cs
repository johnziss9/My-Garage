using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCarRegistration : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture");
        SQLiteCommand command;
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();

        int _carId = 0;

        public frmCarRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtCarMake.Text == "" || txtCarModel.Text == "" || txtNumberPlate.Text == "" || txtVNumber.Text == "")
                MessageBox.Show("Please enter the car make, model and number plate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            { 
                Hide();

                string query = "INSERT INTO Cars (Id, CarMake, CarModel, NumberPlate, VNumber) " +
                    "VALUES (@id, @carMake, @carModel, @numberPlate, @vNumber)";

                GetCarId();

                conn.Open();

                command = new SQLiteCommand(query, conn);

                command.Parameters.AddWithValue("@id", _carId);
                command.Parameters.AddWithValue("@carMake", txtCarMake.Text.ToUpper());
                command.Parameters.AddWithValue("@carModel", txtCarModel.Text.ToUpper());
                command.Parameters.AddWithValue("@numberPlate", txtNumberPlate.Text.ToUpper());
                command.Parameters.AddWithValue("@vNumber", txtVNumber.Text.ToUpper());

                command.ExecuteNonQuery();

                MessageBox.Show("Car Added", "Car Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

                conn.Close();

                frmHome home = new frmHome();
                home.Show();
            }
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

        private void txtCarMake_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtCarModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txtNumberPlate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
