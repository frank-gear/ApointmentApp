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
    public partial class RecordsForm : Form
    {
        public static object selectcustomer;
        public RecordsForm()
        {
            InitializeComponent();
            ConnectData();
        }
        private void ConnectData()
        {
            DataClass.sqlConnection.Open();
            string sqlcon = "SELECT * FROM customer, address WHERE address.addressid = customer.addressid";
            MySqlCommand command = new MySqlCommand(sqlcon, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            DataClass.sqlConnection.Close();
        }

        private void AppointmentsBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentForm appointmentForm = new AppointmentForm();
            appointmentForm.Show();
        }

        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();

        }

        private void ModifyCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ModifyCustomerForm modifyCustomerForm = new ModifyCustomerForm();
            modifyCustomerForm.Show();

        }

        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
            deleteCustomerForm.Show();
           
        }
    }
    
}
