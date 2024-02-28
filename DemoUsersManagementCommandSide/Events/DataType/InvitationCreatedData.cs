namespace DemoUsersManagementCommandSide.Events.DataType
{
    public record InvitationCreatedData
    (
        string AccountId,
        string SubscriptionId,
        string MemberId,
        string UserId,
        Permission Permission
    );
}
