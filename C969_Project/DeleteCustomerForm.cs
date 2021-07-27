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
    public partial class DeleteCustomerForm : Form
    {
        private static Array customerlist;
        public DeleteCustomerForm()
        {
            customerlist = DataClass.GetCustomerList();
            
            InitializeComponent();
            CustomerlistBox.DataSource = customerlist;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            RecordsForm recordsForm = new RecordsForm();
            recordsForm.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string selected;
            selected = CustomerlistBox.SelectedItem.ToString();
            string sqlcmd1 = $"SELECT customerId FROM customer WHERE customerName = '{selected}'";
            string sqlcmd2 = $"SELECT addressId FROM customer WHERE customerName = '{selected}'";
            int custid = DataClass.DataId(sqlcmd1);
            int addid = DataClass.DataId(sqlcmd2);
            DataClass.CustomerDelete(custid, addid);
            this.Close(); 
            RecordsForm records = new RecordsForm();
            records.Show();

        }
    }
}
