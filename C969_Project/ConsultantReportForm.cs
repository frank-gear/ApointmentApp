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
    public partial class ConsultantReportForm : Form
    {

        public ConsultantReportForm()
        {

            InitializeComponent();
            listBox1.DataSource = GetUserList();
        }

        private void selectbutton1_Click(object sender, EventArgs e)
        {
            string user = listBox1.SelectedItem.ToString();
            string sqlcmd = $"SELECT userId FROM user WHERE userName = '{user}'";
            int id = DataClass.DataId(sqlcmd);            
            DataTable table = new DataTable();
            DataClass.sqlConnection.Open();
            string sqlcon = $"SELECT appointmentId, customerId, type,start FROM appointment WHERE userId = {id}";
            MySqlCommand command = new MySqlCommand(sqlcon, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            adapter.Fill(table);
           ConsultantReportDataGridView.DataSource = table;
            DataClass.sqlConnection.Close();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i]["start"], TimeZoneInfo.Local).ToString();
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }
        public static List<string> GetUserList()
        {
            string sqlcmd = "SELECT userName from user";
            List<string> user = new List<string>();
           MySqlDataReader reader = DataClass.DataRead(sqlcmd);
            while (reader.Read())
            {
                user.Add(Convert.ToString(reader["userName"]));
            }
            
           DataClass.sqlConnection.Close();
            return user;
        }
    }
}
