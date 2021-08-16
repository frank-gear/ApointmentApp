using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969_Project
{
    public partial class ModifyAppointmentForm : Form
    {
        private static string appT;
        public static int select;
        private static List<string> typelist = new List<string>() { "Presentation", "Interview", "Scrum" };
        public ModifyAppointmentForm()
        {
            InitializeComponent();
           
           

            
            DataClass.sqlConnection.Close();
            typelistBox1.DataSource = typelist;
            dataread();
            typelistBox1.SelectedItem = appT;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }
        private void dataread()
        {
            
            string sqlcmd = $"SELECT * FROM appointment WHERE appointmentId = '{select}'";
            MySqlDataReader reader = DataClass.DataRead(sqlcmd);
            while (reader.Read()) 
            {
                TitleOfAppointmentTextBox.Text = Convert.ToString(reader["title"]);
                appT  = Convert.ToString(reader["type"]);
                StartOfAppointmentDateTimePicker.Value = Convert.ToDateTime(reader["start"]).ToLocalTime();
                EndOfAppointmentDateTimePicker.Value = Convert.ToDateTime(reader["end"]).ToLocalTime();
            }
            int i = typelistBox1.FindString(appT);
            
            DataClass.sqlConnection.Close();


        }
        




        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DateTime startcheck = DateTime.Today.AddHours(10);
            DateTime endcheck = DateTime.Today.AddHours(19);

            if (string.IsNullOrWhiteSpace(TitleOfAppointmentTextBox.Text))
            {
                MessageBox.Show("Please fill in all information.");
            }
            else if (StartOfAppointmentDateTimePicker.Value.TimeOfDay < startcheck.TimeOfDay)
            {
                MessageBox.Show("Office hours start at 10 AM please pick a later start time");
            }

            else if (EndOfAppointmentDateTimePicker.Value.TimeOfDay > endcheck.TimeOfDay)
            {
                MessageBox.Show("Office hours end at 7 pm please pick an earlier end time");
            }
            else if (EndOfAppointmentDateTimePicker.Value < StartOfAppointmentDateTimePicker.Value)
            {
                MessageBox.Show("Appointment End time must come after appointment start time");
            }
            else if (DataClass.AppointmentOverlapForModify(StartOfAppointmentDateTimePicker.Value, EndOfAppointmentDateTimePicker.Value,select))
            {
                MessageBox.Show("The selected time is in conflict with an existing appointment please choose a different time");
            }
            else
            {
                //Created this lamba to covert times before send to database
                Func<DateTime, string> convert = x => x.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
                string title = TitleOfAppointmentTextBox.Text;
                string type = typelistBox1.SelectedItem.ToString();
                DateTime dateTimeSt = StartOfAppointmentDateTimePicker.Value;
                DateTime dateTimeEd = EndOfAppointmentDateTimePicker.Value;
                string start = convert(dateTimeSt);
                string end = convert(dateTimeEd);
                DataClass.ModifyAppointment(select, title, type, start, end);
                this.Close();
                AppointmentForm appointmentForm = new AppointmentForm();
                appointmentForm.Show();
            }
            
        }
    }
}
