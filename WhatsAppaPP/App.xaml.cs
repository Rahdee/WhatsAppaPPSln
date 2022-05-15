using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsAppaPP
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigate = new NavigationPage(new MainPage());
            navigate.BarBackgroundColor = Color.DarkSeaGreen;
            MainPage = navigate;
            

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
