using System;
using System.Threading.Tasks;
using System.Collections.Generic;
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

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //await Task.Delay(300);
            //TransitionIn();
        }

        async void TransitionIn()
        {
            foreach (var item in tiles)
            {
                item.FadeTo(1, 800);
                await Task.Delay(50);
            }
        }

        int tileCount = 0;
        List<Frame> tiles = new List<Frame>();
        async void OnHandlerChanged(object sender, EventArgs e)
        {
            Frame f = (Frame)sender;
            tiles.Add(f);
            tileCount++;
        }
    }
}