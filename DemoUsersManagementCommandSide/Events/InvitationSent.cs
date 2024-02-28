using DemoUsersManagementCommandSide.Domain;
using DemoUsersManagementCommandSide.Events.DataType;

namespace DemoUsersManagementCommandSide.Events
{
    public class InvitationSent : Event<object>
    {
        public InvitationSent(
            Guid aggregateId,
            int sequence,
            string userId,
            object data
        ) : base(aggregateId, sequence, data, userId)
        {
        }
    }
}
