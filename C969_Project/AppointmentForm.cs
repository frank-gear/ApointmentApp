using System;

using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class AppointmentForm : Form
    {
        public static int setRow;
        DataTable table = new DataTable();
        DateTime currdt;
        public AppointmentForm()
        {
            InitializeComponent();
            currdt = DateTime.Now;
            AppointmentMonthCalendar1.AddBoldedDate(currdt);
            Day();
            
        }
        private void week()
        {
            AppointmentMonthCalendar1.RemoveAllBoldedDates();
            table.Clear();
            int dw = (int)currdt.DayOfWeek;
            string start = currdt.AddDays(-dw).ToString();
            DateTime temp = Convert.ToDateTime(start);
            for (int i =0; i<7; i++)
            {
                AppointmentMonthCalendar1.AddBoldedDate(temp.AddDays(i));
            }
            AppointmentMonthCalendar1.UpdateBoldedDates();
            string end = currdt.AddDays(7 - dw).ToString();
            string sqlcmd = $"SELECT * FROM appointment WHERE start BETWEEN = DATE('{start}') AND DATE('{end}')";
            DataClass.sqlConnection.Open();
            MySqlCommand command = new MySqlCommand(sqlcmd, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            AppointmentdataGridView1.DataSource = table;
            DataClass.sqlConnection.Close();

        }
        private void Day()
        {
            AppointmentMonthCalendar1.RemoveAllBoldedDates();
            AppointmentMonthCalendar1.AddBoldedDate(currdt);
            table.Clear();
            string sqlcmd = $"SELECT * FROM appointment WHERE start = DATE('{currdt}')";
            DataClass.sqlConnection.Open();           
            MySqlCommand command = new MySqlCommand(sqlcmd, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            AppointmentdataGridView1.DataSource = table;
            DataClass.sqlConnection.Close();
        }
        private void ConnectData()
        {
            DataClass.sqlConnection.Open();
            string sqlcon = "SELECT * FROM appointment";
            MySqlCommand command = new MySqlCommand(sqlcon, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);            
            adapter.Fill(table);
            AppointmentdataGridView1.DataSource = table;
            DataClass.sqlConnection.Close();
        }

        private void returntorecordsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteAppointmentBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Delete?", "Delete Part", MessageBoxButtons.YesNo);
            setRow = Convert.ToInt32(AppointmentdataGridView1.Rows[AppointmentdataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            if (setRow != -1)
            {
                if (dialog == DialogResult.Yes)
                {
                    string sqlcmd = $" DELETE FROM appointment WHERE appointmentId = '{setRow}'";
                    DataClass.DataWrite(sqlcmd);
                    ConnectData();

                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete", "Error");
            }
        }

        private void ModifyAppointmentBtn_Click(object sender, EventArgs e)
        {
            setRow = Convert.ToInt32(AppointmentdataGridView1.Rows[AppointmentdataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            ModifyAppointmentForm.select = setRow;
            this.Close();
            ModifyAppointmentForm modifyAppointment = new ModifyAppointmentForm();
            modifyAppointment.Show();
            

        }

        private void AddApointmentBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();
            addAppointmentForm.Show();
        }

        private void AppointmentMonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            currdt = AppointmentMonthCalendar1.SelectionStart;
            Day();
        }
    }
}
