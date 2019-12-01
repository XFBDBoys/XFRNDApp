using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormApp.Controls
{
    public class Spinner : Picker
    {
        public static readonly BindableProperty ImageProperty =
            BindableProperty.Create(
                nameof(Image), 
                typeof(string), 
                typeof(Spinner), 
                string.Empty
                );

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
    }
}
