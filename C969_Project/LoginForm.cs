using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Project
{
    public partial class LoginForm : Form
    {
        private string err = "bad login";
        public static int usrLogin;       
        private static string fileName = "UserLog.txt";
        private static FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write);
        private StreamWriter fileWriter = new StreamWriter(file);
        public LoginForm()
        {
            InitializeComponent();
            lang();
            
        }
      

        private void lang()
        {
            //this may be a cultre class
            CultureInfo C = CultureInfo.CurrentCulture;
            string lang = C.TwoLetterISOLanguageName; //fr if lang == fr

            if (lang == "fr")
            {
                UserIdLabel.Text = "utilisatrice";
                PasswordLabel.Text = "le mot de passe";
                LoginBtn.Text = "connexion";
                ExitBtn.Text = "sortir";
                err = "mauvaise connexion";
            }
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
                string user = UserIdTextBox.Text;               
                string sqlcmd = $"SELECT userId FROM user WHERE userName ='{user}'";
                usrLogin = DataClass.DataId(sqlcmd);
                DateTime stamp = DateTime.UtcNow;
                string write = $"Username: '{user}' userId: '{usrLogin}' Logged in @ '{stamp.ToString()}'";              
                fileWriter.WriteLine(write);
                fileWriter.Flush();
                
                this.Hide();
                DataClass.AppointmentAlert();
                RecordsForm recordsForm = new RecordsForm();
                recordsForm.Show();
            }
            else
            {
                 
                MessageBox.Show(err);
                UserIdTextBox.Text = "";
                UserPasswordTextBox.Text = "";
                DateTime stamp = DateTime.UtcNow;
                string write = $"Username: {UserIdTextBox.Text} attempted to Logged in @ '{stamp.ToString()}'";
                fileWriter.WriteLine(write);
                fileWriter.Flush();
            }

        }
    }
}
