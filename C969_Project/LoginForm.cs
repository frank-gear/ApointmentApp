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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
          if  (DataClass.UserLogin(UserIdTextBox.Text, UserPasswordTextBox.Text))
            {
                DataClass.sqlConnection.Close();
                this.Hide();
                RecordsForm recordsForm = new RecordsForm();
                recordsForm.Show();
            }
            else
            {
                string err = "bad login";
                MessageBox.Show(err);
                UserIdTextBox.Text = "";
                UserPasswordTextBox.Text = "";
            }

        }
    }
}
