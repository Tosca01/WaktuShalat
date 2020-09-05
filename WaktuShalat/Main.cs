using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaktuShalat.Controller;
using WaktuShalat.Helper;
using WaktuShalat.Model;
using WaktuShalat.Repositories;

namespace WaktuShalat
{
    public partial class Main : Form
    {
        private TimeController timeController = new TimeController();
        private CityController cityController = new CityController();
        private AyatController ayatController = new AyatController();
        private AyatRepository ayatRepository = new AyatRepository();

        private ShalatController shalatController = new ShalatController();
        private ShalatRepository shalatRepository = new ShalatRepository();

        public static bool tommorow = false;
        private Ayat ayat = new Ayat();
        public static Shalat waktuShalat = new Shalat();

        public static Main main;

        #region Property
        public static bool Tommorow
        {
            get
            {
                return tommorow;
            }
            set
            {
                tommorow = value;
                main.onDayChanged();
            }
        }

        public static Shalat WaktuShalat
        {
            get
            {
                return waktuShalat;
            }
            set
            {
                waktuShalat = value;
                main.onDataShalatChanged();
            }
        }

        #endregion

        #region Handler
        public async void onDayChanged()
        {

            if (Tommorow)
            {
                WaktuShalat = (shalatRepository.CheckIfDataExists(TimeHelper.GetTommorowDateWithUSFormat())) ?
                             shalatRepository.GetByDate(TimeHelper.GetTommorowDateWithUSFormat()) :
                             await shalatController.GetJadwal(TimeHelper.GetTommorowDateWithUSFormat());

                
            }
        }

        public void onDataShalatChanged()
        {
            if (waktuShalat.tanggal != TimeHelper.GetCurrentDateWithUSFormat())
            {
                ShowData();

                var data = timeController.ShalatSelanjutnya(waktuShalat);

                ValidateBeforeStartCountdown(data);
            }
        }

        #endregion

        #region Initialization

        public Main()
        {
            InitializeComponent();

            TransparentLabel();

            main = this;
        }

        private void TransparentLabel()
        {
            Point position = PointToScreen(LblWaktuShalatSelanjutnya.Location);
            position = PictMosque.PointToClient(position);
            LblWaktuShalatSelanjutnya.Parent = PictMosque;
            LblWaktuShalatSelanjutnya.Location = position;

            position = PointToScreen(LblJam.Location);
            position = PictMosque.PointToClient(position);
            LblJam.Parent = PictMosque;
            LblJam.Location = position;

            position = PointToScreen(LblNamaShalat.Location);
            position = PictMosque.PointToClient(position);
            LblNamaShalat.Parent = PictMosque;
            LblNamaShalat.Location = position;

            position = PointToScreen(LblHitungMundur.Location);
            position = PictMosque.PointToClient(position);
            LblHitungMundur.Parent = PictMosque;
            LblHitungMundur.Location = position;
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            LblDate.Text = TimeHelper.GetDayName() + " " + TimeHelper.GetCurrentDate();
            LblLocality.Text = Properties.Settings.Default.AdminDistrict;
            LblFormattedAddress.Text = Properties.Settings.Default.Address;
            //timeController
        }

        private async void Main_Shown(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.CityCode = await cityController.GetCityCode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not get city code" + Environment.NewLine + "Error : " + ex.Message, "An Error occured",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if(shalatRepository.CheckIfDataExists(TimeHelper.GetCurrentDateWithUSFormat()))
            {
                waktuShalat = shalatRepository.GetByDate(TimeHelper.GetCurrentDateWithUSFormat());
            } 
            else
            {
                waktuShalat = await shalatController.GetJadwal();
                shalatRepository.Insert(waktuShalat);
            }

            ayat = await ayatController.GetAyat();

            Task.Run(() => ayatRepository.Insert(ayat));

            ShowData();

            var data = timeController.ShalatSelanjutnya(waktuShalat);

            ValidateBeforeStartCountdown(data);

        }

        private void ValidateBeforeStartCountdown(Tuple<String, DateTime> data)
        {
            if (data.Item1 == "")
            {
                if (!Tommorow) Tommorow = true;

                //parsing waktu
                var end = timeController.BuildDate($"{TimeHelper.GetTommorowDateWithUSFormat()} {waktuShalat.subuh}");

                LblNamaShalat.Text = "subuh";
                LblJam.Text = waktuShalat.subuh;

                timeController.StartCountdown(end);

                CountDown.Start();
            }
            else
            {
                LblNamaShalat.Text = data.Item1;
                LblJam.Text = data.Item2.ToString("HH:mm");

                DateTime EndTime = data.Item2;

                timeController.StartCountdown(EndTime);

                CountDown.Start();
            }
        }

        private void ShowData()
        {
            materialListView1.Items.Clear();

            materialListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            materialListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            BuildData();

            LblJadwalShalat.Text = (Tommorow) ? "Jadwal Shalat (Besok)" : "Jadwal Shalat";

            LblAyatAcak.Text = ayat.terjemah;
            LblNamaSurah.Text = ayat.surah;
        }

        private void BuildData()
        {
            PropertyInfo[] properties = typeof(Shalat).GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.Name != "id" && property.Name != "tanggal")
                {
                    materialListView1.Items.Add(property.Name).SubItems.Add(property.GetValue(waktuShalat).ToString());
                }
            }
        }

        private void CountDown_Tick(object sender, EventArgs e)
        {
            LblHitungMundur.Text = timeController.TimeRemaining;
        }
    }
}