using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinFormApp.Views
{
    public partial class CheckboxPage : ContentPage
    {
        List<string> Items2 = new List<string>();
        public CheckboxPage()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Items2.Add(i.ToString());
            }

        }

        
    }
}