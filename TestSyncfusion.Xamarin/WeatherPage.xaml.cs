using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Xamarin.Forms;

namespace TestSyncfusion.Xamarin
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            var uri = "http://assets.weatherstack.com/images/wsymbols01_png_64/wsymbol_0001_sunny.png";// "http://img2.imgtn.bdimg.com/it/u=3695181821,3569812507&fm=26&gp=0.jpg"; // "https://assets.weatherstack.com/images/wsymbols01_png_64/wsymbol_0001_sunny.png"; 
            var uri2 = "https://docs.microsoft.com/en-us/xamarin/get-started/tutorials/image/images/create-image.png";
            //BindingContext = new { ImageUri = uri };
            //ImageSource.FromUri
            //img.Source = new UriImageSource() { CachingEnabled = true, Uri = new Uri(uri) };
            // img2.Source = new UriImageSource() { CachingEnabled = true, Uri = new Uri(uri2) };

            //webImg.Source = new UriImageSource
            //{
            //    Uri = new Uri("https://xamarin.com/content/images/pages/forms/example-app.png"),
            //    CachingEnabled = true,
            //    CacheValidity = new TimeSpan(5, 0, 0, 0)
            //};
            //var wc = new WebClient();
            //var bytearr = wc.DownloadData(uri);
            //var stream = new MemoryStream(bytearr);
            //webImg.Source = ImageSource.FromStream(() => stream);
            
            base.OnAppearing();
        }

        protected override SizeRequest OnMeasure(double widthConstraint, double heightConstraint)
        {


            return base.OnMeasure(widthConstraint, heightConstraint);
        }
    }
}
