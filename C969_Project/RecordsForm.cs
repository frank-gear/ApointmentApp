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
        
        public RecordsForm()
        {
            InitializeComponent();
            ConnectData();
        }
        private void ConnectData()
        {
            DataClass.sqlConnection.Close();
            DataClass.sqlConnection.Open();
            string sqlcon = "SELECT customer.customerId, customer.customerName, customer.active, address.phone, address.address, address.postalCode, city.city, country.country FROM ((( customer INNER JOIN address ON customer.addressId = address.addressId) INNER JOIN city ON address.cityId = city.cityId) INNER JOIN country ON city.countryId = country.countryId);";
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
            if (dataGridView1.CurrentCell.RowIndex < 0)
            {
                string err = "Please select the  customerId to modify ";
                MessageBox.Show(err);
            }
            else
            {
                
                ModifyCustomerForm.selectedcust = (int)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
                ModifyCustomerForm.custname = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[1].Value;
                ModifyCustomerForm.act = (bool)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value;
                ModifyCustomerForm.phone = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value;
                ModifyCustomerForm.street = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[4].Value;
                ModifyCustomerForm.zip = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[5].Value;
                ModifyCustomerForm.city = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[6].Value;
                ModifyCustomerForm.country = (string)dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[7].Value;
                ModifyCustomerForm modifyCustomerForm = new ModifyCustomerForm();
                this.Close();
                modifyCustomerForm.Show();
            }
            

        }

        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteCustomerForm deleteCustomerForm = new DeleteCustomerForm();
            deleteCustomerForm.Show();
           
        }
    }
    
}
