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
    public partial class SampleList : ContentPage
    {
        public SampleList()
        {
            InitializeComponent();

            List<string> lstNama = new List<string>
            {
                "Erick",
                "Budi",
                "Bambang",
                "Siti"
            };
            lvSample.ItemsSource = lstNama;
        }
    }
}