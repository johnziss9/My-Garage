using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCarRental : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture");
        SQLiteCommand command;
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();

        int _rentalId = 0;
        int _reminderId = 0;

        public frmCarRental()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (dateTimeFrom.Value > dateTimeTo.Value)
                MessageBox.Show("Η 'Μέχρι' ημερομηνία πρέπει να είναι μεγαλύτερη από την 'Από' ημερομηνία.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (cmbCustomer.Text == "")
                    MessageBox.Show("Καταχωρίστε τον πελάτη.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (cmbCar.Text == "")
                        MessageBox.Show("Καταχωρίστε το αυτοκίνητο.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (CheckOngoingRental((int)cmbCar.SelectedValue) == true)
                            MessageBox.Show($"Το όχημα έχει ενοικιασμένο.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            Hide();

                            string query = "INSERT INTO Rentals(Id, FromDate, ToDate, Customer, Car, Notes, CarId, Rented) " +
                                "VALUES (@id, @fromDate, @toDate, @customer, @car, @notes, @carId, @rented)";

                            GetRentalId();

                            conn.Open();

                            command = new SQLiteCommand(query, conn);

                            command.Parameters.AddWithValue("@id", _rentalId);
                            command.Parameters.AddWithValue("@fromDate", dateTimeFrom.Value.Date);
                            command.Parameters.AddWithValue("@toDate", dateTimeTo.Value.Date);
                            command.Parameters.AddWithValue("@customer", cmbCustomer.Text);
                            command.Parameters.AddWithValue("@car", cmbCar.Text);
                            command.Parameters.AddWithValue("@notes", txtNotes.Text);
                            command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);
                            command.Parameters.AddWithValue("@rented", true);

                            command.ExecuteNonQuery();

                            string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn, CarId, Rented, Renewal) " +
                                "VALUES (@id, @type, @car, @customer, @notes, @dueOn, @carId, @rented, @renewal)";

                            // Add Reminder

                            conn.Close();

                            GetReminderId();

                            conn.Open();

                            command = new SQLiteCommand(queryReminder, conn);

                            command.Parameters.AddWithValue("@id", _reminderId);
                            command.Parameters.AddWithValue("@type", "Ενοικίαση");
                            command.Parameters.AddWithValue("@car", cmbCar.Text);
                            command.Parameters.AddWithValue("@customer", cmbCustomer.Text);
                            command.Parameters.AddWithValue("@notes", txtNotes.Text);
                            command.Parameters.AddWithValue("@dueOn", dateTimeTo.Value.Date);
                            command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);
                            command.Parameters.AddWithValue("@rented", true);
                            command.Parameters.AddWithValue("@renewal", null);

                            command.ExecuteNonQuery();

                            conn.Close();

                            MessageBox.Show("Η ενοικίαση έχει προστεθεί.", "Πρόσθεση Ενοικίασης", MessageBoxButtons.OK, MessageBoxIcon.None);

                            frmHome home = new frmHome();
                            home.Show();
                        }
                    }
                }
            }
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

        private void frmCarRental_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture"))
            {
                try
                {
                    string carQuery = "SELECT Id, CarMake, CarModel, (CarMake || ' ' || CarModel || ' (' || NumberPlate || ')') AS Car FROM Cars";
                    string customerQuery = "SELECT Id, FirstName, LastName, (FirstName || ' ' || LastName) AS [Name] FROM Customers";

                    SQLiteDataAdapter daCars = new SQLiteDataAdapter(carQuery, conn);
                    SQLiteDataAdapter daCustomers = new SQLiteDataAdapter(customerQuery, conn);

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
            string query = "SELECT Id FROM Rentals ORDER BY Id DESC LIMIT 1";

            conn.Open();

            using (SQLiteCommand command = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        _rentalId = dr.GetInt32(0) + 1;
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

        private bool CheckOngoingRental(int carId)
        {
            bool ongoingRental = false;

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture"))
            {
                try
                {
                    string checkOngoingRentalQuery = $"SELECT * FROM Reminders WHERE CarId = {carId} AND Type = 'Ενοικίαση' AND Rented = true";

                    command = new SQLiteCommand(checkOngoingRentalQuery, conn);

                    conn.Open();

                    SQLiteDataReader dr = command.ExecuteReader();

                    if (dr.HasRows)
                        ongoingRental = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured!");
                }
            }

            return ongoingRental;
        }
    }
}
