using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using AT.DynamicAssessment.Application.Model.Event;
using AT.DynamicAssessment.Application.Features.AssessmentTable.Commands.CreateAssessmentTable;

namespace AT.DynamicAssessment.Api.Controllers
{
    [Route("[controller]")]
    public class AssessmentDBController : ControllerBase
    {
        private readonly ILogger<AssessmentDBController> _logger;
        private readonly IMediator _mediator;

        public AssessmentDBController(ILogger<AssessmentDBController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }
       [HttpPost(Name = "assessment-table")]
        public async Task<ActionResult<AssessmentInfoDto>> CreateDynamicAssessmentTable()
        {
           CreateAssessmentTableCommand createAssessmentTableCommand = new CreateAssessmentTableCommand();
           var response =   await _mediator.Send(createAssessmentTableCommand);

            return Ok();
        }
        
    }
}