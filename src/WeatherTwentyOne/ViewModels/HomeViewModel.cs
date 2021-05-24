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
            //weatherService = new WeatherService(new HttpClient());

            InitData();
        }

        private void InitData()
        {
            var config = (IConfiguration)App.Services.GetService(typeof(IConfiguration));
            var defaultLocation = config["DefaultLocation"];
            var locations = weatherService.GetLocations(defaultLocation).Result;
            weatherService.GetWeather(
                    locations.First().Coordinate
            );

           
        }
    }
}
