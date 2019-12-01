using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Xamarin.Forms;

namespace XamarinFormApp.ViewModels
{
    public class MvvmNextPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string noteText;
        public Command DismisPageCommand { get; }
        public MvvmNextPageViewModel(string note)
        {
            NoteText = note;
            DismisPageCommand = new Command(async()=>
            {
                // System.Diagnostics.Debug.WriteLine("//Do Something Cool Here...");
                //await Application.Current.MainPage.Navigation.PopAsync();  // Show Default Back Icon
                await Application.Current.MainPage.Navigation.PopModalAsync(); //Hide Default Back Icon
            });
        }

        public string NoteText 
        { 
            get => noteText;
            set
            {
                noteText = value;
                var args = new PropertyChangedEventArgs(nameof(noteText));
                PropertyChanged?.Invoke(this, args);
            }
        }

    }
}
