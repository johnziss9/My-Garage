using System;
using System.Data.SqlClient;
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
            frmHome home = new frmHome();
            home.Show();

            string query = "INSERT INTO dbo.Customers (Id, FirstName, LastName, Address, Phone) VALUES (@id, @firstName, @lastName, @address, @phoneNumber)";

            GetCustomerId();

            conn.Open();

            command = new SqlCommand(query, conn);

            command.Parameters.AddWithValue("@id", _customerId);
            command.Parameters.AddWithValue("@firstName", txtFirstName.Text);
            command.Parameters.AddWithValue("@lastName", txtLastName.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);
            command.Parameters.AddWithValue("@phoneNumber", txtPhoneNo.Text);

            if (txtFirstName.Text == "" || txtLastName.Text == "")
                MessageBox.Show("Please enter a first and last name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                command.ExecuteNonQuery();

            conn.Close();
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
