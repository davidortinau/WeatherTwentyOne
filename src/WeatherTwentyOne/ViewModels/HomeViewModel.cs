using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Maui;
using WeatherClient2021;
using WeatherTwentyOne.Models;

namespace WeatherTwentyOne.ViewModels
{
    public class HomeViewModel
    {
        private WeatherService weatherService;
        public List<FullDayForecast> Week {  get;set;}

        public List<WeatherSnapshot> Hours { get;set;}

        public HomeViewModel()
        {
            weatherService = new WeatherService(new System.Net.Http.HttpClient 
            {
                BaseAddress = new Uri("https://minimalweather20210428173256.azurewebsites.net/weather")
            });

            InitData();
        }

        private async void InitData()
        {
            var config = (IConfiguration)App.Services.GetService(typeof(IConfiguration));
            var defaultLocation = "NYC";
            var locations = weatherService.GetLocations(defaultLocation).Result;
            WeatherResponse response = await weatherService.GetWeather(
                    locations.First().Coordinate
            );
            Console.WriteLine(response);
            Week = new List<FullDayForecast>(response.DailyForecasts);
            Hours = new List<WeatherSnapshot>(response.HourlyForecasts);

           
        }
    }
}
