using DemoUsersManagementCommandSide.Domain;
using DemoUsersManagementCommandSide.Events;

namespace DemoUsersManagementCommandSide.Abstraction
{
    public interface IEventStore
    {
        Task AppendToStreamAsync(IAggregate aggregate);
        Task AppendToStreamAsync(Event @event);
        Task<List<Event>> GetStreamAsync(Guid aggregateId);
        Task<List<Event>> GetStreamAsync(string aggregateId);

    }
}
