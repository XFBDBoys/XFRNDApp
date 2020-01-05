using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormApp.Views
{
    public partial class PopupPage : ContentPage
    {
        public PopupPage()
        {
            InitializeComponent();
        }

        private void btnDisplayPopup_Clicked(object sender, EventArgs e)
        {
            Overlay.IsVisible = true;
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {

        }

        private void CloseButton_Clicked(object sender, EventArgs e)
        {
            Overlay.IsVisible = false;
        }
    }
}