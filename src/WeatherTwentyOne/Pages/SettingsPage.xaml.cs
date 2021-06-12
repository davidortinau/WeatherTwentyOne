using Microsoft.Maui.Controls;
using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Pages
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            BindingContext = new SettingsViewModel();

            NavBar.ActiveTab = "Settings";
        }
    }
}