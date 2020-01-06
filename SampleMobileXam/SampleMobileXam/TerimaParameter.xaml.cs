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
    public partial class TerimaParameter : ContentPage
    {
        public TerimaParameter()
        {
            InitializeComponent();
        }

        public TerimaParameter(double bil1,double bil2)
        {
            InitializeComponent();
            lblBil1.Text = bil1.ToString();
            lblBil2.Text = bil2.ToString();
        }
    }
}