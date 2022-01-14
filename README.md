# Weather '21

This is a [.NET MAUI](https://github.com/dotnet/maui) app showcasing .NET 6 Preview progress. For more information about what's included, read the blogs: 

* [.NET MAUI Preview 7](https://devblogs.microsoft.com/dotnet/announcing-net-maui-preview-7)
* [.NET MAUI Preview 6](https://devblogs.microsoft.com/dotnet/announcing-net-maui-preview-6)
* [.NET MAUI Preview 5](https://devblogs.microsoft.com/dotnet/announcing-net-maui-preview-5)
* [.NET MAUI Preview 4](https://devblogs.microsoft.com/dotnet/announcing-net-maui-preview-4)


![.NET MAUI Weather App on all platforms](images/maui-weather-hero-sm.png)

## Requirements

To run this app, you'll need:

* .NET 6 Preview 
    * .NET MAUI and platform SDKs
* Visual Studio 16.11 Preview 2

The easiest way to get .NET 6 Preview is to install the `maui-check` dotnet tool from CLI and follow the instructions.

Install: 
```console
dotnet tool install -g redth.net.maui.check
```

Run: 
```console
maui-check
```

For running on Mac you'll currently use your favorite text editor and terminal to edit and run apps. We expect Visual Studio for Mac .NET 6 support to begin arriving mid-year.

## Platform Integrations

To demonstrate how easily you can enable platform-native integrations, we added a handful of features:

* App Actions - Microsoft.Maui.Essentials provides a simple API to add shortcuts you access from the app icon
* System Tray - added the .NET bot to the tray on Windows and status bar on macOS
* Notifications - trigger a notification when clicking the bot

![gallery of platform images](images/platform-integrations.png)

## Single Project

The WeatherTwentyOne project is a multi-targeted SDK project that can run on Android, iOS, and macOS. To choose your platform to run on, use the new static run profiles from the run button.

![run menu](images/run-static-profiles.png)

## Additional Resources

https://github.com/dotnet/maui-samples

https://github.com/dotnet/maui
