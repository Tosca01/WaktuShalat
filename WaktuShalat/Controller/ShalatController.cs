using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WaktuShalat.Helper;
using WaktuShalat.Model;

namespace WaktuShalat.Controller
{
    internal class ShalatController
    {
        private Uri RequestShalatUrl;
        private int cityCode;

        public ShalatController()
        {
            string currentDate = TimeHelper.GetCurrentDateWithUSFormat();
            cityCode = Properties.Settings.Default.CityCode;
            RequestShalatUrl = new Uri($"https://api.banghasan.com/sholat/format/json/jadwal/kota/{cityCode}/tanggal/{currentDate}");
        }

        public async Task<Shalat> GetJadwal(string date = null)
        {
            Shalat waktuShalat = null;

            if (date != null)
            {
                RequestShalatUrl = new Uri($"https://api.banghasan.com/sholat/format/json/jadwal/kota/{cityCode}/tanggal/{date}");
            }

            HttpResponseMessage response = await APIHttpHandler.GetResponse(RequestShalatUrl);
            var data = await response.Content.ReadAsStringAsync();

            JObject responseData = JObject.Parse(data);
            var query = responseData["query"];
            JObject jadwal = (JObject)responseData["jadwal"];
            JObject dataJadwal = (JObject)jadwal["data"];

            waktuShalat = JsonConvert.DeserializeObject<Shalat>(dataJadwal.ToString());
            waktuShalat.tanggal = query["tanggal"].ToString();

            return waktuShalat;
        }
        
    }
}