using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace WeatherTwentyOne.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritesPage : ContentPage
    {
        public FavoritesPage()
        {
            InitializeComponent();

            NavBar.ActiveTab = "Favorites";
        }
    }
}