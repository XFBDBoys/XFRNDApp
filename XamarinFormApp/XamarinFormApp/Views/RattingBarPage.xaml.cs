using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormApp.ViewModels;

namespace XamarinFormApp.Views
{
    public partial class RattingBarPage : ContentPage
    {
        public RattingBarPage()
        {
            InitializeComponent();
            this.BindingContext = new RattingBarViewModal();
        }
    }
}