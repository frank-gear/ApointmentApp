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
        public AppointmentForm()
        {
            InitializeComponent();
            ConnectData();
        }
        private void ConnectData()
        {
            DataClass.sqlConnection.Open();
            string sqlcon = "SELECT * FROM appointment";
            MySqlCommand command = new MySqlCommand(sqlcon, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            AppointmentdataGridView1.DataSource = table;
            DataClass.sqlConnection.Close();
        }
    }
}
