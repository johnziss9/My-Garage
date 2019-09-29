using System;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCustomerRegistration : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=GarageDB; Integrated Security=SSPI");
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

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

            string query = "INSERT INTO dbo.Customers (Id, FirstName, LastName, Address, Phone) VALUES (@id, @firstName, @lastName, @address, @phoneNumber)";

            GetCustomerId();

            conn.Open();

            command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@id", _customerId);
            command.Parameters.AddWithValue("@firstName", txtFirstName.Text.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + txtFirstName.Text.Substring(1));
            command.Parameters.AddWithValue("@lastName", txtLastName.Text.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + txtLastName.Text.Substring(1));
            command.Parameters.AddWithValue("@address", txtAddress.Text.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + txtAddress.Text.Substring(1));
            command.Parameters.AddWithValue("@phoneNumber", txtPhoneNo.Text);

            if (txtFirstName.Text == "" || txtLastName.Text == "")
                MessageBox.Show("Please enter a first and last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                command.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Customer Added", "Customer Addition", MessageBoxButtons.OK, MessageBoxIcon.None);

            frmHome home = new frmHome();
            home.Show();
        }

        public void GetCustomerId()
        {
            using (command = new SqlCommand("SELECT TOP 1 [Id] FROM dbo.Customers ORDER BY Id DESC", conn))
            {
                conn.Open();
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    _customerId = Convert.ToInt32(dr["Id"]) + 1;
                }
                else
                {
                    _customerId = 101;
                }
                conn.Close();
            }
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
