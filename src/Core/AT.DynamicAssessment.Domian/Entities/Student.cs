using AT.DynamicAssessment.Domian.Common;

namespace AT.DynamicAssessment.Domian.Entities;
public class Student : AuditableEntity
{
    public Guid StudentId { get; set; }
}