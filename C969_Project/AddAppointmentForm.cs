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
        public AddAppointmentForm()
        {
            customerlist = DataClass.GetCustomerList();
            InitializeComponent();
            customerlistBox1.DataSource = customerlist;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            string selected = customerlistBox1.SelectedItem.ToString();
            string sqlcmd1 = $"SELECT customerId FROM customer WHERE customerName = '{selected}'";
            int custId = DataClass.DataId(sqlcmd1);
            string title = TitleOfAppointmentTextBox.Text;
            string type = TypeOfAppointmentTextBox.Text;
            DateTime start = StartOfAppointmentDateTimePicker.Value;
            DateTime end = EndOfAppointmentDateTimePicker.Value;
            DataClass.AddNewAppointment(custId, title, type, start, end);
            this.Close();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }
    }
}
