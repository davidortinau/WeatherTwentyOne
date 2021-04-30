using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace WeatherTwentyOne.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

            NavBar.ActiveTab = "Settings";
        }
    }
}