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


        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RecordsForm.ActiveForm.Show();
        }
    }
}
