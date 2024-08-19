using System.Reflection;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Tree.Application;

public static class Startup
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        return services
            .AddValidatorsFromAssembly(assembly);
    }
}