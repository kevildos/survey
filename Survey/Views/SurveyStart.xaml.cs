using System;
using System.Collections.Generic;
using Survey.Models;
using Xamarin.Forms;

namespace Survey
{
    public partial class SurveyStart : ContentPage
    {
        public const int Starting_Index = 0;

        public SurveyStart()
        {
            InitializeComponent();

            SurveyData.SurveyFields = new Dictionary<int, SurveyForm>();
            SurveyData.SurveyFields.Add(0, new SurveyForm
            {
                Question = "Have you ever felt a butt?",
                Options = new List<string>() { "Yes", "No", "Maybe Yes", "Maybe No" }
            });
            SurveyData.SurveyFields.Add(1, new SurveyForm
            {
                Question = "What is your name?",
                Options = new List<string>() { "Greg", "Stan", "Goat" }
            });

            SurveyData.SurveyResponses = new List<string>();
           
        }

        async void surveyStart_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SurveyTemplate(Starting_Index));
        }
    }
}
