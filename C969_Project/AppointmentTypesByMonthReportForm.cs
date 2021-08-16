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
    public partial class AppointmentTypesByMonthReportForm : Form
    {
        public AppointmentTypesByMonthReportForm()
        {
            InitializeComponent();
            DataReturn();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }

        private void DataReturn()
        {
            //august
            string sqlcmd = "SELECT COUNT(*) FROM appointment WHERE type = 'Presentation' AND MONTH(start) = 8";
            AugPrestextBox1.Text = DataClass.DataId(sqlcmd).ToString();
            sqlcmd = "SELECT COUNT(*) FROM appointment WHERE type = 'Interview' AND MONTH(start) = 8";
            AugInttextBox2.Text = DataClass.DataId(sqlcmd).ToString();
            sqlcmd = "SELECT COUNT(*) FROM appointment WHERE type = 'Scrum' AND MONTH(start) = 8";
            AugScrumtextBox3.Text = DataClass.DataId(sqlcmd).ToString();

           

        }

    

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            int month = monthCalendar1.SelectionStart.Month;
            string sqlcmd = $"SELECT COUNT(*) FROM appointment WHERE type = 'Presentation' AND MONTH(start) = {month}";
            AugPrestextBox1.Text = DataClass.DataId(sqlcmd).ToString();
            sqlcmd = $"SELECT COUNT(*) FROM appointment WHERE type = 'Interview' AND MONTH(start) = {month}";
            AugInttextBox2.Text = DataClass.DataId(sqlcmd).ToString();
            sqlcmd = $"SELECT COUNT(*) FROM appointment WHERE type = 'Scrum' AND MONTH(start) = {month}";
            AugScrumtextBox3.Text = DataClass.DataId(sqlcmd).ToString();
        }
    }
}
