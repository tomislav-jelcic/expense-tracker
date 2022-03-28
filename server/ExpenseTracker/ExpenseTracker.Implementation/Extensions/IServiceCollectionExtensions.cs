using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Implementation.Definitions;
using MediatR;
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

    private static IServiceCollection AddHandlers(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        services.AddScoped<IDispatcher, Dispatcher>();
        return services;
    }

    public static IServiceCollection AddExpenseTrackerImplementation(this IServiceCollection services)
    {
        services.AddMapper();
        services.AddHandlers();
        return services;
    }
}
