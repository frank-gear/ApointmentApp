using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
namespace C969_Project
{
    public static class DataClass
    {
        public static string wguDatabase = "server=wgudb.ucertify.com;userid=U04iSl;password=53688253345;database=U04iSl";

        public static MySqlConnection sqlConnection = new MySqlConnection(wguDatabase);
        
        
        
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
            string[] appointment =
            {
              "INSERT INTO `appointment` VALUES (1,1,1,'not needed','not needed','not needed','not needed','Presentation','not needed','2019-01-01 00:00:00','2019-01-01 00:00:00','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')",
              "INSERT INTO `appointment` VALUES (2,2,1,'not needed','not needed','not needed','not needed','Scrum','not needed','2019-01-01 00:00:00','2019-01-01 00:00:00','2019-01-01 00:00:00','test','2019-01-01 00:00:00','test')"
            };
            DataWrite(appointment[0]);
            DataWrite(appointment[1]);
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
            sqlConnection.Open();
            DataWrite(sqlcmd1);
            DataWrite(sqlcmd2);
            sqlConnection.Close();
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
    }
}










