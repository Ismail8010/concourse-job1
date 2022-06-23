using MediatR;

namespace AT.DynamicAssessment.Application.Features.AssessmentTamplates.Commands.CreateAssessmentTemplate;
public class CreateAssessmentTemplateCommand : IRequest<CreateAssessmentTemplateCommandResponse>
{
    public string? AssessmentTamplate { get; set; }
    public string? Name { get; set; }
    public long Version { get; set; }
    public string? Description { get; set; }
}