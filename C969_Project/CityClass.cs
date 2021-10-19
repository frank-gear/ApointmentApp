using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Project
{
    class CityClass
    {
        public int CityId { get; set; }
        public int CountryId { get; set; }

        public string CityName { get; set; }

        public CityClass(int cityId, int countryId, string cityName)
        {
            CityId = cityId;
            CountryId = countryId;
            CityName = cityName;
        }

        public CityClass()
        {
        }
    }
}
