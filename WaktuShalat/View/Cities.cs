using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using WaktuShalat.View.UserControls;
using WaktuShalat.Controller;
using System.Windows.Forms;

namespace WaktuShalat.View
{
    public partial class Cities : Form
    {
        private DataTable dataTable = new DataTable();
        private CityController cityController = new CityController();
        private List<String> cityData = new List<String>();
        public Cities()
        {
            InitializeComponent();
            
        }

        private async void Cities_Load(object sender, EventArgs e)
        {
            var cities = await cityController.GetSupportedCities();
            foreach (var item in cities)
            {
                cityData.Add(item.Item2);
            }

            dataTable.Columns.Add("City", typeof(string));
            foreach(String city in cityData)
            {
                dataTable.Rows.Add(city);
            }
            listCity.DataSource = dataTable;
            listCity.DisplayMember = "City";
            lblTotal.Text = listCity.Items.Count.ToString() + " Kota";
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = "[City] like '%" + TxtSearch.Text + "%'";
        }

        private void BtnPilih_Click(object sender, EventArgs e)
        {
            if(listCity.SelectedItem != null)
            {
                Page2.CityName.Text = ((DataRowView)listCity.SelectedItem)["City"].ToString();
            }

            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
