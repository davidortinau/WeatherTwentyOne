namespace WeatherTwentyOne.Mvvm;

public class ViewModelMapper : IViewModelMapper
{
    private readonly Dictionary<Type, Type> _mapping = new();

    public void Register<TView, TViewModel>() 
        where TView : View
        where TViewModel : IViewModel
    {
        _mapping[typeof(TViewModel)] = typeof(TView);
    }

    public View ResolveView(IViewModel viewModel)
    {
        if (!_mapping.ContainsKey(viewModel.GetType()))
        {
            return null;
        }

        var viewType = _mapping[viewModel.GetType()];
        return (View)Activator.CreateInstance(viewType);
    }
}