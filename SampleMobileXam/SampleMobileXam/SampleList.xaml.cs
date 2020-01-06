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
        public string Pic { get; set; }
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
                new ListItem { Username="Erick",Pesan="Belajar Xamarin",Pic="monkey1.png" },
                new ListItem { Username="Budi",Pesan="Belajar Xamarin Android",Pic="monkey2.jpg" },
                new ListItem { Username="Bambang",Pesan="Belajar Xamarin IOS",Pic="monkey3.jpg" }
            };
           
            lvSample.ItemsSource = lstItem;
        }

        private void lvSample_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem data = (ListItem)e.Item;
            DisplayAlert("Keterangan", $"Username yang dipilih: {data.Username}", "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}