using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileXam
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleApplicationCurrent : ContentPage
    {
        public SampleApplicationCurrent()
        {
            InitializeComponent();
        }

        private async void btnBuatCurrent_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["key"] = txtKey.Text;
            await DisplayAlert("Keterangan", "App Current berhasil dibuat","OK");
        }

        private async void btnCekCurrent_Clicked(object sender, EventArgs e)
        {
            var data = Application.Current.Properties["key"];
            await DisplayAlert("Keterangan", $"Isi Data {data}", "OK");
        }
    }
}