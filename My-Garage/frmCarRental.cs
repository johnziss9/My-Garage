﻿using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCarRental : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\jzissimou\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture");
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
            Hide();

            string query = "INSERT INTO Rentals(Id, FromDate, ToDate, Customer, Car, Notes) " +
                "VALUES (@id, @fromDate, @toDate, @customer, @car, @notes)";

            GetRentalId();

            conn.Open();

            command = new SQLiteCommand(query, conn);

            command.Parameters.AddWithValue("@id", _rentalId);
            command.Parameters.AddWithValue("@fromDate", dateTimeFrom.Value.Date);
            command.Parameters.AddWithValue("@toDate", dateTimeTo.Value.Date);
            command.Parameters.AddWithValue("@customer", cmbCustomer.Text);
            command.Parameters.AddWithValue("@car", cmbCar.Text);
            command.Parameters.AddWithValue("@notes", txtNotes.Text);

            command.ExecuteNonQuery();

            // Reminders Add

            string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn) " +
                "VALUES (@id, @type, @car, @customer, @notes, @dueOn)";


            conn.Close();

            GetReminderId();

            conn.Open();

            command = new SQLiteCommand(queryReminder, conn);

            command.Parameters.AddWithValue("@id", _reminderId);
            command.Parameters.AddWithValue("@type", "Rental Car");
            command.Parameters.AddWithValue("@car", cmbCar.Text);
            command.Parameters.AddWithValue("@customer", cmbCustomer.Text);
            command.Parameters.AddWithValue("@notes", txtNotes.Text);
            command.Parameters.AddWithValue("@dueOn", dateTimeTo.Value.Date);

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
            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\jzissimou\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture"))
            {
                try
                {
                    string carQuery = "SELECT Id, CarMake, CarModel, (CarMake || ' ' || CarModel) AS Car FROM Cars";
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
    }
}
