using Microsoft.Extensions.DependencyInjection;
using AT.DynamicAssessment.Application.Contracts.Infrastructure;
using Model = AT.DynamicAssessment.Application.Model.Event;
using AT.DynamicAssessment.Infrastructure.Event;
namespace AT.DynamicAssessment.Infrastructure;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddTransient<IEventService<Model.Event>, StartEventService>();

        return services;
    }
}
