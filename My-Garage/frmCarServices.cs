﻿using System;
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
        }        

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (cmbCar.Text == "")
                MessageBox.Show("Please select a car.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (cmbService.Text == "")
                    MessageBox.Show("Please select a service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (dateTimeFrom.Value > dateTimeTo.Value)
                        MessageBox.Show("From date should be greater than to date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        Hide();

                        // Service Add

                        string queryServices = "INSERT INTO CarServices (Id, Car, Type, FromDate, ToDate, CarId, Renewal) " +
                            "VALUES (@id, @car, @type, @from, @to, @carId, @renewal)";

                        GetServiceId();

                        conn.Open();

                        if (cmbService.Text == "Άδεια Κυκλοφορίας")
                        {
                            command = new SQLiteCommand(queryServices, conn);

                            command.Parameters.AddWithValue("@id", _serviceId);
                            command.Parameters.AddWithValue("@car", cmbCar.Text);
                            command.Parameters.AddWithValue("@type", "Άδεια Κυκλοφορίας");
                            command.Parameters.AddWithValue("@from", dateTimeFrom.Value.Date);
                            command.Parameters.AddWithValue("@to", dateTimeTo.Value.Date);
                            command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);
                            command.Parameters.AddWithValue("@renewal", false);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Service Added", "Service Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

                            AddReminder("Άδεια Κυκλοφορίας");
                        }
                        else if (cmbService.Text == "M.O.T.")
                        {
                            command = new SQLiteCommand(queryServices, conn);

                            command.Parameters.AddWithValue("@id", _serviceId);
                            command.Parameters.AddWithValue("@car", cmbCar.Text);
                            command.Parameters.AddWithValue("@type", "M.O.T.");
                            command.Parameters.AddWithValue("@from", dateTimeFrom.Value.Date);
                            command.Parameters.AddWithValue("@to", dateTimeTo.Value.Date);
                            command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);
                            command.Parameters.AddWithValue("@renewal", false);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Service Added", "Service Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

                            AddReminder("M.O.T.");
                        }
                    }
                }
            }
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

        public void AddReminder(string serviceType)
        {
            string queryReminder = "INSERT INTO Reminders (Id, Type, Car, Customer, Notes, DueOn, CarId, Rented, Returned, Renewal) " +
            "VALUES (@id, @type, @car, @customer, @notes, @dueOn, @carId, @rented, @returned, @renewal)";

            conn.Close();

            GetReminderId();

            conn.Open();

            command = new SQLiteCommand(queryReminder, conn);

            command.Parameters.AddWithValue("@id", _reminderId);
            command.Parameters.AddWithValue("@type", serviceType);
            command.Parameters.AddWithValue("@car", cmbCar.Text.ToUpper());
            command.Parameters.AddWithValue("@customer", "N/A");
            command.Parameters.AddWithValue("@notes", "N/A");
            command.Parameters.AddWithValue("@dueOn", dateTimeTo.Value.Date);
            command.Parameters.AddWithValue("@carId", cmbCar.SelectedValue);
            command.Parameters.AddWithValue("@rented", null);
            command.Parameters.AddWithValue("@returned", null);
            command.Parameters.AddWithValue("@renewal", false);

            command.ExecuteNonQuery();

            conn.Close();

            frmHome home = new frmHome();
            home.Show();
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
    }
}
