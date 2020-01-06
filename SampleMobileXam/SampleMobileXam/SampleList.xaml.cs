using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileXam
{
    public class ListItem
    {
        public string Username { get; set; }
        public string Pesan { get; set; }
    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleList : ContentPage
    {
        public SampleList()
        {
            InitializeComponent();

            List<ListItem> lstItem = new List<ListItem>
            {
                new ListItem { Username="Erick",Pesan="Belajar Xamarin" },
                new ListItem { Username="Budi",Pesan="Belajar Xamarin Android" },
                new ListItem { Username="Bambang",Pesan="Belajar Xamarin IOS" },
            };
           
            lvSample.ItemsSource = lstItem;
        }

        private void lvSample_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //string nama = (string)e.Item;
            //DisplayAlert("Keterangan", $"Nama yang dipilih: {nama}", "OK");
            //((ListView)sender).SelectedItem = null;
        }
    }
}