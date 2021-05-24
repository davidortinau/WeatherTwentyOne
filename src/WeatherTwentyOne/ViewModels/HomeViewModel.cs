using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Maui;
using WeatherClient2021;
using WeatherTwentyOne.Models;

namespace WeatherTwentyOne.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private WeatherService weatherService;
        public List<FullDayForecast> Week {  get;set;}

        public ObservableCollection<WeatherSnapshot> Hours { get;set;}

        public WeatherSnapshot CurrentWeather {get;set;}

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
            var defaultLocation = config["DefaultLocation"];
            var locations = weatherService.GetLocations(defaultLocation).Result;
            var response = await weatherService.GetWeather(
                    locations.First().Coordinate
            );

            CurrentWeather = response.CurrentWeather;
            Hours = new ObservableCollection<WeatherSnapshot>(response.HourlyForecasts);

            OnPropertyChanged(nameof(CurrentWeather));
            OnPropertyChanged(nameof(Hours));
           
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
