using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Survey
{
    public partial class SurveyEnd : ContentPage
    {
        public SurveyEnd()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //BindingContext = App.SurveyResponses;
        }

        async void toDashboard_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
