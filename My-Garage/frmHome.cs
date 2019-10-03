using System;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCarRegistration_Click(object sender, EventArgs e)
        {
            Hide();
            frmCarRegistration carRegistration = new frmCarRegistration();
            carRegistration.Show();
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            Hide();
            frmCustomerRegistration customerRegistration = new frmCustomerRegistration();
            customerRegistration.Show();
        }

        private void btnCarRental_Click(object sender, EventArgs e)
        {
            Hide();
            frmCarRental carRental = new frmCarRental();
            carRental.Show();
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            Hide();
            frmReminders reminders = new frmReminders();
            reminders.Show();
        }

        private void btnFutureReminders_Click(object sender, EventArgs e)
        {
            Hide();
            frmFutureReminders futureReminders = new frmFutureReminders();
            futureReminders.Show();
        }

        private void btnCarServices_Click_1(object sender, EventArgs e)
        {
            Hide();
            frmServices services = new frmServices();
            services.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Hide();
            frmSearch search = new frmSearch();
            search.Show();
        }
    }
}
