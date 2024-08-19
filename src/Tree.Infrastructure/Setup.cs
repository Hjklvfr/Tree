using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Tree.Infrastructure.Common;
using Tree.Infrastructure.Mapping;
using Tree.Infrastructure.Middleware;
using Tree.Infrastructure.OpenApi;
using Tree.Infrastructure.ParameterTransformers;
using Tree.Infrastructure.Persistence;

namespace Tree.Infrastructure;

public static class Setup
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        var applicationAssembly = typeof(Application.Startup).GetTypeInfo().Assembly;
        MapsterSettings.Configure();
        return services
            .AddExceptionMiddleware()
            .AddOpenApiDocumentation()
            .AddPersistence()
            .AddRouting(options => options.LowercaseUrls = true)
            .AddServices();
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder builder) =>
        builder
            .UseRequestLocalization()
            .UseStaticFiles()
            .UseExceptionMiddleware()
            .UseRouting()
            .UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "api.user.{controller}.{action}");
                endpoints.MapDynamicControllerRoute<ApplicationRouteTransformer>("api.user.[controller].[action]");
            })
            .UseOpenApiDocumentation();

    public static IEndpointRouteBuilder MapEndpoints(this IEndpointRouteBuilder builder)
    {
        builder.MapControllers();
        return builder;
    }
}