using Microsoft.Maui.Controls;
using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Pages
{
    public partial class FavoritesPage : ContentPage
    {
        public FavoritesPage()
        {
            InitializeComponent();

            BindingContext = new FavoritesViewModel();

            NavBar.ActiveTab = "Favorites";
        }
    }
}