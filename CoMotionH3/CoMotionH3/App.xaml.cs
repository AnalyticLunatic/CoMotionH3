using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CoMotionH3.Services;
using CoMotionH3.Views;

namespace CoMotionH3
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
