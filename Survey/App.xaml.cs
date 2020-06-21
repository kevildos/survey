using System;
using System.Collections.Generic;
using Survey.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Survey
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
