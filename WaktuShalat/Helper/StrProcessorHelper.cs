using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaktuShalat.Helper
{
    class StrProcessorHelper
    {
        public static string CorrectLatitude(string latitude)
        {
            return latitude.Replace(",", ".");
        }

        public static string CorrectLongitude(string longitude)
        {
            return longitude.Replace(",", ".");
        }

        public static string CityName(string cityname)
        {
            if(cityname.Contains("kabupaten"))
            {
                return cityname.Replace("kabupaten", "");
            } 
            else if(cityname.Contains("kota"))
            {
                return cityname.Replace("kota", "");
            }

            return cityname;
        }
    }
}
