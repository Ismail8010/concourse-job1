using Amazon.DynamoDBv2;
using Amazon.Runtime;
using AT.DynamicAssessment.Application.Contracts.Persistence;
using AT.DynamicAssessment.Persistence.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace AT.DynamicAssessment.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IAmazonDynamoDB>(s =>
        {
            var credentials = new BasicAWSCredentials("test", "test");
            var config = new AmazonDynamoDBConfig()
            {
                ServiceURL = "http://localhost:4566",//use http://localhost:8001 to access the created DynamoDB
            };
            return new AmazonDynamoDBClient(credentials, config);

        });

        services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

        services.AddScoped<IAssessmentRepository, AssessmentRepository>();
        services.AddScoped<IAssessmentTemplateRepository, AssessmentTemplateRepository>();
        services.AddScoped<IAssessmentMockDBRepository, AssessmentMockDBRepository>();
        return services;
    }
}