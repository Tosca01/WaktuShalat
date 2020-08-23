using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WaktuShalat.Helper;
using WaktuShalat.Model;

namespace WaktuShalat.Controller
{
    class AyatController
    {
        public async Task<Ayat> GetAyat()
        {
            Uri RequestUrl = new Uri("https://api.banghasan.com/quran/format/json/acak");

            Ayat ayat = new Ayat();

            HttpResponseMessage response = await APIHttpHandler.GetResponse(RequestUrl);
            var AyatData = await response.Content.ReadAsStringAsync();

            JObject data = JObject.Parse(AyatData);
            JToken acak = data.SelectToken("acak");
            JToken id = acak.SelectToken("id");

            ayat.terjemah = id.SelectToken("teks").ToString();

            JToken ar = acak.SelectToken("ar");
            ayat.isi = ar.SelectToken("teks").ToString();


            JToken surah = data.SelectToken("surat");
            ayat.surah = surah.SelectToken("nama").ToString();

            return ayat;

        }
    }
}
