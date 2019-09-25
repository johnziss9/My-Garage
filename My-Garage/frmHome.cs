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
    }
}
