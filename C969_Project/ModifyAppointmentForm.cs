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
        public static int select;
        public ModifyAppointmentForm()
        {
            InitializeComponent();
            dataread();
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
                TypeOfAppointmentTextBox.Text = Convert.ToString(reader["type"]);
            }
      
            DataClass.sqlConnection.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string title = TitleOfAppointmentTextBox.Text;
            string type = TypeOfAppointmentTextBox.Text;
            DateTime start = StartOfAppointmentDateTimePicker.Value;
            DateTime end = EndOfAppointmentDateTimePicker.Value;
            DataClass.ModifyAppointment(select, title, type, start, end);
            this.Close();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }
    }
}
