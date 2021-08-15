﻿using MySql.Data.MySqlClient;
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
        private static List<string> typelist = new List<string>();
        public AddAppointmentForm()
        {
            customerlist = DataClass.GetCustomerList();
            InitializeComponent();
            customerlistBox1.DataSource = customerlist;
            GetTypelist();
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
            //return after the messagebox
            if (StartOfAppointmentDateTimePicker.Value.TimeOfDay < startcheck.TimeOfDay)
            {
                MessageBox.Show("Office hours start at 10 please pick a later start time");
            }
            DateTime endcheck = DateTime.Today.AddHours(19);
            if (EndOfAppointmentDateTimePicker.Value.TimeOfDay > endcheck.TimeOfDay)
            {
                MessageBox.Show("Office hours end at 7 please pick an earlier end time");
            }
            if (DataClass.AppointmentOverlap(StartOfAppointmentDateTimePicker.Value, EndOfAppointmentDateTimePicker.Value))
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
                DateTime start = StartOfAppointmentDateTimePicker.Value.ToLocalTime();
                DateTime end = EndOfAppointmentDateTimePicker.Value.ToLocalTime();
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
