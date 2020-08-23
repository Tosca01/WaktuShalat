using System;

namespace WaktuShalat.Model
{
    public class Shalat
    {
        public int id { get; set; }
        public String tanggal { get; set; }
        public String subuh { get; set; }
        public String terbit { get; set; }
        public String dhuha { get; set; }
        public String dzuhur { get; set; }
        public String ashar { get; set; }
        public String maghrib { get; set; }
        public String isya { get; set; }
    }
}
