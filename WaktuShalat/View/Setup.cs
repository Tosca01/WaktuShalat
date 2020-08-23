using System;
using System.Windows.Forms;
using WaktuShalat.View.UserControls;

namespace WaktuShalat.View
{
    public partial class Setup : Form
    {
        public static Setup frmSetup;
        public int page = 1;
        public static bool btnNextEnabled;

        #region Property
        public static Setup Instance
        {
            get
            {
                if (frmSetup == null)
                {
                    frmSetup = new Setup();
                }
                return frmSetup;
            }
        }

        public static bool BtnNextEnabled
        {
            get
            {
                return btnNextEnabled;
            }
            set
            {
                btnNextEnabled = value;
                frmSetup.BtnNext.Enabled = value;
            }
        }

        public Panel PnlContainer
        {
            get
            {
                return this.PanelContainer;
            }
            set
            {
                PanelContainer = value;
            }
        }
        #endregion

        public Setup()
        {
            InitializeComponent();
            frmSetup = this;
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            BackLink.Visible = false;
            Page1 page1 = new Page1();

            page1.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(page1);
        }

        public static void Backward()
        {
            Instance.BackLink.PerformClick();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            BackLink.Visible = true;
            if (page == 1 && PanelContainer.Controls.ContainsKey("Page2"))
            {
                PanelContainer.Controls["Page2"].BringToFront();
                page = 2;
            }
            else if (page == 2 && PanelContainer.Controls.ContainsKey("Page3"))
            {
                // Set detect location settings
                Properties.Settings.Default.DetectLocation = Page2.DetectLocation;
                Properties.Settings.Default.Save();

                PanelContainer.Controls["Page3"].BringToFront();
                BtnNext.Enabled = false;
                page = 3;
            }
            else if (page == 1 && PanelContainer.Controls.ContainsKey("Page2") == false)
            {
                Page2 page2 = new Page2();
                page2.Dock = DockStyle.Fill;
                PanelContainer.Controls.Add(page2);
                PanelContainer.Controls["Page2"].BringToFront();
                page = 2;
            }
            else if (page == 2 && PanelContainer.Controls.ContainsKey("Page3") == false)
            {
                Page3 page3 = new Page3();
                page3.Dock = DockStyle.Fill;
                
                // Set detect location settings
                Properties.Settings.Default.DetectLocation = Page2.DetectLocation;
                Properties.Settings.Default.Save();

                if(Page2.DetectLocation == false && Page2.CityName == null)
                {
                    MessageBox.Show("Error : Nama kota belum diisi", "An error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PanelContainer.Controls.Add(page3);
                    PanelContainer.Controls["Page3"].BringToFront();
                    BtnNext.Enabled = false;
                    page = 3;
                }
                
            }
            else if (page == 3)
            {
                Properties.Settings.Default.FirstLaunch = false;
                Main main = new Main();
                main.Show();
                Hide();
            }

        }

        private void BackLink_Click(object sender, EventArgs e)
        {
            if (page == 2)
            {
                page = 1;
                PanelContainer.Controls["Page1"].BringToFront();
                BackLink.Visible = false;
            }else if (page == 3)
            {
                page = 2;
                PanelContainer.Controls["Page2"].BringToFront();
                BtnNext.Enabled = true;
            }
        }
    }
}
