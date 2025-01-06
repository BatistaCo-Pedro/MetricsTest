namespace Services;

/// <summary>
/// DTO for weather forecast.
/// </summary>
/// <param name="Date">The data of the weather forecast.</param>
/// <param name="TemperatureC">The temperature in Celsius.</param>
/// <param name="Summary">The summary.</param>
public record WeatherForecastDto(DateOnly Date, int TemperatureC, string? Summary)
{
    /// <summary>
    /// The temperature in Fahrenheit.
    /// </summary>
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}