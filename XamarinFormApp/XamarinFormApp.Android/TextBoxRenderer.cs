using Android.Content;
using Android.Graphics.Drawables;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinFormApp;
using XamarinFormApp.Controls;
using XamarinFormApp.Droid;

[assembly: ExportRenderer(typeof(TextBox), typeof(TextBoxRenderer))]
namespace XamarinFormApp.Droid
{
    public class TextBoxRenderer : EntryRenderer
    {
        public TextBoxRenderer(Context context) : base(context)
        {
            AutoPackage = false;
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = new ColorDrawable(Android.Graphics.Color.Transparent);
            }
        }
    }
}