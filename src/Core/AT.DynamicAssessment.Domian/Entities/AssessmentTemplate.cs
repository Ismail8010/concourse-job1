using AT.DynamicAssessment.Domian.Common;

namespace AT.DynamicAssessment.Domian.Entities;
public class AssessmentTemplate : AuditableEntity
{
    public string? AssessmentTamplate { get; set; }
    public string? Name { get; set; }
    public long Version { get; set; }
    public string? Description { get; set; }
}