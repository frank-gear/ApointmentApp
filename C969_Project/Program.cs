using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataClass.DataCheck();
          
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
//notes 
//overlap failing think its an issue with the local to utc conversion
//custoemr delete is also failing due to some kind of foriegn key conflict
//utc to local seems to mess up the return
// not sure about link in project requirments
// list from the data reader such a type are returning all jumbled
//things to do
// update add customer country and city
// pre fill the text boxs for the modify customer
// change customer recod to customer count
//change report month to textbox  or add all the months 
