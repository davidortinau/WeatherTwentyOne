using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            VisualStateManager.GoToState(NavBar, "Favorites");
        }
    }
}