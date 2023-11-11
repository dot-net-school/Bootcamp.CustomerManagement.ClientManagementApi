
using ClientManagementApi.Application.Common.Interfaces;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;



namespace ClientManagementApi.Application;

public static class ConfigureServices
{
    public static IServiceCollection RegisterApplicationServices(this IServiceCollection services)
    {
       // services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AnotherValidationClass>());

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
        }
        );

        return services;
    }
}

