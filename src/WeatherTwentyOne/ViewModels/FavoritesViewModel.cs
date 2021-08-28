using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using WeatherClient2021;

namespace WeatherTwentyOne.ViewModels
{
    public class FavoritesViewModel : INotifyPropertyChanged
    {
        IWeatherService weatherService = new WeatherService(null);
        
        private ObservableCollection<WeatherClient2021.Location> favorites;
        public ObservableCollection<WeatherClient2021.Location> Favorites {
            get {
                return favorites;
            }

            set {
                favorites = value;
                OnPropertyChanged();
            }
        }

        async void Fetch()
        {
            var locations = await weatherService.GetLocations(string.Empty);
            
            UpdateFavorites(locations);

            OnPropertyChanged(nameof(Favorites));

        }

        private void UpdateFavorites(IEnumerable<WeatherClient2021.Location> locations)
        {
            favorites = new ObservableCollection<WeatherClient2021.Location>();
            for (int i = locations.Count() - 1; i >= 0; i--)
            {
                favorites.Add(locations.ElementAt(i));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public FavoritesViewModel()
        {
            Fetch();
        }
    }
}
