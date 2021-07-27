using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace C969_Project
{
    public static class DataClass
    {
        public static string wguDatabase = "server=wgudb.ucertify.com;userid=U04iSl;password=53688253345;database=U04iSl";

        public static MySqlConnection sqlConnection = new MySqlConnection(wguDatabase);

        public static int DataId(string command)
        {
            sqlConnection.Open();
            MySqlCommand build = new MySqlCommand(command, sqlConnection);
            int complete = Convert.ToInt32(build.ExecuteScalar());
            sqlConnection.Close();
            return complete;
        }

        public static void DataWrite(string command)
        {
            sqlConnection.Open();
            MySqlCommand build = new MySqlCommand(command, sqlConnection);
            var complete = build.ExecuteNonQuery();
            System.Diagnostics.Debug.WriteLine(complete);
            sqlConnection.Close();
        }

        public static MySqlDataReader DataRead(string command)
        {
            sqlConnection.Open();
            MySqlCommand build = new MySqlCommand(command, sqlConnection);
            return build.ExecuteReader();

        }

        public static void DataCheck()
        {
            string x = "SELECT * FROM user";
            sqlConnection.Open();
            MySqlCommand build = new MySqlCommand(x, sqlConnection);
            object complete = build.ExecuteScalar();
            sqlConnection.Close();
            if (complete == null)
            {
                DataClass.DataBuild();
            }


        }
        /// <summary>



        /// build the data
        /// </summary>
        public static void DataBuild()
        {

            string[] country =
                {
                "INSERT INTO `country` VALUES (1, 'US', '2019-01-01 00:00:00', 'test', '2019-01-01 00:00:00', 'test')",
                "INSERT INTO `country` VALUES (2,'Canada','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
                "INSERT INTO `country` VALUES (3,'Norway','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')"
                };
            DataWrite(country[0]);
            DataWrite(country[1]);
            DataWrite(country[2]);
           
            string[] city =
            {
                "INSERT INTO `city` VALUES  (1,'New York',1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
                 "INSERT INTO `city` VALUES (2,'Los Angeles',1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
                 "INSERT INTO `city` VALUES (3,'Toronto',2,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
                 "INSERT INTO `city` VALUES (4,'Vancouver',2,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
                 "INSERT INTO `city` VALUES (5,'Oslo',3,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')"
            };
            DataWrite(city[0]);
            DataWrite(city[1]);
            DataWrite(city[2]);
            DataWrite(city[3]);
            DataWrite(city[4]);
            string[] address =
            {
                "INSERT INTO `address` VALUES (1,'123 Main','',1,'11111','555-1212','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
                "INSERT INTO `address` VALUES (2,'123 Elm','',3,'11112','555-1213','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
                "INSERT INTO `address` VALUES(3,'123 Oak','',5,'11113','555-1214','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')"
            };
            DataWrite(address[0]);
            DataWrite(address[1]);
            DataWrite(address[2]);
            string[] customer =
            {
            "INSERT INTO `customer` VALUES (1,'John Doe',1,1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
            "INSERT INTO `customer` VALUES (2,'Alfred E Newman',2,1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
            "INSERT INTO `customer` VALUES (3,'Ina Prufung',3,1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')"
            };
            DataWrite(customer[0]);
            DataWrite(customer[1]);
            DataWrite(customer[2]);
            string user = "INSERT INTO `user` VALUES (1,'test','test',1,'2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')";
            DataWrite(user);
            DateTime time1 = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(14);
            DateTime time = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(30);
            string time2 = time1.ToString("yyyy-MM-dd HH:mm:ss");
            string timeEnd = time.ToString("yyyy-MM-dd HH:mm:ss");
            string[] appointment =
            {
              "INSERT INTO `appointment` VALUES (1,1,1,'not needed','not needed','not needed','not needed','Presentation','not needed','2021-07-01 00:00:00','2021-07-01 00:00:00','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
              "INSERT INTO `appointment` VALUES (2,2,1,'not needed','not needed','not needed','not needed','Scrum','not needed','2021-07-01 00:00:00','2021-07-01 00:00:00','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
              $"INSERT INTO `appointment` VALUES (3,3,1,'not needed','not needed','not needed','not needed','Scrum','not needed','{time2}','{timeEnd}','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')"

            };
            DataWrite(appointment[0]);
            DataWrite(appointment[1]);
            DataWrite(appointment[2]);
        }

        public static bool UserLogin(string name, string pass)
        {
            string sqlcmd = $"SELECT userID FROM user WHERE userName = '{name}' AND password = '{pass}'";
            MySqlDataReader complete = DataRead(sqlcmd);
            bool status = complete.HasRows;
            return status;

        }
        //need to add apointment delete
        public static void CustomerDelete(int custid, int addrid)
        {
            string sqlcmd1 = $"DELETE FROM customer WHERE customerid = '{custid}'";
            string sqlcmd2 = $"DELETE FROM address WHERE addressid = '{addrid}'";
            string sqlcmd3 = $"DELETE FROM appointment WHERE customerid = '{custid}'";
            DataWrite(sqlcmd1);
            DataWrite(sqlcmd2);
            DataWrite(sqlcmd3);
        }
        //get list of city names
        public static Array GetCityList()
        {
            string sqlcmd = "SELECT city from city";
            List<string> city = new List<string>();
            MySqlDataReader reader = DataRead(sqlcmd);
            while (reader.Read())
            {
                city.Add(Convert.ToString(reader["city"]));
            }
            string[] cityList = city.ToArray();
            sqlConnection.Close();
            return cityList;
        }
        public static Array GetCustomerList()
        {
            string sqlcmd = "SELECT customerName from customer";
            List<string> customerNameList = new List<string>();
            MySqlDataReader reader = DataRead(sqlcmd);
            while (reader.Read())
            {
                customerNameList.Add(Convert.ToString(reader["customerName"]));
            }
            string[] nameList = customerNameList.ToArray();
            sqlConnection.Close();
            return nameList;
        }
        public static void modifyCustomer(int custid, int addid, string custname, string address, int citid, string postal, string phone, int activ)
        {
            string custupdate = $"UPDATE customer set customerName = '{custname}', active = '{activ}' WHERE customerId ='{custid}'";
            string addupdate = $"update address set address = '{address}', cityId = '{citid}', postalCode ='{postal}', phone = '{phone}' WHERE addressId = '{addid}'";
            DataWrite(custupdate);
            DataWrite(addupdate);

        }
        public static string CurDate()
        {
            DateTime time1 = Convert.ToDateTime(DateTime.UtcNow);
            string time2 = time1.ToString("yyyy-MM-dd HH:mm:ss");
            return time2;
        }
        public static void newCustomer(string custname, string address, int citid, string postal, string phone, int activ)
        {
            //get the count for address
            string addcount = "SELECT COUNT(*) FROM address";
            int addid = DataId(addcount) + 1;
            string addsql = $"INSERT INTO address VALUES({addid},'{address}', ' ', {citid}, '{postal}', '{phone}', '{CurDate()}', 'test', '{CurDate()}', 'test')";
            DataWrite(addsql);
            string custcount = "SELECT COUNT(*) FROM customer";
            int custid = DataId(custcount) + 1;
            string addcust = $"INSERT INTO customer VALUES ({custid},'{custname}',{addid},{activ},'{CurDate()}','test','{CurDate()}','test')";
            DataWrite(addcust);

        }
        public static void ModifyAppointment(int appid, string title, string type, DateTime start, DateTime end)
        {
            string sqlcmd = $"UPDATE appointment set title='{title}', type = '{type}', start ='{start}', end = '{end}' WHERE appointmentId = '{appid}'";
            DataWrite(sqlcmd);
        }

        public static void AddNewAppointment(int custid, string title, string type, DateTime start, DateTime end)
        {
            string addcount = "SELECT COUNT(*) FROM appointment";
            int appid = DataId(addcount) + 1;
            string sqlcmd = $"INSERT INTO `appointment` VALUES ('{appid}','{custid}',1,'{title}','not needed','not needed','not needed','{type}','not needed','{start}','{end}','{DateTime.UtcNow}','test','{DateTime.UtcNow}','test')";
            DataWrite(sqlcmd);
        }
        public static void AppointmentAlert()
        {
            DateTime time = Convert.ToDateTime(DateTime.UtcNow);
            DateTime time2 = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(15);

            string sqlcmd = "SELECT customer.customerId, customer.customerName, appointment.appointmentId, appointment.start, appointment.end from appointment INNER JOIN customer on appointment.customerId = customer.customerId where start BETWEEN '" +
                time.ToString("yyyy-MM-dd HH:mm:ss") + "' AND '" +
                time2.ToString("yyyy-MM-dd HH:mm:ss") + "';";
            DataClass.sqlConnection.Open();
            MySqlCommand command = new MySqlCommand(sqlcmd, DataClass.sqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            sqlConnection.Close();


            if (table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    MessageBox.Show("In 15 minutes Please attend your appoint with " + table.Rows[i]["customerName"], "Appointment");
                }
            }
        }
    }
}










