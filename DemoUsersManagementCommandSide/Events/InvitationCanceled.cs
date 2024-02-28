using DemoUsersManagementCommandSide.Events.DataType;

namespace DemoUsersManagementCommandSide.Events
{
    public class InvitationCanceled : Event<object>
    {
        public InvitationCanceled(
            Guid aggregateId,
            int sequence,
            string userId,
            object data
        ) : base(aggregateId, sequence, data, userId)
        {
        }

        
    }
}
