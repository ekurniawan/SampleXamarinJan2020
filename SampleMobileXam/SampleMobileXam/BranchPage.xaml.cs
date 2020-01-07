using SampleMobileXam.Services;
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
    public partial class BranchPage : ContentPage
    {
        public BranchPage()
        {
            InitializeComponent();
        }

        private async void btnLoad_Clicked(object sender, EventArgs e)
        {
            BranchServices branchServices = new BranchServices();
            lvBranch.ItemsSource = await branchServices.GetAll();
        }
    }
}