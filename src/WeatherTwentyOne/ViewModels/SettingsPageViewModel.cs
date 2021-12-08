namespace WeatherTwentyOne.ViewModels;

public class SettingsPageViewModel : PageViewModel
{
    public SettingsPageViewModel()
    {
        SelectUnits = new Command<string>(OnSelectUnits);
    }

    private string units = "imperial";
    public string Units 
    {
        get => units;
        set 
        {
            SetProperty(ref units, value);
            RaisePropertyChanged(nameof(IsImperial));
            RaisePropertyChanged(nameof(IsMetric));
            RaisePropertyChanged(nameof(IsHybrid));
            RaisePropertyChanged(nameof(Temperature));
        }
    }

    public string Temperature => IsImperial ? "70˚F" : "21˚C";

    public bool IsImperial => units == "imperial";

    public bool IsMetric => units == "metric";

    public bool IsHybrid => units == "hybrid";

    public Command SelectUnits { get; set; }    

    private void OnSelectUnits(string unit)
    {
        Units = unit;
    }
}
