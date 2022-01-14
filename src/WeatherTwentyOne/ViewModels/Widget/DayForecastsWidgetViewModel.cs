using WeatherTwentyOne.Models;
using WeatherTwentyOne.Mvvm;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne.ViewModels.Widget;

public class DayForecastsWidgetViewModel : WidgetViewModel
{
    private readonly IForecastService forecastService;

    public DayForecastsWidgetViewModel(IForecastService forecastService)
    {
        this.forecastService = forecastService;
    }

    private List<Forecast> hours;
    public List<Forecast> Hours 
    {
        get => hours;
        set { SetProperty(ref hours, value); }
    }

    public async Task InitializeAsync()
    {
        Hours = await forecastService.GetDayForecastsAsync(DateTime.Now);
    }
}

