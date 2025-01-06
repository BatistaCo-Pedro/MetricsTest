namespace Services;

/// <summary>
/// Dependency injection class for services.
/// </summary>
public static class ServicesDependencyInjection
{
    /// <summary>
    /// Adds the services from the Services project.
    /// </summary>
    /// <param name="serviceCollection">The <see cref="IServiceCollection"/> to extend.</param>
    /// <returns>The <paramref name="serviceCollection"/>.</returns>
    public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IWeatherService, WeatherService>();
        
        return serviceCollection;
    }
}