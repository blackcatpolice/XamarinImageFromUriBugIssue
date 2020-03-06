using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TestSyncfusion.Xamarin.Controls.BorderlessEntry), typeof(TestSyncfusion.Xamarin.iOS.BorderlessEntryRenderer))]

namespace TestSyncfusion.Xamarin.iOS
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (this.Control != null)
            {
                this.Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}