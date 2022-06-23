using AT.DynamicAssessment.Application.Responses;

namespace AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;
/// <summary>
/// This GetAssessmentItemsCommandResponse is use for declare return response data 
/// </summary>

public class GetAssessmentItemsCommandResponse : BaseResponse
{
    
    public GetAssessmentItemsCommandResponse() : base()
    {

    }
    
    public AssessmentDto? Assessment { get; set; }
}
