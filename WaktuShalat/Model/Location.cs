using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaktuShalat.Model
{
    class Location
    {
        private String locality;
        private String formattedAddress;
        private String countryRegion;
        private String addressLine;
        private String adminDistrict;
        private String latitude;
        private String longitude;
        public string Locality { get => locality; set => locality = value; }
        public string FormattedAddress { get => formattedAddress; set => formattedAddress = value; }
        public string CountryRegion { get => countryRegion; set => countryRegion = value; }
        public string AddressLine { get => addressLine; set => addressLine = value; }
        public string AdminDistrict { get => adminDistrict; set => adminDistrict = value; }
        public string Latitude { get => latitude; set => latitude = value; }
        public string Longitude { get => longitude; set => longitude = value; }
    }
}
