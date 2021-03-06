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
            day();
            
        }

        private void day()
        {
            //currdt = AppointmentMonthCalendar1.SelectionStart;
            AppointmentMonthCalendar1.RemoveAllBoldedDates();
            //AppointmentMonthCalendar1.AddBoldedDate(currdt);
            //AppointmentMonthCalendar1.UpdateBoldedDates();
            table.Clear();
            string date = currdt.ToString("yyyy-MM-dd");
            string sqlcmd = "SELECT appointment.appointmentId, appointment.title, appointment.type,  appointment.start, appointment.end,  customer.customerName, user.userName FROM((appointment INNER JOIN customer ON customer.customerId = appointment.customerId) INNER JOIN user ON appointment.userId = user.userId); "; //WHERE start like '{date}%'";
            MySqlCommand command = new MySqlCommand(sqlcmd, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            AppointmentdataGridView1.DataSource = table;
            DataClass.sqlConnection.Close();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                table.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i]["end"], TimeZoneInfo.Local).ToString();
            }

        }
        private void week()
        {
            AppointmentMonthCalendar1.RemoveAllBoldedDates();
            table.Clear();
            int dw = (int)currdt.DayOfWeek;
            string start = currdt.AddDays(-dw).ToString("yyyy-MM-dd HH:mm:ss");
            DateTime temp = Convert.ToDateTime(start);
            for (int i =0; i<7; i++)
            {
                AppointmentMonthCalendar1.AddBoldedDate(temp.AddDays(i));
            }
            AppointmentMonthCalendar1.UpdateBoldedDates();
            string end = currdt.AddDays(7 - dw).ToString("yyyy-MM-dd HH:mm:ss");
            string sqlcmd = $"SELECT appointment.appointmentId, appointment.title, appointment.type,  appointment.start, appointment.end,  customer.customerName, user.userName FROM((appointment INNER JOIN customer ON customer.customerId = appointment.customerId) INNER JOIN user ON appointment.userId = user.userId) WHERE appointment.start BETWEEN  '{start}' AND '{end}'";
            DataClass.sqlConnection.Open();
            MySqlCommand command = new MySqlCommand(sqlcmd, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            AppointmentdataGridView1.DataSource = table;
            DataClass.sqlConnection.Close();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                table.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i]["end"], TimeZoneInfo.Local).ToString();
            }
        }


        private void Month()
        {
            AppointmentMonthCalendar1.RemoveAllBoldedDates();
            table.Clear();
            int month = currdt.Month;
            int year = currdt.Year;
            int day = 0;
            string start = year.ToString() + "-" + month.ToString() + "-01";
            DateTime temp = Convert.ToDateTime(start);
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                    day = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day = 30;
                    break;
                default:
                    day = 29;
                    break;
            }
            for (int i = 0; i < day; i++)
            {
                AppointmentMonthCalendar1.AddAnnuallyBoldedDate(temp.AddDays(i));
            }
            AppointmentMonthCalendar1.UpdateBoldedDates();
            string end =  year.ToString()+ "-" + month.ToString() + "-" + day.ToString();
            string sqlcmd = $"SELECT appointment.appointmentId, appointment.title, appointment.type,  appointment.start, appointment.end,  customer.customerName, user.userName FROM((appointment INNER JOIN customer ON customer.customerId = appointment.customerId) INNER JOIN user ON appointment.userId = user.userId) WHERE appointment.start BETWEEN '{start}' AND '{end}'";
            DataClass.sqlConnection.Open();
            MySqlCommand command = new MySqlCommand(sqlcmd, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
            AppointmentdataGridView1.DataSource = table;
            DataClass.sqlConnection.Close();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                table.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i]["end"], TimeZoneInfo.Local).ToString();
            }
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
                    AppointmentdataGridView1.Rows.RemoveAt(AppointmentdataGridView1.CurrentCell.RowIndex);
                    
                  

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
            
        }

        private void dayradioButton1_CheckedChanged(object sender, EventArgs e)
        {
            day();
        }

        private void ViewByWeekRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            week();
        }

        private void ViewByMonthRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            Month();
        }

        private void AppointmentMonthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            currdt = e.Start;
            if (ViewByMonthRadioBtn.Checked)
            {
                Month();
            }
            else
            {
                if (ViewByWeekRadioBtn.Checked)
                {
                    week();
                }
                else
                {
                    day();
                }
            }
        }

        private void ConsultantReportBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ConsultantReportForm consultantReportForm = new ConsultantReportForm();
            consultantReportForm.Show();
        }

        private void AppointmentTypesByMonthReportFormBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentTypesByMonthReportForm appointmentTypesByMonthReportForm = new AppointmentTypesByMonthReportForm();
            appointmentTypesByMonthReportForm.Show();
        }

        private void CustomerReportBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            CustomerReportForm customerReportForm = new CustomerReportForm();
            customerReportForm.Show();
        }
    }
}
