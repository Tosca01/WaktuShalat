using System;
using System.ComponentModel;
using WaktuShalat.Helper;
using System.Windows.Forms;
using WaktuShalat.Controller;
using WaktuShalat.Repositories;
using WaktuShalat.Model;

namespace WaktuShalat.View.UserControls
{
    public partial class Page3 : UserControl
    {
        private LocationController locationController = new LocationController();
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private ShalatRepository shalatRepository = new ShalatRepository();
        private AyatRepository ayatRepository = new AyatRepository();

        public static Page3 thisPage;
        public static bool problem = false;
        public static bool locationDetected = false;


        #region Property
        public static bool LocationDetected
        {
            get
            {
                return locationDetected;
            }
            set
            {
                locationDetected = value;
                thisPage.LocationHandler();
            }
        }
        public static bool Problem
        {
            get
            {
                return problem;
            }
            set
            {
                problem = value;
                thisPage.errorHandler();
            }
        }
        public static Page3 ThisPage
        {
            get
            {
                return thisPage;
            }
            set
            {
                thisPage = value;
            }
        }

        #endregion

        #region Handler
        public void errorHandler()
        {
            if (problem)
            {
                if (thisPage.GetLocationWorker.IsBusy)
                {
                    thisPage.GetLocationWorker.CancelAsync();
                }

                MessageBox.Show("Terjadi kesalahan saat proses pendeteksian lokasi" + Environment.NewLine +
                "Silahkan kembali dan setting lokasi manual", "An Error occured",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

                thisPage.HideProccess();
                Setup.Backward();
            }
            else
            {
                thisPage.HideProccess();
            }
        }

        public void LocationHandler()
        {
            if(locationDetected)
            {
                LblFormattedAddress.Text = Properties.Settings.Default.Address;
                LblLocality.Text = Properties.Settings.Default.Locality;

                HideProccess();
            }
        }

        #endregion
        private void HideProccess()
        {
            if (thisPage.GetLocationWorker.IsBusy)
            {
                thisPage.GetLocationWorker.CancelAsync();
            }

            Setup.BtnNextEnabled = true;

            ProgressBar1.Visible = false;
            LblStatus.Visible = false;
        }

        public Page3()
        {
            InitializeComponent();
            thisPage = this;
        }

        private void GetLocationWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                LblStatus.Text = "Mendeteksi alamat..";

                ayatRepository.CreateTableIfNotExists();

                shalatRepository.CreateTableIfNotExists();

                locationController.RetrieveLocation();

            }));
        }

        private void Page3_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DetectLocation)
            {
                try
                {
                    GetLocationWorker.RunWorkerAsync();
                }
                catch(Exception ex)
                {
                    errorHandler();
                }
                
            }

            dbHelper.CreateDatabaseIfNotExists();

        }

    }
}
