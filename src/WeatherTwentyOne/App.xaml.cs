using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using MonkeyCache.FileStore;
using WeatherTwentyOne.Pages;

namespace WeatherTwentyOne
{
	public partial class App : Microsoft.Maui.Controls.Application
    {
        public static IServiceProvider Services { get; private set; }

		public App(IServiceProvider services)
		{
            Services = services;
            Barrel.ApplicationId = "WeatherTwentryOne";
            InitializeComponent();
		}

		protected override IWindow CreateWindow(IActivationState activationState)
		{
			Microsoft.Maui.Controls.Compatibility.Forms.Init(activationState);

			this.On<Microsoft.Maui.Controls.PlatformConfiguration.Windows>()
				.SetImageDirectory("Assets");

			return new Microsoft.Maui.Controls.Window(
				new NavigationPage(
					new HomePage()
				)
			);
		}
	}
}