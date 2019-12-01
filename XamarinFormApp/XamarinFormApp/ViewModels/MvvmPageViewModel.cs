using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using XamarinFormApp.Views;

namespace XamarinFormApp.ViewModels
{
    public class MvvmPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<string> AllNotes { get; set; }
        string theNote;
        string selectedNode;
        public Command SelectedNodeChangedCommand { get; }
        public Command SaveCommand { get; }
        public Command EraseCommand { get; }

        public MvvmPageViewModel()
        {
            AllNotes = new ObservableCollection<string>();

            EraseCommand = new Command(() => 
            {
                TheNote = string.Empty;
            
            });

            SaveCommand = new Command(() =>
            {
                AllNotes.Add(TheNote);
                TheNote = string.Empty;
            });

            SelectedNodeChangedCommand = new Command(async()=>
            {
                // System.Diagnostics.Debug.WriteLine("//Do Something Cool Here...");
                var nextMvvm = new MvvmNextPageViewModel(SelectedNode);
                var nextMvvmPage = new MvvmNextPage();
                nextMvvmPage.BindingContext = nextMvvm;
                //await Application.Current.MainPage.Navigation.PushAsync(nextMvvmPage);// Show Default Back Icon
                await Application.Current.MainPage.Navigation.PushModalAsync(nextMvvmPage); //Hide Default Back Icon
            });
        }

        public string TheNote
        {
            get => theNote;
            set
            {
                theNote = value;
                var args = new PropertyChangedEventArgs(nameof(TheNote));
                PropertyChanged?.Invoke(this, args);
            }
        }
        public string SelectedNode
        {
            get => selectedNode;
            set
            {
                selectedNode = value;
                var args = new PropertyChangedEventArgs(nameof(SelectedNode));
                PropertyChanged?.Invoke(this, args);
            }
        }



    }
}
