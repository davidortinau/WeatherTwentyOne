using WeatherTwentyOne.Models;

namespace WeatherTwentyOne.Services;

public class ForecastService : IForecastService
{
    public Task<List<Forecast>> GetDayForecastsAsync(DateTime dateTime)
    {
        var result = new List<Forecast>
        {
            new Forecast
            {
                DateTime = dateTime.AddHours(1),
                Day = new Day{ Phrase = "fluent_weather_rain_showers_day_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 47 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(2),
                Day = new Day{ Phrase = "fluent_weather_rain_showers_day_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 47 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            }
            ,
            new Forecast
            {
                DateTime = dateTime.AddHours(3),
                Day = new Day{ Phrase = "fluent_weather_rain_showers_day_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 48 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            }
            ,
            new Forecast
            {
                DateTime = dateTime.AddHours(4),
                Day = new Day{ Phrase = "fluent_weather_rain_showers_day_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 49 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            }
            ,
            new Forecast
            {
                DateTime = dateTime.AddHours(5),
                Day = new Day{ Phrase = "fluent_weather_cloudy_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 52 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(6),
                Day = new Day{ Phrase = "fluent_weather_cloudy_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 53 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(7),
                Day = new Day{ Phrase = "fluent_weather_cloudy_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 58 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(8),
                Day = new Day{ Phrase = "fluent_weather_sunny_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 63 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(9),
                Day = new Day{ Phrase = "fluent_weather_sunny_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 64 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(10),
                Day = new Day{ Phrase = "fluent_weather_sunny_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 65 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(11),
                Day = new Day{ Phrase = "fluent_weather_sunny_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 68 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(12),
                Day = new Day{ Phrase = "fluent_weather_sunny_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 68 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(13),
                Day = new Day{ Phrase = "fluent_weather_sunny_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 68 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(14),
                Day = new Day{ Phrase = "fluent_weather_sunny_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 65 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(15),
                Day = new Day{ Phrase = "fluent_weather_sunny_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 63 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(16),
                Day = new Day{ Phrase = "fluent_weather_sunny_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 60 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(17),
                Day = new Day{ Phrase = "fluent_weather_moon_16_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 58 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(18),
                Day = new Day{ Phrase = "fluent_weather_moon_16_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 54 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(19),
                Day = new Day{ Phrase = "fluent_weather_moon_16_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 53 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(20),
                Day = new Day{ Phrase = "fluent_weather_moon_16_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 52 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(21),
                Day = new Day{ Phrase = "fluent_weather_moon_16_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 50 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(22),
                Day = new Day{ Phrase = "fluent_weather_moon_16_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 47 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = dateTime.AddHours(23),
                Day = new Day{ Phrase = "fluent_weather_moon_16_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 47 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            }
        };

        return Task.FromResult(result);
    }

    public Task<List<Forecast>> GetWeekForecastsAsync(DateTime date)
    {
        var result = new List<Forecast>
        {
            new Forecast
            {
                DateTime = date.AddDays(1),
                Day = new Day{ Phrase = "fluent_weather_sunny_high_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 52 }, Maximum = new Maximum { Unit = "F", Value = 77 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(2),
                Day = new Day{ Phrase = "fluent_weather_partly_cloudy" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 61 }, Maximum = new Maximum { Unit = "F", Value = 82 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(3),
                Day = new Day{ Phrase = "fluent_weather_rain_showers_day_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 62 }, Maximum = new Maximum { Unit = "F", Value = 77 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(4),
                Day = new Day{ Phrase = "fluent_weather_thunderstorm_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 57 }, Maximum = new Maximum { Unit = "F", Value = 80 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(5),
                Day = new Day{ Phrase = "fluent_weather_thunderstorm_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 49 }, Maximum = new Maximum { Unit = "F", Value = 61 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(6),
                Day = new Day{ Phrase = "fluent_weather_partly_cloudy" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 49 }, Maximum = new Maximum { Unit = "F", Value = 68 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(7),
                Day = new Day{ Phrase = "fluent_weather_rain_showers_day_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 47 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(1),
                Day = new Day{ Phrase = "fluent_weather_sunny_high_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 52 }, Maximum = new Maximum { Unit = "F", Value = 77 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(2),
                Day = new Day{ Phrase = "fluent_weather_partly_cloudy" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 61 }, Maximum = new Maximum { Unit = "F", Value = 82 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(3),
                Day = new Day{ Phrase = "fluent_weather_rain_showers_day_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 62 }, Maximum = new Maximum { Unit = "F", Value = 77 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(4),
                Day = new Day{ Phrase = "fluent_weather_thunderstorm_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 57 }, Maximum = new Maximum { Unit = "F", Value = 80 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(5),
                Day = new Day{ Phrase = "fluent_weather_thunderstorm_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 49 }, Maximum = new Maximum { Unit = "F", Value = 61 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(6),
                Day = new Day{ Phrase = "fluent_weather_partly_cloudy" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 49 }, Maximum = new Maximum { Unit = "F", Value = 68 } },
            },
            new Forecast
            {
                DateTime = date.AddDays(7),
                Day = new Day{ Phrase = "fluent_weather_rain_showers_day_20_filled" },
                Temperature = new Temperature{ Minimum = new Minimum{ Unit = "F", Value = 47 }, Maximum = new Maximum { Unit = "F", Value = 67 } },
            }
        };

        return Task.FromResult(result);
    }
}
