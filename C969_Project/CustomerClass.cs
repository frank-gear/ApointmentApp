using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Project
{
    public class CustomerClass
    {
        public CustomerClass(int custId, string custName, string address, string postal, string phone, int activ, string country, string city)
        {
            CustId = custId;
            CustName = custName;
            Address = address;
            Postal = postal;
            Phone = phone;
            Activ = activ;
            Country = country;
            City = city;
        }

        public CustomerClass()
        {
        }
       
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string Address { get; set; }
        public string Postal { get; set; }
        public string Phone { get; set; }
        public int Activ { get; set; }
        public string Country { get; set; }
        public string City { get; set; }

    }
}
