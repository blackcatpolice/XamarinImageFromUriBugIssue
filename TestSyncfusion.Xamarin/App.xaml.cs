using System;
using TestSyncfusion.Xamarin.Views.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml; 

namespace TestSyncfusion.Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjE5MjA0QDMxMzcyZTM0MmUzMFV2RWExVkkwMGFUWEdhOUFXZWxKdzFZRGREaGxkVEg0TkpLSUR3VGtUL2s9");

            InitializeComponent();

            MainPage = new WeatherPage();
           // MainPage = new SimpleLoginPage(); 
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
