using WeatherTwentyOne.Models;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne.ViewModels.Widget;

public class WeekForecastsWidgetViewModel : WidgetViewModel
{
    private readonly IForecastService forecastService;

    public WeekForecastsWidgetViewModel(IForecastService forecastService)
    {
        this.forecastService = forecastService;
    }

    private List<Forecast> week;
    public List<Forecast> Week 
    {
        get => week;
        set { SetProperty(ref week, value); }
    }

    public async Task InitializeAsync()
    {
        Week = await forecastService.GetWeekForecastsAsync(DateTime.Today);
    }
}
