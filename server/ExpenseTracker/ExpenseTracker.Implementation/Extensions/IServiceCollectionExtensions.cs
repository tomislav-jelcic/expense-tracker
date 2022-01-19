using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ExpenseTracker.Implementation.Extensions;

public static class IServiceCollectionExtensions
{
    /// <summary>
    /// Adds mapper for mapping objects
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        return services;
    }

    public static IServiceCollection AddExpenseTrackerApplication(this IServiceCollection service)
    {

        return service;
    }
}
