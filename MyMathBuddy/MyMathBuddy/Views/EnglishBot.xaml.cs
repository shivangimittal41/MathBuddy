using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyMathBuddy.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EnglishBot : ContentPage
    {
        public EnglishBot()
        {
            InitializeComponent();
            webView.Source = "https://webchat.snatchbot.me/0cea7517261a09d6d5a10044b1cddd155371ef0037ea9d0840a6c311c6ec620b";

        }
    }
}