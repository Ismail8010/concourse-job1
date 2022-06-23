namespace AT.DynamicAssessment.Application.Contracts.Infrastructure;

public interface IEventService<T> where T : class
{
    Task<bool> Send(T requestEvent);
}