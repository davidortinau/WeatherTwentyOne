using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTwentyOne.Pages;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace WeatherTwentyOne.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavBarView : FlexLayout
    {
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