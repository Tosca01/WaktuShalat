using System;
using System.Reflection;
using System.Timers;
using WaktuShalat.Helper;
using WaktuShalat.Model;

namespace WaktuShalat.Controller
{
    internal class TimeController
    {
        private DateTime GlobalDisplayDate;
        public string TimeRemaining;

        private DateTime EndTime;
        private Timer Countdown;

        public TimeController()
        {
            this.GlobalDisplayDate = DateTime.Parse(TimeHelper.GetCurrentDate());
            //BuildDate();
            Countdown = new Timer();
            Countdown.Elapsed += Countdown_elapsed;
        }

        private void Countdown_elapsed(object sender, ElapsedEventArgs e)
        {

            TimeSpan ts = EndTime.Subtract(DateTime.Now);
            if (ts.TotalMilliseconds > 0)
            {
                TimeRemaining = $"({ts.ToString(@"hh\:mm\:ss")})";
            }
        }


        public void StartCountdown(DateTime end)
        {
            this.EndTime = end;
            Countdown.Start();
        }

        private void SetToNextDay()
        {
            this.GlobalDisplayDate = this.GlobalDisplayDate.AddDays(+1);
        }

        public Tuple<string, DateTime> ShalatSelanjutnya(Shalat shalat)
        {
            PropertyInfo[] properties = typeof(Shalat).GetProperties();

            TimeSpan currentTime = TimeSpan.Parse(TimeHelper.GetHoursAndMinutes());

            foreach (PropertyInfo property in properties)
            {
                if (property.Name != "id" && property.Name != "tanggal")
                {
                    string value = property.GetValue(shalat).ToString();

                    if (currentTime < TimeSpan.Parse(value))
                    {
                        EndTime = DateTime.ParseExact(property.GetValue(shalat).ToString(), "HH:mm", null);

                        return Tuple.Create(property.Name, EndTime);
                    }
                }
            }

            return Tuple.Create("", EndTime);
        }

        public DateTime BuildDate(string DateAndTime)
        {
            return DateTime.ParseExact(DateAndTime, "yyyy-MM-dd HH:mm", null);
        }

        public TimeSpan BuildTimeSpan(string DateAndTime)
        {
            return TimeSpan.ParseExact(DateAndTime, "yyyy-MM-dd HH:mm:ss", null);
        }
    }
}