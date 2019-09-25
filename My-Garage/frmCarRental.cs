using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmCarRental : Form
    {
        public frmCarRental()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();

            // TODO Code for saving the customer goes here

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
    }
}
