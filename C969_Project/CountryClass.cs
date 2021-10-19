using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Project
{
    class CountryClass
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public CountryClass(int countryId, string countryName)
        {
            CountryId = countryId;
            CountryName = countryName;
        }

        public CountryClass()
        {
        }
    }
}
