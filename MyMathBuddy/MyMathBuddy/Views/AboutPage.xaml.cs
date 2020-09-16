using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMathBuddy.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        private async void English_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnglishBot());
        }

        private async void Hindi_Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HindiBot());

        }
    }
}