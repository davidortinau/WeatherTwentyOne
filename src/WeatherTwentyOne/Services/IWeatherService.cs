using System.Collections.Generic;
using System.Threading.Tasks;
using WeatherTwentyOne.Models;

namespace WeatherClient2021
{
    public interface IWeatherService
    {
        Task<IEnumerable<Location>> GetLocations(string query);
        Task<WeatherResponse> GetWeather(Coordinate location);
    }
}