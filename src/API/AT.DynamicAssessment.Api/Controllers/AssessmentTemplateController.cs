using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AT.DynamicAssessment.Application.Features.AssessmentTamplates.Queries.GetAssessmentTemplateList;
using AT.DynamicAssessment.Application.Features.AssessmentTamplates.Commands.CreateAssessmentTemplate;

namespace AT.DynamicAssessment.Api.Controllers;

[ApiController]
[ApiVersion("1")]
[Route("v{version:apiVersion}/[controller]")]
[Produces("application/json")]
[AllowAnonymous]
public class AssessmentTemplateController : ControllerBase
{
    private readonly IMediator _mediator;

    public AssessmentTemplateController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("all", Name = "GetAllAssessmentTemplates")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<AssessmentTemplateListVm>>> GetAllAssessmentTemplates()
    {
        var asessmentTemplates = await _mediator.Send(new GetAssessmentTemplatesListQuery());
        return Ok(asessmentTemplates);
    }

    [HttpPost(Name = "AddAssessmentTemplate")]
    public async Task<ActionResult<CreateAssessmentTemplateCommandResponse>> Create([FromBody] CreateAssessmentTemplateCommand createAssessmentTemplateCommand)
    {
        var response = await _mediator.Send(createAssessmentTemplateCommand);
        return Ok(response);
    }
}