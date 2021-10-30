using Hardcodet.Wpf.TaskbarNotification.Interop;
using Microsoft.Maui;
using Microsoft.UI.Xaml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherTwentyOne.Services;

namespace WeatherTwentyOne.WinUI
{
	public class TrayService : ITrayService
	{
		WindowsTrayIcon tray;

		public Action ClickHandler { get; set; }

		public void Initialize()
		{
			tray = new WindowsTrayIcon("Platforms/Windows/trayicon.ico");
			tray.LeftClick = () =>
			{
                var winuiApp = (Window)MauiWinUIApplication.Current.Application.Windows[0].Handler!.NativeView!;
                winuiApp.BringToFront();
                //Microsoft.Maui.MauiWinUIApplication.Current.Application.Windows[0].BringToFront();
				ClickHandler?.Invoke();
			};
		}
	}
}
