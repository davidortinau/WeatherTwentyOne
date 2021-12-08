using WeatherTwentyOne.Models;

namespace WeatherTwentyOne.Services;

public interface IForecastService
{
    Task<List<Forecast>> GetWeekForecastsAsync(DateTime date);
    Task<List<Forecast>> GetDayForecastsAsync(DateTime dateTime);
}
