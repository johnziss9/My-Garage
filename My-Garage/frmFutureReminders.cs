using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmFutureReminders : Form
    {
        public frmFutureReminders()
        {
            InitializeComponent();
        }

        private void frmFutureReminders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDone_Click(object sender, System.EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void frmFutureReminders_Shown(object sender, System.EventArgs e)
        {
            ShowFutureReminders();
        }

        public void ShowFutureReminders()
        {
            string sqlConnection = "Data Source=.;Initial Catalog=GarageDB; Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(sqlConnection);

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            BindingSource bs = new BindingSource();

            dt = new DataTable();
            da = new SqlDataAdapter("SELECT * FROM Reminders WHERE DueOn > GETDATE()", conn);

            da.Fill(dt);
            bs.DataSource = dt;
            dataGridFutureReminders.DataSource = bs;

            dataGridFutureReminders.Columns[0].Visible = false;
            dataGridFutureReminders.Columns[2].Visible = false;
        }
    }
}
