﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormApp.Views;

namespace XamarinFormApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new SplashPage());
            //MainPage = new NavigationPage(new LoginPage());
            MainPage = new NavigationPage(new DashBoard());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
