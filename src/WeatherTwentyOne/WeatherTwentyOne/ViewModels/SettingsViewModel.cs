using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using WeatherTwentyOne.Models.WeatherTwentyOne.Models;
using Xamarin.Forms;

namespace WeatherTwentyOne.ViewModels
{
    public class SettingsViewModel : INotifyPropertyChanged
    {
        private string units = "imperial";

        public string Units
        {
            get => units;
            set
            {
                units = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsImperial));
                OnPropertyChanged(nameof(IsMetric));
                OnPropertyChanged(nameof(IsHybrid));
                OnPropertyChanged(nameof(Temperature));
            }
        }

        public string Temperature
        {
            get
            {
                if(IsImperial)
                {
                    return "70˚F";
                }
                else
                {
                    return "21˚C";
                }
            }
        }


        public bool IsImperial
        {
            get {
                return units == "imperial";
            }
        }
        public bool IsMetric
        {
            get
            {
                return units == "metric";
            }
        }

        public bool IsHybrid
        {
            get
            {
                return units == "hybrid";
            }
        }

        public Command SelectUnits { get; set; }

        public SettingsViewModel()
        {
            SelectUnits = new Command<string>(OnSelectUnits);
        }

        private void OnSelectUnits(string unit)
        {
            Units = unit;
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
