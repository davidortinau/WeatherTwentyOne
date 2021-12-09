namespace WeatherTwentyOne.Mvvm;
  
public class ViewModelPresenter : ContentView
{
    public static readonly BindableProperty ViewModelProperty =
        BindableProperty.Create("ViewModel", typeof(IViewModel), typeof(ViewModelPresenter), propertyChanged: OnViewModelChanged);

    public IViewModel ViewModel 
    {
        get { return (IViewModel)GetValue(ViewModelProperty); }
        set { SetValue(ViewModelProperty, value); }
    }

    static void OnViewModelChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var contentControl = (ViewModelPresenter)bindable;
        contentControl.RefreshContentPresenter();
    }

    private void RefreshContentPresenter()
    {
        if (ViewModel == null)
        {
            Content = null;

            return;
        }

        var viewModelMapper = ServiceLocator.GetService<IViewModelMapper>();
        var view = viewModelMapper.ResolveView(ViewModel);

        if (view != null)
        {
            view.BindingContext = ViewModel;
            Content = view;
        }        
    }
}
