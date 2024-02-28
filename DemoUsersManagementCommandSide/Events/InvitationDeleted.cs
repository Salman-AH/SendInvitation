namespace DemoUsersManagementCommandSide.Events
{
    public class InvitationDeleted : Event<object>
    {
        public InvitationDeleted(
            Guid aggregateId,
            int sequence,
            string userId,
            object data
        ) : base(aggregateId, sequence, data, userId)
        {
        }
    }
}
