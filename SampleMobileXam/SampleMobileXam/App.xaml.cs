using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileXam
{
    public partial class App : Application
    {
        //startup
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
