namespace AT.DynamicAssessment.Application.Model.Aether;
/// <summary>
/// Assessment class use for declare Assessment related property
/// </summary>
public class Content
{
    public string? ContentId { get; set; }
    public string? Comment { get; set; }
    public int? Id { get; set; }
    public string? Title { get; set; }
    public List<QuestionItem> questionItems { get; set; } = new List<QuestionItem>();
}
