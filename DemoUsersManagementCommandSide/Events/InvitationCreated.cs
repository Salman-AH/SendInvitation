using DemoUsersManagementCommandSide.Events.DataType;

namespace DemoUsersManagementCommandSide.Events
{
    public class InvitationCreated: Event<InvitationCreatedData>
    {
        public InvitationCreated(
            Guid aggregateId,
            int sequence,
            string userId,
            InvitationCreatedData data
        ) : base(aggregateId, sequence, data, userId)
        {
        }

    }
}
