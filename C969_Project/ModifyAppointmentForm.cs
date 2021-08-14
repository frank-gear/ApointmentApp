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
        private List<string> typeList = new List<string>();
        public ModifyAppointmentForm()
        {
            InitializeComponent();
           
            string sqlcmd = "SELECT type from appointment";

            MySqlDataReader reader = DataClass.DataRead(sqlcmd);
            while (reader.Read())
            {
                typeList.Add(Convert.ToString(reader["type"]));
            }
            DataClass.sqlConnection.Close();
            typelistBox1.DataSource = typeList;
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
            }
            int i = typelistBox1.FindString(appT);
            
            DataClass.sqlConnection.Close();


        }
        




        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //Created this lamba to covert times before send to database
            Func<DateTime, string> convert = x => x.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss");
            string title = TitleOfAppointmentTextBox.Text;
            string type = typelistBox1.SelectedItem.ToString();
            DateTime dateTimeSt = StartOfAppointmentDateTimePicker.Value.ToLocalTime();
            DateTime dateTimeEd = EndOfAppointmentDateTimePicker.Value.ToLocalTime();
            string start = convert(dateTimeSt);
            string end = convert(dateTimeEd);
            DataClass.ModifyAppointment(select, title, type, start, end);
            this.Close();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }
    }
}
