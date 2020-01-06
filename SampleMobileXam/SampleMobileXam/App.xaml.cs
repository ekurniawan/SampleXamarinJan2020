using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleMobileXam
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SampleList();
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
