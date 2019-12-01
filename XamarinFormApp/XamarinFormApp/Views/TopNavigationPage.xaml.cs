using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormApp.Views
{
    public partial class TopNavigationPage : ContentPage
    {
        public TopNavigationPage()
        {
            InitializeComponent();
        }

        void back_tapped(object sender, System.EventArgs e)
        {
            var backPage = new BackPage();
            PlaceHolder.Content = backPage.Content;
        }

        void next_tapped(object sender, System.EventArgs e)
        {
            var nextPage = new NextPage();
            PlaceHolder.Content = nextPage.Content;
        }
    }
}