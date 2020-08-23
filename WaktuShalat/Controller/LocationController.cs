using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System;
using System.Device.Location;
using System.Windows.Forms;
using WaktuShalat.View.UserControls;
using WaktuShalat.Model;
using WaktuShalat.Helper;
using System.Net.Http;

namespace WaktuShalat.Controller
{
    class LocationController
    {
        public bool LocationDetected = false;
        private Location location;
        private String key = "";
        public LocationController()
        {
            location = new Location();
        }

        public async Task<Location> GetLocation()
        {
            Location MyLocation = new Location();
            Uri RequestUrl = new Uri("http://dev.virtualearth.net/REST/v1/Locations/" + location.Latitude + "," + location.Longitude + "?o=json&key=" + key);

            HttpResponseMessage response = await APIHttpHandler.GetResponse(RequestUrl);
            var LocationData = await response.Content.ReadAsStringAsync();

            JObject ObjectLocation = JObject.Parse(LocationData);

            foreach (JObject resourceSets in ObjectLocation.SelectToken("resourceSets"))
            {
                JToken resources = resourceSets.SelectToken("resources");

                JToken arr = resources[0];
                JToken address = arr.SelectToken("address");
                MyLocation.AddressLine = address.SelectToken("addressLine").ToString();
                MyLocation.AdminDistrict = address.SelectToken("adminDistrict2").ToString();
                MyLocation.CountryRegion = address.SelectToken("countryRegion").ToString();
                MyLocation.Locality = address.SelectToken("locality").ToString();
                MyLocation.FormattedAddress = address.SelectToken("formattedAddress").ToString();
            }

            return MyLocation;
        }

        public void RetrieveLocation()
        {
            try
            {
                GeoCoordinateWatcher watcher;
                watcher = new GeoCoordinateWatcher(GeoPositionAccuracy.High);
                watcher.PositionChanged += this.OnLocationChanged;
                bool Started = false;
                watcher.MovementThreshold = 20.0;
                Started = watcher.TryStart(true, TimeSpan.FromMilliseconds(1000));
            }
            catch (Exception ex)
            {
                Page3.Problem = true;
                MessageBox.Show("Tidak bisa mendapatkan lokasi, pastikan GPS sudah diaktifkan" + Environment.NewLine + ex.Message, "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Events

        public async void OnLocationChanged(object sender, GeoPositionChangedEventArgs<GeoCoordinate> e)
        {
            Location MyLocation = null;
            location.Latitude = StrProcessorHelper.CorrectLatitude(e.Position.Location.Latitude.ToString());
            location.Longitude = StrProcessorHelper.CorrectLongitude(e.Position.Location.Longitude.ToString());


            try
            {
                MyLocation = await this.GetLocation();

                LocationDetected = true;

                // Set Location
                Properties.Settings.Default.Locality = MyLocation.Locality;
                Properties.Settings.Default.Address = MyLocation.FormattedAddress;
                Properties.Settings.Default.AdminDistrict = MyLocation.AdminDistrict;
                Page3.LocationDetected = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Tidak bisa mendapatkan lokasi, pastikan Internet menyala", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Page3.Problem = true;
            }



        }
        #endregion
    }
}
