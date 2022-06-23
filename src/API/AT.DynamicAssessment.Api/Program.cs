using Prometheus;
using System.Reflection;
using AT.DynamicAssessment.Persistence;
using AT.DynamicAssessment.Application;
using AT.DynamicAssessment.Infrastructure;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Think 'ConfigureServices'
builder.Services.AddControllers();

builder.Services.AddApiVersioning(o =>
            {
                o.ReportApiVersions = true;
                o.ApiVersionReader = new HeaderApiVersionReader("api-version");
                o.DefaultApiVersion = new ApiVersion(1, 0);
                o.AssumeDefaultVersionWhenUnspecified = true;
            });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options => {
                var basePath = AppContext.BaseDirectory;
                var assemblyName = Assembly.GetEntryAssembly().GetName().Name;
                var fileName = System.IO.Path.GetFileName(assemblyName + ".xml");
               //Set the comments path for the swagger json and ui.
                options.IncludeXmlComments(System.IO.Path.Combine(basePath, fileName));
             });
builder.Services.AddHealthChecks().ForwardToPrometheus();
builder.Services.Configure<AT.DynamicAssessment.Api.Config.Configuration>(builder.Configuration);

builder.Services.AddApplicationServices();
builder.Services.AddPersistenceServices();
builder.Services.AddInfrastructureServices();

// Think 'Configure' 
var app = builder.Build();
app.UseRouting();
app.UseHttpMetrics();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// configure endpoints
app.UseEndpoints(endpoints =>
{
    endpoints.MapHealthChecks("/health");
    endpoints.MapControllers();
    endpoints.MapMetrics();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
