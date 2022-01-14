﻿using WeatherTwentyOne.ViewModels;

namespace WeatherTwentyOne.Pages;

public partial class FavoritesPage : ContentPage
{
    private FavoritesPageViewModel viewModel;

    public FavoritesPage()
    {
        InitializeComponent();

        viewModel = ServiceLocator.GetService<FavoritesPageViewModel>();

        BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await viewModel.InitializeAsync();
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
