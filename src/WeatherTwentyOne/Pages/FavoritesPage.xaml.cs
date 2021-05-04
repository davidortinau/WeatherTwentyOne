using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FavoritesPage : ContentPage
    {
        public FavoritesPage()
        {
            BindingContext = new FavoritesViewModel();

            InitializeComponent();            

            NavBar.ActiveTab = "Favorites";
        }
    }
}