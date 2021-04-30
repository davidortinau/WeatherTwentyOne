using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTwentyOne.Pages;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using System.Runtime.CompilerServices;

namespace WeatherTwentyOne.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavBarView : Grid
    {
        private string activeTab;
        public string ActiveTab
        {
            get
            {
                return activeTab;
            }
            set
            {
                activeTab = value;

                var target = activeTab;
                var homeImg = (target == "Home") ? "tab_home_on.png" : "tab_home.png";
                var favImg = (target == "Favorites") ? "tab_favorites_on.png" : "tab_favorites.png";
                var settingsImg = (target == "Settings") ? "tab_settings_on.png" : "tab_settings.png";

                HomeTab.Source = ImageSource.FromFile(homeImg);
                FavoritesTab.Source = ImageSource.FromFile(favImg);
                SettingsTab.Source = ImageSource.FromFile(settingsImg);
            }
        }

        public NavBarView()
        {
            InitializeComponent();
        }

        private void HomeTab_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new HomePage());
        }

        private void FavoritesTab_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new FavoritesPage());
        }

        private void MapTab_Clicked(object sender, EventArgs e)
        {

        }

        private void SettingsTab_Clicked(object sender, EventArgs e)
        {
            (App.Current.MainPage as NavigationPage).PushAsync(new SettingsPage());
        }

        
    }
}