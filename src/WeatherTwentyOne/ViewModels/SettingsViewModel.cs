using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WeatherTwentyOne.ViewModels;

public class SettingsViewModel : INotifyPropertyChanged
{
    private string units = "imperial";

    public string Units {
        get => units;
        set {
            units = value;
            OnPropertyChanged();
            OnPropertyChanged(nameof(IsImperial));
            OnPropertyChanged(nameof(IsMetric));
            OnPropertyChanged(nameof(IsHybrid));
            OnPropertyChanged(nameof(Temperature));
        }
    }

    public bool IsDarkMode {
        get {
            return App.Current.UserAppTheme == OSAppTheme.Dark;
        }
        set {
            App.Current.UserAppTheme = value ? OSAppTheme.Dark : OSAppTheme.Light;
            OnPropertyChanged();
        }
    }

    public string Temperature => IsImperial ? "70˚F" : "21˚C";

    public bool IsImperial => units == "imperial";

    public bool IsMetric => units == "metric";

    public bool IsHybrid => units == "hybrid";

    public Command SelectUnits { get; set; }

    public Command ChangeThemeMode { get; set; }

    public SettingsViewModel()
    {
        SelectUnits = new Command<string>(OnSelectUnits);
        ChangeThemeMode = new Command<bool>(OnChangeThemeMode);


    }

    private void OnChangeThemeMode(bool dark)
    {
        App.Current.UserAppTheme = dark ? OSAppTheme.Dark : OSAppTheme.Light;
        OnPropertyChanged(nameof(IsDarkMode));
    }

    private void OnSelectUnits(string unit)
    {
        Units = unit;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
