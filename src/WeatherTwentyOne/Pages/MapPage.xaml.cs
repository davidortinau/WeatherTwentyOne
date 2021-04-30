using Microsoft.Maui.Controls;

namespace WeatherTwentyOne.Pages
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent(); 
            
            NavBar.ActiveTab = "Map";
        }
    }
}