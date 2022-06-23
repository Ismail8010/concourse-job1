using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Microsoft.AspNetCore.Authorization;
using AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;

namespace AT.DynamicAssessment.Api.Controllers;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]")]
[Produces("application/json")]
[AllowAnonymous]
public class AssessmentController : ControllerBase
{
    private readonly IMediator _mediator;

    public AssessmentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// //<summary>
    /// This API use for Get Assessment Items
    /// </summary>
    /// <response code="200">request ok</response>
    /// <response code="400">Invalid json provided to endpoint</response>
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPost(Name = "getAssessmentItems")]
    public async Task<ActionResult<GetAssessmentItemsCommandResponse>> GetAssessmentItems([FromBody] GetAssessmentItemsCommand getAssessmentItemsCommand)
    {
        var response = await _mediator.Send(getAssessmentItemsCommand);
       
        return Ok(response);
    }
}
