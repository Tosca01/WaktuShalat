using System;
using System.Drawing;
using System.Windows.Forms;
using MaterialFramework;

namespace WaktuShalat.View.UserControls
{
    public partial class Page2 : UserControl
    {
        public static LollipopTextBox cityName;
        public static bool DetectLocation = true; 

        public static LollipopTextBox CityName
        {
            get
            {
                return cityName;
            }
            set
            {
                cityName = value;
            }
        }
        public Page2()
        {
            InitializeComponent();
            cityName = this.TxtCity;
            BtnCekKota.BackColor = ColorTranslator.FromHtml("#3498db");
        }

        private void CheckDetect_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckDetect.Checked)
            {
                TxtCity.Visible = false;
                BtnCekKota.Visible = false;
                LinkSave.Visible = false;

                // Set Settings
                DetectLocation = true;
                Setup.BtnNextEnabled = true;
                
            }
            else
            {
                Setup.BtnNextEnabled = false;
                BtnCekKota.Visible = true;
                TxtCity.Visible = true;
                LinkSave.Visible = true;

                // Set Settings
                DetectLocation = false;
            }
        }

        private void BtnCekKota_Click(object sender, EventArgs e)
        {
            Cities cities = new Cities();
            cities.Show();
        }

        private void LinkSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AdminDistrict = TxtCity.Text;
            //try
            //{
            //    Properties.Settings.Default.Save();
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(this, "Could not save setting", "An error occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
