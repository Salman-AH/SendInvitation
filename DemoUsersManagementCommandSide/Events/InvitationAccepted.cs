namespace DemoUsersManagementCommandSide.Events
{
    public class InvitationAccepted: Event<object>
    {
        public InvitationAccepted(
            Guid aggregateId,
            int sequence,
            string userId,
            object data
        ) : base(aggregateId, sequence, data, userId)
        {
        }

    }
}
