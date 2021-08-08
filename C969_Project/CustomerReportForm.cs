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
    public partial class CustomerReportForm : Form
    {
        public CustomerReportForm()
        {
            InitializeComponent();
            DataBuild();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentForm appointment = new AppointmentForm();
            appointment.Show();
          
        }
        private void DataBuild()
        {
            DataClass.sqlConnection.Close();
            DataClass.sqlConnection.Open();
            string sqlcon = "SELECT city FROM city";
            MySqlCommand command = new MySqlCommand(sqlcon, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CustomerReportDataGridView.DataSource = table;
            DataClass.sqlConnection.Close();
        }
    }
}
