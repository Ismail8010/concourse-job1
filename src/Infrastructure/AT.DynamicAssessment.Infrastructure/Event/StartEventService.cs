using AT.DynamicAssessment.Application.Contracts.Infrastructure;
using Model = AT.DynamicAssessment.Application.Model.Event;

namespace AT.DynamicAssessment.Infrastructure.Event;
public class StartEventService : IEventService<Model.Event>
{


    public async Task<bool> Send(Model.Event requestEvent)
    {
        return true;
    }
}