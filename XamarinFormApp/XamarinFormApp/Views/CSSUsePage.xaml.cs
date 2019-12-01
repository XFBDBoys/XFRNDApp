using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CSSUsePage : ContentPage
    {
        public CSSUsePage()
        {
            InitializeComponent();
            
        }
        async void Recalculate()
        {
           var d = dteDOB.Date;
           var n = entryName.Text;
            var s = spinnerGender.SelectedItem;
           await DisplayAlert("Message", n+"   "+d.ToString("dd-MMM-yyyy")+"\n"+ s, "OK");
            //    TimeSpan timeSpan = endDatePicker.Date - startDatePicker.Date +
            //        (includeSwitch.IsToggled ? TimeSpan.FromDays(1) : TimeSpan.Zero);

            //    resultLabel.Text = String.Format("{0} day{1} between dates",
            //                                        timeSpan.Days, timeSpan.Days == 1 ? "" : "s");
        }

        private void btnSubmit_Clicked(object sender, EventArgs e)
        {
            Recalculate();
        }
    }
}