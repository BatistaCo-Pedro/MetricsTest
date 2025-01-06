namespace Services;

/// <summary>
/// The interface for weather services.
/// </summary>
public interface IWeatherService
{
    /// <summary>
    /// Returns a list of weather forecast with random data.
    /// </summary>
    /// <returns>A <see cref="WeatherForecastDto"/> array.</returns>
    WeatherForecastDto[] GetForecast();
}

/// <inheritdoc /> 
public class WeatherService : IWeatherService
{
    private static readonly  string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    /// <inheritdoc /> 
    public WeatherForecastDto[] GetForecast()
    {
        var forecast = Enumerable.Range(1, 5).Select(index =>
                new WeatherForecastDto
                (
                    DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                    Random.Shared.Next(-20, 55),
                    Summaries[Random.Shared.Next(Summaries.Length)]
                ))
            .ToArray();
        
        Log.Information("Caller2 is logging something, miracle!!");
        
        return forecast;
    }
}