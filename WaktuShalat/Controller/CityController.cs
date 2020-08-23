using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaktuShalat.Helper;
using System.Net.Http;

namespace WaktuShalat.Controller
{
    class CityController
    {
        private Uri RequestSupportedCity = new Uri("https://api.banghasan.com/sholat/format/json/kota");

        public async Task<List<Tuple<int, String>>> GetSupportedCities()
        {
            
            List<Tuple<int, String>> supportedCities = new List<Tuple<int, string>>();

            HttpResponseMessage response = await APIHttpHandler.GetResponse(RequestSupportedCity);
            var JSONData = await response.Content.ReadAsStringAsync();

            JObject data = JObject.Parse(JSONData);
            var CitiesData = data.SelectToken("kota") as JArray;

            foreach(JObject city in CitiesData)
            {
                supportedCities.Add(Tuple.Create(int.Parse(city["id"].ToString()), city["nama"].ToString()));
            }

            return supportedCities;
        }

        public async Task<int> GetCityCode()
        {
            string CityName = StrProcessorHelper.CityName(Properties.Settings.Default.AdminDistrict);
            Uri RequestCityCode = new Uri($"https://api.banghasan.com/sholat/format/json/kota/nama/{CityName}");

            int resultId = 0;

            HttpResponseMessage response = await APIHttpHandler.GetResponse(RequestCityCode);
            var data = await response.Content.ReadAsStringAsync();

            var obj = JObject.Parse(data);
            JArray Arr = (JArray)obj["kota"];
            var cities = JArray.FromObject(Arr);
            foreach (JObject city in cities)
            {
                resultId = (int)city["id"];
            }

            return resultId;
        }
    }
}
