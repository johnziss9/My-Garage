using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCarRental : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GarageDB; Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        int _rentalId = 0;
        int _reminderId = 0;

        public frmCarRental()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();

            string query = "INSERT INTO dbo.Rentals(Id, FromDate, ToDate, Customer, Car, Notes) " +
                "VALUES (@id, @fromDate, @toDate, @customer, @car, @notes)";

            GetRentalId();

            conn.Open();

            command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@id", _rentalId);
            command.Parameters.AddWithValue("@fromDate", dateTimeFrom.Value);
            command.Parameters.AddWithValue("@toDate", dateTimeTo.Value);
            command.Parameters.AddWithValue("@customer", cmbCustomer.Text);
            command.Parameters.AddWithValue("@car", cmbCar.Text);
            command.Parameters.AddWithValue("@notes", txtNotes.Text);

            command.ExecuteNonQuery();

            // Reminders Add

            string queryReminder = "INSERT INTO dbo.Reminders (Id, Type, Car, Customer, Notes, DueOn) " +
                "VALUES (@id, @type, @car, @customer, @notes, @dueOn)";


            conn.Close();

            GetReminderId();

            conn.Open();

            command = new SqlCommand(queryReminder, conn);

            command.Parameters.AddWithValue("@id", _reminderId);
            command.Parameters.AddWithValue("@type", "Rental Car");
            command.Parameters.AddWithValue("@car", cmbCar.Text);
            command.Parameters.AddWithValue("@customer", cmbCustomer.Text);
            command.Parameters.AddWithValue("@notes", txtNotes.Text);
            command.Parameters.AddWithValue("@dueOn", dateTimeTo.Value);

            command.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Rental Added", "Rental Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

            frmHome home = new frmHome();
            home.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void frmCarRental_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimeTo_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeFrom.Value > dateTimeTo.Value)
            {
                MessageBox.Show("Date should be after From date.");
                dateTimeTo.Value = DateTime.Now;
            }
        }

        private void frmCarRental_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=GarageDB; Integrated Security=SSPI"))
            {
                try
                {
                    string carQuery = "SELECT Id, CarMake, CarModel, CarMake + ' ' + CarModel AS [Car] FROM Cars";
                    string customerQuery = "SELECT Id, FirstName, LastName, FirstName + ' ' + LastName AS [Name] FROM Customers";

                    SqlDataAdapter daCars = new SqlDataAdapter(carQuery, conn);
                    SqlDataAdapter daCustomers = new SqlDataAdapter(customerQuery, conn);

                    conn.Open();

                    DataSet dsCars = new DataSet();
                    DataSet dsCustomers = new DataSet();

                    daCars.Fill(dsCars, "Cars");
                    daCustomers.Fill(dsCustomers, "Customers");

                    cmbCar.DisplayMember = "Car";
                    cmbCar.ValueMember = "Id";
                    cmbCar.DataSource = dsCars.Tables["Cars"];

                    cmbCustomer.DisplayMember = "Name";
                    cmbCustomer.ValueMember = "Id";
                    cmbCustomer.DataSource = dsCustomers.Tables["Customers"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
            }
        }

        public void GetRentalId()
        {
            using (command = new SqlCommand("SELECT TOP 1 [Id] FROM dbo.Rentals ORDER BY Id DESC", conn))
            {
                conn.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    _rentalId = Convert.ToInt32(dr["Id"]) + 1;
                }
                else
                {
                    _rentalId = 1;
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
    }
}
