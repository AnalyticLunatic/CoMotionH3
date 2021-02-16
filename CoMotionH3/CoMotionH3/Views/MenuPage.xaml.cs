using CoMotionH3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CoMotionH3.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                //new HomeMenuItem {Id = MenuItemType.SignIn, Title="Kennel History" },
                new HomeMenuItem {Id = MenuItemType.SignIn, Title="Trail Sign-in" },
                new HomeMenuItem {Id = MenuItemType.SignIn, Title="Hasher Details" },
                new HomeMenuItem {Id = MenuItemType.SignIn, Title="Trail Counts" },
                new HomeMenuItem {Id = MenuItemType.SignIn, Title="Hare Counts" },
                new HomeMenuItem {Id = MenuItemType.SignIn, Title="Upcoming Trails" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}