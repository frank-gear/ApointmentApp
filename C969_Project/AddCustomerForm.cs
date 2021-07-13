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
    public partial class AddCustomerForm : Form
    {
        private Array cityList;
        public AddCustomerForm()
        {
            InitializeComponent();
            cityList = DataClass.GetCityList();
            CitySelectBox.DataSource = cityList;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RecordsForm records = new RecordsForm();
            records.Show();
        }
    }
}
