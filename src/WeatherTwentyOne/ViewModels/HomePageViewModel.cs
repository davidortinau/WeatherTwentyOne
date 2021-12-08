using WeatherTwentyOne.Models;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne.ViewModels;

public class HomePageViewModel : PageViewModel
{
    private readonly IForecastService forecastService;

    public HomePageViewModel(IForecastService forecastService)
    {
        this.forecastService = forecastService;
    }

    private List<Forecast> week;
    public List<Forecast> Week 
    {
        get => week;
        set { SetProperty(ref week, value); }
    }

    private List<Forecast> hours;
    public List<Forecast> Hours 
    {
        get => hours;
        set { SetProperty(ref hours, value); }
    }

    public override async Task InitializeAsync()
    {
        Week = await forecastService.GetWeekForecastsAsync(DateTime.Today);

        Hours = await forecastService.GetDayForecastsAsync(DateTime.Now);
    }
}
