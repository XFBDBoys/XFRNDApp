using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFormApp.Controls;
using XamarinFormApp.iOS;

[assembly: ExportRenderer(typeof(TextBox), typeof(TextBoxRenderer))]
namespace XamarinFormApp.iOS
{
    public class TextBoxRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}