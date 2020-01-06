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
            btnGrid.Clicked += BtnGrid_Clicked;
            btnList.Clicked += BtnList_Clicked;
        }

        private async void BtnList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleList());
        }

        private async void BtnGrid_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleGridLayout());
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            double bil1 = Convert.ToDouble(txtBil1.Text);
            double bil2 = Convert.ToDouble(txtBil2.Text);
            double hasil = bil1 + bil2;
            txtHasil.Text = hasil.ToString();
        }

        private async void menuJam_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyTabbedPage());
        }

        private async void btnDisplayAlert_Clicked(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: SavePhoto?",
"Cancel", "Delete", "Photo Roll", "Email");
            await DisplayAlert("Keterangan", $"Anda memilih {action}", "OK");
        }

        private async void btnKirimParam_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TerimaParameter(
                Convert.ToDouble(txtBil1.Text),
                Convert.ToDouble(txtBil2.Text)));
        }

        private async void btnAppCurrent_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleApplicationCurrent());
        }

        private async void btnAddEmployee_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployee());
        }
    }

}
