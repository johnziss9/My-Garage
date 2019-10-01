using System.Data;
using System.Data.SQLite;
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
            string connString = @"Data Source=C:\Users\jzissimou\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture";
            SQLiteConnection conn = new SQLiteConnection(connString);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            BindingSource bs = new BindingSource();

            dt = new DataTable();
            da = new SQLiteDataAdapter("SELECT * FROM Reminders WHERE DueOn > DATE('now', '+1 day')", conn);

            da.Fill(dt);
            bs.DataSource = dt;
            dataGridFutureReminders.DataSource = bs;

            dataGridFutureReminders.Columns[0].Visible = false;
        }
    }
}
