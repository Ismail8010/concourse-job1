
namespace AT.DynamicAssessment.Application.Features.Assessment.Commands.GetAssessmentItems;
/// <summary>
/// This DeliveryConfigurationDto use for declare Delivery Configuration Property
/// </summary>

public class DeliveryConfigurationDto
{
    public int? Attempt { get; set; }
    public int? PassingThreashold { get; set; }
    public int? TimeLimit { get; set; }
    public string? StudentReview { get; set; }
    public string? SaveAndExit { get; set; }
    public string? HideViewedQuestions { get; set; }
}
