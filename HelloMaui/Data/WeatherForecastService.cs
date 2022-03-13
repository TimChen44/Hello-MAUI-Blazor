using System.Net.Http.Json;

namespace HelloMaui.Data;

public class WeatherForecastService
{
	private readonly HttpClient HttpClient;

    public WeatherForecastService(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
	{
        return await HttpClient.GetFromJsonAsync<WeatherForecast[]>($"weatherforecast?startDate={startDate}");

    }
}

