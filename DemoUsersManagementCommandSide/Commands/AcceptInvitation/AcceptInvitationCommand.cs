using DemoUsersManagementCommandSide.Abstraction;
using MediatR;

namespace DemoUsersManagementCommandSide.Commands.AcceptInvitation
{
    public record AcceptInvitationCommand(
        Guid Id,
        string AccountId,
        string SubscriptionId,
        string MemberId,
        string UserId

    ) : IRequest<Guid>, IMemberInvitation;
}
