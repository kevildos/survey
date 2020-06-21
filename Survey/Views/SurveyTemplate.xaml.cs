using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Survey.Models;

namespace Survey
{
    public partial class SurveyTemplate : ContentPage
    {

        public int PageNumber { get; set; }

        public SurveyTemplate(int number)
        {
            InitializeComponent();
            PageNumber = number;
        }
        
        protected override void OnAppearing()
        {
            base.OnAppearing();

            BindingContext = SurveyData.SurveyFields[PageNumber];
        }

        async void nextButton_Clicked(System.Object sender, System.EventArgs e)
        {
            int nextPageNumber = PageNumber + 1;
            if (SurveyData.SurveyFields.Count > nextPageNumber )
                await Navigation.PushAsync(new SurveyTemplate(nextPageNumber));
            else
                await Navigation.PushAsync(new SurveyEnd());
        }

        void ListOptions_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (SurveyData.SurveyResponses.Count <= PageNumber)
            {
                SurveyData.SurveyResponses.Add(e.SelectedItem as string);
            }
            else
            {
                SurveyData.SurveyResponses.Insert(PageNumber, e.SelectedItem as string);
            }
        }
    }
}
