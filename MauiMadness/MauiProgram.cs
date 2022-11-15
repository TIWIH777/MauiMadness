using Microsoft.AspNetCore.Components.WebView.Maui;
using MauiMadness.Services;
using MauiMadness.Services.ConditionalCompilation;

namespace MauiMadness;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();
#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif

		builder.Services.AddSingleton<WeatherForecastService>();

		builder.Services.AddSingleton<DeviceOrientationService>();


		return builder.Build();
	}
}
