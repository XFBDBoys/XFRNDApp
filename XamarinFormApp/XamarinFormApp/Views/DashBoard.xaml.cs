using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormApp.Views
{
    public partial class DashBoard : ContentPage
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private async void btnDropdown_Clicked(object sender, EventArgs e)
        {
          await Navigation.PushAsync(new DropdownPage());
        }

        private async void btnCheckbox_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CheckboxPage());
        }

        private async void btnDatePicker_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DatePickerPage());
        }

        private async void btnMvvm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MvvmPage());
        }

        private void btnDialogBox_Clicked(object sender, EventArgs e)
        {

        }

        
        private async void btnList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomListPage());
        }

        

        private async void btnCustomEntry_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CustomEntryPage());
        }

        private async void btnFormOne_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CSSUsePage());
        }
    }
}