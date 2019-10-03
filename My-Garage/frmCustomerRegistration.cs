using System;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SQLite;

namespace My_Garage
{
    public partial class frmCustomerRegistration : Form
    {
        SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture");
        SQLiteCommand command;
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();

        int _customerId = 0;

        public frmCustomerRegistration()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void frmCustomerRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();

            string query = "INSERT INTO Customers (Id, FirstName, LastName, Address, Phone) " +
                "VALUES (@id, @firstName, @lastName, @address, @phoneNumber)";

            GetCustomerId();

            conn.Open();

            command = new SQLiteCommand(query, conn);

            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtPhoneNo.Text == "")
                MessageBox.Show("Please fill in all the details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                command.Parameters.AddWithValue("@id", _customerId);
                command.Parameters.AddWithValue("@firstName", txtFirstName.Text.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + txtFirstName.Text.Substring(1));
                command.Parameters.AddWithValue("@lastName", txtLastName.Text.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + txtLastName.Text.Substring(1));
                command.Parameters.AddWithValue("@address", txtAddress.Text.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + txtAddress.Text.Substring(1));
                command.Parameters.AddWithValue("@phoneNumber", txtPhoneNo.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Customer Added", "Customer Addition", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            conn.Close();

            frmHome home = new frmHome();
            home.Show();
        }

        public void GetCustomerId()
        {
            conn.Open();

            string query = "SELECT Id FROM Customers ORDER BY Id DESC LIMIT 1";

            using (SQLiteCommand command = new SQLiteCommand(query, conn))
            {
                using (SQLiteDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        _customerId = dr.GetInt32(0) + 1;
                    }
                }
            }

            conn.Close();
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
