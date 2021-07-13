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
        private static Array customerlist;
        private Array cityList;
        private static int custId;
        private static int addId;
        public ModifyCustomerForm()
        {
            InitializeComponent();
            customerlist = DataClass.GetCustomerList();
            cityList = DataClass.GetCityList();
            citylistBox1.DataSource = cityList;
            customerlistBox1.DataSource = customerlist;
        }

        private void custselectbtn_Click(object sender, EventArgs e)
        {
           string selected = customerlistBox1.SelectedItem.ToString();
            string sqlcmd1 = $"SELECT customerId FROM customer WHERE customerName = '{selected}'";
            string sqlcmd2 = $"SELECT addressId FROM customer WHERE customerName = '{selected}'";
            string sqlcmdadress = $"SELECT * FROM address WHERE addressId = '{addId}'";
            custId = DataClass.DataId(sqlcmd1);
             addId = DataClass.DataId(sqlcmd2);
            MySqlDataReader reader = DataClass.DataRead(sqlcmdadress);
            CustomerNameTextBox.Text = selected;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DataClass.sqlConnection.Close();
           string name = CustomerNameTextBox.Text;
            string address = StreetTextBox.Text;
            string city = citylistBox1.SelectedItem.ToString();
            string sqlcmd = $"SELECT cityId FROM city WHERE city = '{city}'";
            int cityid = DataClass.DataId(sqlcmd);
            string zip = ZipCodeTextBox.Text;
            string phone  = PhoneNumberTextBox.Text;
            int act = 0;
            if (ActivecheckBox1.Checked)
            {
                act = 1;
            }

            DataClass.modifyCustomer(custId, addId, name, address, cityid, zip, phone, act);
            this.Close();
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.Show();
        }
    }
}
