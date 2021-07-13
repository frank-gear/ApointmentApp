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
        public static int setRow;
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

        private void returntorecordsbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteAppointmentBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Delete?", "Delete Part", MessageBoxButtons.YesNo);
            setRow = Convert.ToInt32(AppointmentdataGridView1.Rows[AppointmentdataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            if (setRow != -1)
            {
                if (dialog == DialogResult.Yes)
                {
                    string sqlcmd = $" DELETE FROM appointment WHERE appointmentId = '{setRow}'";
                    DataClass.DataWrite(sqlcmd);
                    ConnectData();

                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete", "Error");
            }
        }

        private void ModifyAppointmentBtn_Click(object sender, EventArgs e)
        {
            setRow = Convert.ToInt32(AppointmentdataGridView1.Rows[AppointmentdataGridView1.CurrentCell.RowIndex].Cells[0].Value);
            ModifyAppointmentForm.select = setRow;
            this.Close();
            ModifyAppointmentForm modifyAppointment = new ModifyAppointmentForm();
            modifyAppointment.Show();
            

        }

        private void AddApointmentBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();
            addAppointmentForm.Show();
        }
    }
}
