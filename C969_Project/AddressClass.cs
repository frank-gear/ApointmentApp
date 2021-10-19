using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Project
{
    class AddressClass
    {
        public int AddressId { get; set; }
        public int CustId { get; set; }
        public string Address { get; set; }
        public string Postal { get; set; }
        public string Phone { get; set; }
        public int CityId { get; set; }

        public AddressClass(int addressId, int custId, string address, string postal, string phone, int cityId)
        {
            AddressId = addressId;
            CustId = custId;
            Address = address;
            Postal = postal;
            Phone = phone;
            CityId = cityId;
        }

        public AddressClass()
        {
        }
    }
}
