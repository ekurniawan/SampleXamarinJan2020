using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleMobileXam
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnUpdate.Clicked += BtnUpdate_Clicked;
        }

        private void BtnUpdate_Clicked(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = bil1 + bil2;
            txtHasil.Text = hasil.ToString();
        }
    }
}
