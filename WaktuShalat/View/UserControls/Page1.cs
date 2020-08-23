using System;
using System.Windows.Forms;

namespace WaktuShalat.View.UserControls
{
    public partial class Page1 : UserControl
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            LblTitle.Text = Properties.Resources.Page1_Title;
            LblSubtitle.Text = Properties.Resources.Page1_SubTitle;
        }
    }
}
