using Microsoft.AspNetCore.Components.WebView.Maui;
using HelloMaui.Data;

namespace HelloMaui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .RegisterBlazorMauiWebView()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddBlazorWebView();
        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddScoped<HttpClient>(x => new HttpClient() { BaseAddress= new Uri("http://localhost:5045/") });

        return builder.Build();
    }
}
