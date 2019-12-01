using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinFormApp.Controls
{
    public class CustomEntry : Entry
    {
        //public static readonly Thickness width =  
        public static readonly BindableProperty EntryHeightProperty =
            BindableProperty.Create(
                nameof(TextBoxHeight),
                typeof(int),
                typeof(CustomEntry));
        public int TextBoxHeight
        {
            get { return (int)GetValue(EntryHeightProperty); }
            set { SetValue(EntryHeightProperty, value); }
        }

        public static readonly BindableProperty BorderColorProperty =
        BindableProperty.Create(
            nameof(BorderColor),
            typeof(Color),
            typeof(CustomEntry),
            Color.Gray);
        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty BorderWidthProperty =
            BindableProperty.Create(
                nameof(BorderWidth),
                typeof(int),
                typeof(CustomEntry),
                Device.OnPlatform<int>(1,2,2));
        public int BorderWidth
        {
            get { return (int)GetValue(BorderWidthProperty); }
            set { SetValue(BorderWidthProperty, value); }
        }

        
    }
}
