using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormApp.Models;

namespace XamarinFormApp.Views
{
    public partial class DropdownPage : ContentPage
    {
        private StackLayout _stackLayout;
        private Picker _picker;
        private Button _button;
        private Entry _entry;
        public DropdownPage()
        {
            InitializeComponent();
            List<GenderModel> _genders = new List<GenderModel>
            {
                new GenderModel{ID=1,Name="Male"},
                new GenderModel{ID=2,Name="Female"},
                new GenderModel{ID=3,Name="Common"}
            };
            gender.ItemsSource = _genders;
            //_stackLayout = new StackLayout();
            //_picker = new Picker();
            //_picker.Title = "Select Gender";
            //_picker.ItemsSource = _genders;
            //_stackLayout.Children.Add(_picker);

            //_button = new Button();
            //_button.Text = "Result";
            //_button.Clicked += _button_Clicked;
            //_stackLayout.Children.Add(_button);

            //_entry = new Entry();
            //_entry.Keyboard = Keyboard.Text;
            //_entry.Placeholder = "Please Select Gender";
            //_stackLayout.Children.Add(_entry);

            //Content = _stackLayout;
        }
        private void _button_Clicked(object sender, EventArgs e)
        {
            _entry.Text = _picker.SelectedItem.ToString();
        }

        private void btnShow_Clicked(object sender, EventArgs e)
        {
            try
            {
                entry.Text = gender.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
              
            }
           
        }
    }
}