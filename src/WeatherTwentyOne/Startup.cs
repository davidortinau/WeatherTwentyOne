using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Hosting;

namespace WeatherTwentyOne
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseFormsCompatibility()
				.UseMauiApp<App>()
				.UseMauiControlsHandlers()
				.ConfigureFonts((fonts)=>{
					fonts.AddFont("fa-solid-900.ttf", "FontAwesome");
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
					fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
				});
				
		}
	}
}