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
    public partial class AddCustomerForm : Form
    {
       
        private Array cityList;
        private List<string> customerNameList = new List<string>();
        public AddCustomerForm()
        {
            InitializeComponent();
            cityList = DataClass.GetCityList();
            CitySelectBox.DataSource = cityList;
            string sqlcmd = "SELECT customerName from customer";
            
            MySqlDataReader reader = DataClass.DataRead(sqlcmd);
            while (reader.Read())
            {
                customerNameList.Add(Convert.ToString(reader["customerName"]));
            }
            DataClass.sqlConnection.Close();

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == "" || StreetTextBox.Text == "" || ZipCodeTextBox.Text == "" || PhoneNumberTextBox.Text == "")
            {
                string err = "Invalid entry. Customer data is missing. ";
                MessageBox.Show(err);
            }


            
            
                //created this lambda to check for invalid customer names
                //invalid customer info check
            else if (customerNameList.All(x => (x == CustomerNameTextBox.Text)))
            {
                string err = "Invalid entry. This Customer already exist. ";
                MessageBox.Show(err);
                CustomerNameTextBox.Text = "";
            }
           
            else
            {
                string name = CustomerNameTextBox.Text;
                string address = StreetTextBox.Text;
                string city = CitySelectBox.SelectedItem.ToString();
                string sqlcmd = $"SELECT cityId FROM city WHERE city = '{city}'";
                int cityid = DataClass.DataId(sqlcmd);
                string zip = ZipCodeTextBox.Text;
                string phone = PhoneNumberTextBox.Text;
                int act = 0;
                if (ActiveCheckBox1.Checked)
                {
                    act = 1;
                }
                DataClass.newCustomer(name, address, cityid, zip, phone, act);

                this.Close();
                RecordsForm records = new RecordsForm();
                records.Show();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RecordsForm records = new RecordsForm();
            records.Show();
        }
    }
}
