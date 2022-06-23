using AT.DynamicAssessment.Application.Model.Aether;

namespace AT.DynamicAssessment.Application.Contracts.Infrastructure;

public interface IAetherServicee<T> where T : class
{
    Task<List<Content>> GetQuestionItemsByContent();
}
