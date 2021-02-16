using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoMotionH3.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public ICommand TapCommand => new Command<string>(OpenBrowser);

        public AboutPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void OpenBrowser(string url)
        {
            Launcher.OpenAsync(new Uri(url));
        }

        public void btnEmailComotion_Clicked(object sender, EventArgs args)
        {
            var emailAddress = "comotionh3@gmail.com";
            Launcher.OpenAsync(new Uri($"mailto:{emailAddress}"));
        }
    }
}