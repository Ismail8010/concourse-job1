using AT.DynamicAssessment.Application.Responses;

namespace AT.DynamicAssessment.Application.Features.AssessmentTamplates.Commands.CreateAssessmentTemplate;
public class CreateAssessmentTemplateCommandResponse : BaseResponse
{
    public CreateAssessmentTemplateCommandResponse() : base()
    {

    }
    public AssessmentTemplateDto? AssessmentTemplate { get; set; }

}