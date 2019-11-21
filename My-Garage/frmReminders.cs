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

            dataGridReminders.Columns[1].HeaderText = "Τύπος";
            dataGridReminders.Columns[2].HeaderText = "Αυτοκίνητο";
            dataGridReminders.Columns[3].HeaderText = "Πελάτης";
            dataGridReminders.Columns[4].HeaderText = "Σημειώσεις";
            dataGridReminders.Columns[4].HeaderText = "Επιστροφή";
        }

        private void ShowReminders()
        {
            string connString = @"Data Source=C:\Users\johnz\Downloads\GarageDB.db;Version=3;datetimeformat=CurrentCulture";
            SQLiteConnection conn = new SQLiteConnection(connString);

            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter();
            BindingSource bs = new BindingSource();

            dt = new DataTable();
            da = new SQLiteDataAdapter("SELECT * FROM Reminders WHERE (((Type = 'Άδεια Κυκλοφορίας' OR Type = 'M.O.T.') " +
                "AND(DueOn <= DATE('now', '+21 day')) AND Renewal = false) OR(Type = 'Ενοικίαση' AND(DueOn <= DATE('now', '+6 day')) " +
                "AND Rented = true))", conn);

            da.Fill(dt);
            bs.DataSource = dt;
            dataGridReminders.DataSource = bs;

            dataGridReminders.Columns[0].Visible = false;
            dataGridReminders.Columns[6].Visible = false;
            dataGridReminders.Columns[7].Visible = false;
            dataGridReminders.Columns[8].Visible = false;
            dataGridReminders.Columns[9].Visible = false;

            foreach (DataGridViewRow row in dataGridReminders.Rows)
            {
                var date = Convert.ToDateTime(row.Cells[5].Value);

                if (date < DateTime.Now.AddDays(-1))
                    row.DefaultCellStyle.BackColor = Color.Red;
            }
        }

        private void dataGridReminders_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var type = dataGridReminders.SelectedRows[0].Cells[1].Value.ToString();
            var carId = dataGridReminders.SelectedRows[0].Cells[6].Value.ToString();

            string servicesQuery = $"UPDATE CarServices SET Renewal = true WHERE Type = '{type}' AND Renewal = false AND CarId = {carId}";
            string servicesReminderQuery = $"UPDATE Reminders SET Renewal = true WHERE Type = '{type}' AND Renewal = false AND CarId = {carId}";
            string rentalQuery = $"UPDATE Rentals SET Rented = false, Returned = true WHERE CarId = {carId}";
            string rentalReminderQuery = $"UPDATE Reminders SET Rented = false, Returned = true WHERE CarId = {carId} AND Type = 'Ενοικίαση'";

            using (SQLiteConnection conn = new SQLiteConnection(@"Data Source = C:\Users\johnz\Downloads\GarageDB.db; Version = 3; datetimeformat = CurrentCulture"))
            {
                conn.Open();

                SQLiteCommand command = new SQLiteCommand();

                if (type == "Άδεια Κυκλοφορίας" || type == "M.O.T.")
                {
                    string sentenceStart = type == "Άδεια Κυκλοφορίας" ? "Η" : "Το";

                    DialogResult dialogResult = MessageBox.Show($"{sentenceStart} {type} θα διαγραφεί. Έχει ανανεωθει;", "Διαγραφή Άδειας Κυκλοφορίας", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        command = new SQLiteCommand(servicesQuery, conn);

                        command.ExecuteNonQuery();

                        command = new SQLiteCommand(servicesReminderQuery, conn);

                        command.ExecuteNonQuery();

                        ShowReminders();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Η ενοικίαση θα διαγραφεί. Έχει επιστρέψει το αυτοκίνητο;", "Διαγραφή Ενοικίασης", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        command = new SQLiteCommand(rentalQuery, conn);

                        command.ExecuteNonQuery();

                        command = new SQLiteCommand(rentalReminderQuery, conn);

                        command.ExecuteNonQuery();

                        ShowReminders();
                    }
                }
            }
        }
    }
}
