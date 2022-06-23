using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Authorization;
using AT.DynamicAssessment.Api.Config;
namespace AT.DynamicAssessment.Api.Controllers;

[ApiController]
[ApiVersionNeutral]
[Produces("application/json")]
[Route("[controller]")]
[AllowAnonymous]
public class InfoController : ControllerBase
{
    private readonly string? _version;

    /// <summary>
    /// Endpoint to retrieve basic versioning info for this service.
    /// </summary>
    public InfoController(IOptions<Configuration> config)
    {
        _version = config.Value.TASK_VERSION;
    }

    /// <summary>
    /// Endpoint to retrieve basic versioning info for this service.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public object Info()
    {
        return new
        {
            Name = "Api.DynamicAssessment",
            Version = _version,
            ApiVersion = "v1.0"
        };
    }
}
