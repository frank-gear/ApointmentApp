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
            try
            {
                sqlConnection.Close();
                sqlConnection.Open();
                MySqlCommand build = new MySqlCommand(command, sqlConnection);
                int complete = Convert.ToInt32(build.ExecuteScalar());
                sqlConnection.Close();
                return complete;
            
            }
            catch(System.InvalidCastException)
            {
                sqlConnection.Close();
                return 0;
            }
           
        }

        public static void DataWrite(string command)
        {
            sqlConnection.Close();
            sqlConnection.Open();
            MySqlCommand build = new MySqlCommand(command, sqlConnection);
            var complete = build.ExecuteNonQuery();
            System.Diagnostics.Debug.WriteLine(complete);
            sqlConnection.Close();
        }

        public static MySqlDataReader DataRead(string command)
        {
             sqlConnection.Close();
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
            DateTime alrt1 = Convert.ToDateTime(DateTime.UtcNow).AddMinutes(14);
            DateTime alrt2 = alrt1.AddMinutes(30);
            DateTime time1 = DateTime.Today.AddHours(10).AddMinutes(30);
            DateTime time = time1.AddHours(1);                                           
            time1 = time1.ToUniversalTime();
            time = time.ToUniversalTime();
            string time2 = time1.ToString("yyyy-MM-dd HH:mm:ss");
            string timeEnd = time.ToString("yyyy-MM-dd HH:mm:ss");
            DateTime st2 = time1.AddDays(7);
            DateTime en2 = st2.AddMinutes(30);
            DateTime st3 = time1.AddDays(3);
            DateTime en3 = st3.AddMinutes(30);


            string[] appointment =
            {
              $"INSERT INTO `appointment` VALUES (1,1,1,'Talk to Customer','not needed','not needed','not needed','Presentation','not needed','{st3.ToString("yyyy-MM-dd HH:mm:ss")}','{en3.ToString("yyyy-MM-dd HH:mm:ss")}','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
              $"INSERT INTO `appointment` VALUES (2,2,1,'Brief Meeting','not needed','not needed','not needed','Interview','not needed','{st2.ToString("yyyy-MM-dd HH:mm:ss")}','{en2.ToString("yyyy-MM-dd HH:mm:ss")}','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
              $"INSERT INTO `appointment` VALUES (3,3,1,'Introduction','not needed','not needed','not needed','Scrum','not needed','{time2}','{timeEnd}','2021-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
              $"INSERT INTO `appointment` VALUES (4,1,1,'Sales','not needed','not needed','not needed','Presentation','not needed','{alrt1.ToString("yyyy-MM-dd HH:mm:ss")}','{alrt2.ToString("yyyy-MM-dd HH:mm:ss")}','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')"

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
            DataWrite(sqlcmd3);
            DataWrite(sqlcmd1);
            DataWrite(sqlcmd2);
            
            
            
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
        public static void modifyCustomer(int custid, int addid, string custname, string address,  string postal, string phone, int activ, string country, string city)
        {
            
            string count = "SELECT MAX(countryId) FROM country";
            int countryid = DataId(count) + 1;
            string sqlcmd = $"INSERT INTO `country` VALUES ({countryid}, '{country}', '{CurDate()}', 'test', '{CurDate()}', 'test');";
            DataWrite(sqlcmd);

            
            count = "SELECT MAX(cityId) FROM city";
            int cityid = DataId(count) + 1;
            sqlcmd = $"INSERT INTO `city` VALUES  ({cityid},'{city}',{countryid},'{CurDate()}','test','{CurDate()}','test');";
            DataWrite(sqlcmd);

            string custupdate = $"UPDATE customer set customerName = '{custname}', active = '{activ}' WHERE customerId ='{custid}'";
            string addupdate = $"update address set address = '{address}', cityId = '{cityid}', postalCode ='{postal}', phone = '{phone}' WHERE addressId = '{addid}'";
            DataWrite(custupdate);
            DataWrite(addupdate);

        }
        public static string CurDate()
        {
            DateTime time1 = Convert.ToDateTime(DateTime.UtcNow);
            string time2 = time1.ToString("yyyy-MM-dd HH:mm:ss");
            return time2;
        }
        public static void newCustomer(string custname, string address, string city, string country, string postal, string phone, int activ)
        {
            //create country
            string count = "SELECT MAX(countryId) FROM country";
            int countryid = DataId(count) + 1;
            string sqlcmd = $"INSERT INTO `country` VALUES ({countryid}, '{country}', '{CurDate()}', 'test', '{CurDate()}', 'test');";
            DataWrite(sqlcmd);
            
            //create ctiy
            count = "SELECT MAX(cityId) FROM city";
            int cityid = DataId(count) + 1;
            sqlcmd = $"INSERT INTO `city` VALUES  ({cityid},'{city}',{countryid},'{CurDate()}','test','{CurDate()}','test');";
            DataWrite(sqlcmd);
            
            //create address 
            count = "SELECT MAX(addressId) FROM address";
            int addid = DataId(count) + 1;
            sqlcmd = $"INSERT INTO address VALUES({addid},'{address}', ' ', {cityid}, '{postal}', '{phone}', '{CurDate()}', 'test', '{CurDate()}', 'test')";
            DataWrite(sqlcmd);
            // create customer
            
            string custcount = "SELECT MAX(customerId) FROM customer";
            int custid = DataId(custcount) + 1;
            sqlcmd = $"INSERT INTO customer VALUES ({custid},'{custname}',{addid},{activ},'{CurDate()}','test','{CurDate()}','test')";
            DataWrite(sqlcmd);

        }
        public static void ModifyAppointment(int appid, string title, string type, string start, string end)
        {
            string sqlcmd = $"UPDATE appointment set title='{title}', type = '{type}', start ='{start}', end = '{end}' WHERE appointmentId = '{appid}'";
            DataWrite(sqlcmd);
        }

        public static void AddNewAppointment(int custid, string title, string type, string start, string end)
        {
            string addcount = "SELECT MAX(appointmentId) FROM appointment";
            int appid = DataId(addcount) + 1;
            string sqlcmd = $"INSERT INTO `appointment` VALUES ('{appid}','{custid}',1,'{title}','not needed','not needed','not needed','{type}','not needed','{start}','{end}','{CurDate()}','test','{CurDate()}','test')";
            DataWrite(sqlcmd);
        }
        public static bool AppointmentOverlap(DateTime start, DateTime end)
        {
            start = start.ToUniversalTime();
            string strtchk = start.ToString("yyyy-MM-dd HH:mm:ss");
            end = end.ToUniversalTime();
            string endchk = end.ToString("yyyy-MM-dd HH:mm:ss");
            //string sqlcmd = $"SELECT * FROM appointment WHERE  start BETWEEN '{strtchk}' AND '{ endchk}';";
            string sqlcmd = $"SELECT * FROM appointment WHERE  (start >= '{strtchk}'  AND start < '{ endchk}') OR (end > '{strtchk}' AND end <= '{strtchk}') OR (start <= '{strtchk}' AND end >= '{endchk}');";
            //end > startcheck and end <= startcheck
            //start <= startcheck and end >= endcheck
            //appointid != selected appointid
            Console.WriteLine(sqlcmd);
            MySqlDataReader complete = DataRead(sqlcmd);
            bool status = complete.HasRows;
            sqlConnection.Close();
            return status;
        }
        public static bool AppointmentOverlapForModify(DateTime start, DateTime end, int appId)
        {
            start = start.ToUniversalTime();
            string strtchk = start.ToString("yyyy-MM-dd HH:mm:ss");
            end = end.ToUniversalTime();
            string endchk = end.ToString("yyyy-MM-dd HH:mm:ss");
            //string sqlcmd = $"SELECT * FROM appointment WHERE  start BETWEEN '{strtchk}' AND '{ endchk}';";
            string sqlcmd = $"SELECT * FROM appointment WHERE (appointmentId != '{appId}') AND ((start >= '{strtchk}'  AND start < '{ endchk}') OR (end > '{strtchk}' AND end <= '{strtchk}') OR (start <= '{strtchk}' AND end >= '{endchk}'));";
            //end > startcheck and end <= startcheck
            //start <= startcheck and end >= endcheck
            //appointid != selected appointid
            Console.WriteLine(sqlcmd);
            MySqlDataReader complete = DataRead(sqlcmd);
            bool status = complete.HasRows;
            sqlConnection.Close();
            return status;
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










