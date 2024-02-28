using DemoUsersManagementCommandSide.Abstraction;
using MediatR;

namespace DemoUsersManagementCommandSide.Commands.RejectInvitation
{
    public record RejectInvitationCommand(
        Guid Id,
        string AccountId,
        string SubscriptionId,
        string MemberId,
        string UserId

    ) : IRequest<Guid>, IMemberInvitation;
}
