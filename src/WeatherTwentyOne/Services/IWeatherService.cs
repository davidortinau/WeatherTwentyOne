namespace WeatherClient2021;

public interface IWeatherService
{
    Task<IEnumerable<Location>> GetLocationsAsync(string query);
    Task<WeatherResponse> GetWeatherAsync(Coordinate location);
}
