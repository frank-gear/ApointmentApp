using MySql.Data.MySqlClient;
using System;
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

    public partial class AddAppointmentForm : Form
    {
        private static Array customerlist;
        private static List<string> typelist = new List<string>() { "Presentation", "Interview", "Scrum" };
        public AddAppointmentForm()
        {
            customerlist = DataClass.GetCustomerList();
            InitializeComponent();
            customerlistBox1.DataSource = customerlist;
            TypelistBox1.DataSource = typelist;

            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DateTime startcheck = DateTime.Today.AddHours(10);
            DateTime endcheck = DateTime.Today.AddHours(19);
            //return after the messagebox
            if (string.IsNullOrWhiteSpace(TitleOfAppointmentTextBox.Text))
            {
                MessageBox.Show("Please fill in title of appointment");
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
            else if (DataClass.AppointmentOverlap(StartOfAppointmentDateTimePicker.Value, EndOfAppointmentDateTimePicker.Value))
            {
                MessageBox.Show("The selected time is in conflict with an existing appointment please choose a different time");
            }

            else
            {
                Func<DateTime, string> convert = x => x.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
                string selected = customerlistBox1.SelectedItem.ToString();
                string sqlcmd1 = $"SELECT customerId FROM customer WHERE customerName = '{selected}'";
                int custId = DataClass.DataId(sqlcmd1);
                string title = TitleOfAppointmentTextBox.Text;
                string type = TypelistBox1.Text;
                DateTime start = StartOfAppointmentDateTimePicker.Value;
                DateTime end = EndOfAppointmentDateTimePicker.Value;
                DataClass.AddNewAppointment(custId, title, type, convert(start), convert(end));
                this.Close();
                AppointmentForm appointmentForm = new AppointmentForm();
                appointmentForm.Show();
            }
        }

        private void GetTypelist()
        {
            string sqlcmd = "SELECT type from appointment";

            MySqlDataReader reader = DataClass.DataRead(sqlcmd);
            while (reader.Read())
            {
                typelist.Add(Convert.ToString(reader["type"]));
            }
            DataClass.sqlConnection.Close();
            TypelistBox1.DataSource = typelist;
        }
    }
}
