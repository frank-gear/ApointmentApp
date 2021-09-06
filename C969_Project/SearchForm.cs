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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string name = searchtextBox1.Text;
            string sqlcon = $"SELECT customer.customerId, customer.customerName, customer.active, address.phone, address.address, address.postalCode, city.city, country.country FROM ((( customer INNER JOIN address ON customer.addressId = address.addressId) INNER JOIN city ON address.cityId = city.cityId) INNER JOIN country ON city.countryId = country.countryId) where customer.customerName = '{name}';";

            MySqlCommand command = new MySqlCommand(sqlcon, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            DataClass.sqlConnection.Close();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.Show();
        }
    }
}
