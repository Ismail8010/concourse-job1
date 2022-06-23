using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace AT.DynamicAssessment.api.tests;
/// <summary>
/// The WebApplicationFactory is created by using the Program type from the Web API project
///  This factory can be used to create a TestServer
/// </summary>
internal class ApiWebApplicationFactory : WebApplicationFactory<Program>
{
    /// <summary>
    /// Inherit from WebApplicationFactory and override ConfigureWebHost. The IWebHostBuilder allows the configuration of the service collection with ConfigureAppConfiguration and ConfigureTestServices
    /// </summary>
    /// <param name="builder"></param>
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureAppConfiguration(config => { });
        builder.ConfigureTestServices(services => { });
    }
}
