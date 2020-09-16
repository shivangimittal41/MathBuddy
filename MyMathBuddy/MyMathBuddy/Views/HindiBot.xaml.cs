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
    public partial class HindiBot : ContentPage
    {
        public HindiBot()
        {
            InitializeComponent();
            webView.Source = "https://webchat.snatchbot.me/92f3682e93fe06b112c2c41ca63fd84573bd2aac299918a3f83985b9b46f29da";

        }
    }
}