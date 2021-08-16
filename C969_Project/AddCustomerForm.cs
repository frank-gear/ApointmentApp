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
            string sqlcmd = "SELECT customerName from customer";
            
            MySqlDataReader reader = DataClass.DataRead(sqlcmd);
            while (reader.Read())
            {
                customerNameList.Add(Convert.ToString(reader["customerName"]));
            }
            DataClass.sqlConnection.Close();

        }
        private delegate bool CheckName(string name);

        
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            
            
            bool namelist()
            {
                //created this lambda to check for invalid customer names
                CheckName checkName = x => (x == CustomerNameTextBox.Text);
                for (int i = 0; i < customerNameList.Count; i++)
                {
                    if (checkName(customerNameList[i]))
                    {
                        return true;
                    }
                }
                return false;

            }

                      
            
            if (string.IsNullOrWhiteSpace (CustomerNameTextBox.Text) || string.IsNullOrWhiteSpace( StreetTextBox.Text) || string.IsNullOrWhiteSpace(CitytextBox1.Text) || string.IsNullOrWhiteSpace(CountrytextBox3.Text) || string.IsNullOrWhiteSpace(ZipCodeTextBox.Text) || string.IsNullOrWhiteSpace(PhoneNumberTextBox.Text) )
            {
                string err = "Invalid entry. Customer data is missing. ";
                MessageBox.Show(err);
            }


            
            
                
            //invalid customer info check
            else if (namelist())
            {
                string err = "Invalid entry. This Customer already exist. ";
                MessageBox.Show(err);
                CustomerNameTextBox.Text = "";
            }
           
            else
            {
                string name = CustomerNameTextBox.Text;
                string address = StreetTextBox.Text;
                string city = CitytextBox1.Text;
                string country = CountrytextBox3.Text;                             
                string zip = ZipCodeTextBox.Text;
                string phone = PhoneNumberTextBox.Text;
                int act = 0;
                if (ActiveCheckBox1.Checked)
                {
                    act = 1;
                }
                DataClass.newCustomer(name, address, city, country, zip, phone, act);

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

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
