using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaktuShalat.Helper
{
    class TimeHelper
    {

        public static CultureInfo id = new CultureInfo("id");
        public static CultureInfo us = new CultureInfo("en-US");
        public static string DateTimeFormat = "dd-MM-yyyy";
        public static string USDateTimeFormat = "yyyy-MM-dd";

        public static string GetHoursAndMinutes()
        {
            return DateTime.Now.ToString("HH:mm");
        }

        public static string GetHoursMinutesAndSeconds()
        {
            return DateTime.Now.ToString("HH:mm:s");
        }

        public static String GetCurrentDate()
        {
            return DateTime.Now.ToString(DateTimeFormat);
        }

        public static String GetCurrentDateWithUSFormat()
        {
           return DateTime.Now.ToString(USDateTimeFormat);
        }

        public static String GetDayName()
        {
            return id.DateTimeFormat.GetDayName(id.Calendar.GetDayOfWeek(DateTime.Now));
        }

        public static String GetMonthName()
        {
            return id.DateTimeFormat.GetMonthName(int.Parse(DateTime.Now.ToString("MM")));
        }


        public static String GetTommorowDate()
        {
            return DateTime.Now.AddDays(+1).ToString(DateTimeFormat);
        }

        public static String GetTommorowDateWithUSFormat()
        {
            return DateTime.Now.AddDays(+1).ToString(USDateTimeFormat);
        }

        public static String GetTommorowDayName()
        {
            return id.DateTimeFormat.GetDayName(id.Calendar.GetDayOfWeek(DateTime.Now.AddDays(+1)));
        }

        #region Parse Waktu
        public static String GetYear(String datetime)
        {
            return DateTime.Parse(datetime).ToString("yyyy");
        }
        
        public static String GetMonth(String datetime)
        {
            return DateTime.Parse(datetime).ToString("MM");
        }

        public static String GetDate(String datetime)
        {
            return DateTime.Parse(datetime).ToString("dd");
        }

        public static String GetHours(String datetime)
        {
            return DateTime.Parse(datetime).ToString("HH");
        }

        #endregion

    }
}
