using MediatR;

namespace AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;
/// <summary>
///This GetAssessmentItemsCommand is use for Request of Asessment API data
/// </summary>

public class GetAssessmentItemsCommand : IRequest<GetAssessmentItemsCommandResponse>
{
    public string? AssessmentId { get; set; }
    public string? CtkTakeId { get; set; }
    public StudentInformationDto? StudentInformation { get; set; }
    public string? AssessmentTemplate { get; set; }

    public List<string> AssessmentContainers { get; set; } = new List<string>();

    public DeliveryConfigurationDto? DeliveryConfiguration { get; set; }

    public ProductInformationDto? ProductInformation { get; set; }
}

