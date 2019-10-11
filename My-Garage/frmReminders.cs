using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace My_Garage
{
    public partial class frmReminders : Form
    {
        public frmReminders()
        {
            InitializeComponent();
        }

        private void frmReminders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Hide();
            frmHome home = new frmHome();
            home.Show();
        }

        private void frmReminders_Shown(object sender, EventArgs e)
        {
            ShowReminders();
        }

        private void ShowReminders()
        {
            string connString = @"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture";
            SQLiteConnection conn = new SQLiteConnection(connString);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            BindingSource bs = new BindingSource();

            dt = new DataTable();
            da = new SQLiteDataAdapter("SELECT * FROM Reminders WHERE DueOn <= DATE('now', '+1 day')", conn);

            da.Fill(dt);
            bs.DataSource = dt;
            dataGridReminders.DataSource = bs;

            dataGridReminders.Columns[0].Visible = false;

            foreach (DataGridViewRow row in dataGridReminders.Rows)
            {
                var date = Convert.ToDateTime(row.Cells[5].Value);

                if (date < DateTime.Now.AddDays(-1))
                    row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dataGridReminders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var reminderId = dataGridReminders.SelectedRows[0].Cells[0].Value.ToString();
            string query = $"DELETE FROM Reminders WHERE Id = {reminderId}";

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\johnz\Downloads\GarageDB.db; Version = 3; datetimeformat = CurrentCulture"))
            {
                conn.Open();

                SQLiteCommand command = new SQLiteCommand();

                command = new SQLiteCommand(query, conn);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this reminder?", "Delete Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    command.ExecuteNonQuery();
                    ShowReminders();
                }
            }
        }
    }
}
