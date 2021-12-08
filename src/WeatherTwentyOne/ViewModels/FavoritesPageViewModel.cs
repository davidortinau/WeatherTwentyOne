using System.Collections.ObjectModel;
using WeatherClient2021;
using Location = WeatherClient2021.Location;

namespace WeatherTwentyOne.ViewModels;

public class FavoritesPageViewModel : PageViewModel
{
    private readonly IWeatherService weatherService;
    
    public FavoritesPageViewModel(IWeatherService weatherService)
    {
        this.weatherService = weatherService;
    }

    private ObservableCollection<Location> favorites;
    public ObservableCollection<Location> Favorites 
    {
        get => favorites;
        set { SetProperty(ref favorites, value); }
    }

    public override async Task InitializeAsync()
    {
        var locations = await weatherService.GetLocationsAsync(string.Empty);

        Favorites = new ObservableCollection<Location>(locations.Reverse());
    }

}
