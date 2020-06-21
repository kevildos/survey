using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Survey
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void GenerateSurvey_Clicked(System.Object sender, System.EventArgs e)
        {
            editorURL.Text = "Lol waddup";
        }

        async void deleteButton_Clicked(System.Object sender, System.EventArgs e)
        {
            editorURL.Text = "Lol bitch";

            await Navigation.PushAsync(new SurveyStart());
        }
    }
}
