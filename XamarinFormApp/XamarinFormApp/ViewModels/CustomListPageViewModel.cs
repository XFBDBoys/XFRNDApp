using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinFormApp.Models;

namespace XamarinFormApp.ViewModels
{
    public class CustomListPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string name;
        private string location;
        private string details;
        public Command AddItemCommand { get; }
        public ObservableCollection<Animal> animals { get; private set; }

        public CustomListPageViewModel()
        {
            try
            {
                animals = new ObservableCollection<Animal>();
                AddItemCommand = new Command(() =>
                {
                    CreateItemCollection();
                });
            }
            catch (Exception ex)
            {

            }
        }

        private void CreateItemCollection()
        {
            Animal _animal = new Animal();
            _animal.AnimalName = Name;
            _animal.AnimalLocation = Location;
            _animal.AnimalDetails = Details;

            animals.Add(_animal);
            
            Name = string.Empty;
            Location = string.Empty;
            Details = string.Empty;
        }

        public string Name 
        { 
            get => name;
            set
            {
                name = value;
                var args = new PropertyChangedEventArgs(nameof(name));
                PropertyChanged?.Invoke(this, args);
            }  
        }
        public string Location
        {
            get => location;
            set
            {
                location = value;
                var args = new PropertyChangedEventArgs(nameof(location));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string Details
        {
            get => details;
            set
            {
                details = value;
                var args = new PropertyChangedEventArgs(nameof(details));
                PropertyChanged?.Invoke(this, args);
            }
        }
       
        
    }
}
