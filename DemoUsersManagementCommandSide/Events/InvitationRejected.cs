namespace DemoUsersManagementCommandSide.Events
{
    public class InvitationRejected : Event<object>
    {
        public InvitationRejected(
            Guid aggregateId,
            int sequence,
            string userId,
            object data
        ) : base(aggregateId, sequence, data, userId)
        {
        }

    }
}
