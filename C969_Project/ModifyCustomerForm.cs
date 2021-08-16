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
    public partial class ModifyCustomerForm : Form
    {
       
      
        public static int selectedcust;
        public static string custname;
        public static string street;
        public static string city;
        public static string country;
        public static string zip;
        public static string phone;
        public static bool act;

        public ModifyCustomerForm()
        {
            InitializeComponent();
            datainsert();
      
        }

        private void datainsert()
        {
            CustomerNameTextBox.Text = custname;
            StreetTextBox.Text = street;
            citytextBox1.Text = city;
            CountrytextBox1.Text = country;
            ZipCodeTextBox.Text = zip;
            PhoneNumberTextBox.Text = phone;
            ActivecheckBox1.Checked = act;
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustomerNameTextBox.Text == "" || StreetTextBox.Text == "" || ZipCodeTextBox.Text == "" || PhoneNumberTextBox.Text == "")
            {
                string err = "Invalid entry. Customer data is missing. ";
                MessageBox.Show(err);
            }
            else
            {

                DataClass.sqlConnection.Close();
                string name = CustomerNameTextBox.Text;
                string address = StreetTextBox.Text;
                string city = citytextBox1.Text;
                string sqlcmd = $"SELECT addressId FROM customer WHERE customerId = '{selectedcust}'";
                int addId = DataClass.DataId(sqlcmd);
                string zip = ZipCodeTextBox.Text;
                string phone = PhoneNumberTextBox.Text;
                string country = CountrytextBox1.Text;               
                int act = 0;
                if (ActivecheckBox1.Checked)
                {
                    act = 1;
                }

                DataClass.modifyCustomer(selectedcust, addId, name, address, zip, phone, act, country, city);
                this.Close();
                RecordsForm recordsForm = new RecordsForm();
                recordsForm.Show();

            }
           
        }
    }
}
