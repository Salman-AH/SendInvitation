using DemoUsersManagementCommandSide.Abstraction;
using DemoUsersManagementCommandSide.Domain;
using MediatR;

namespace DemoUsersManagementCommandSide.Commands.CancelInvitationRequest
{
    public record CancelInvitationCommand 
    (
        
        Guid Id, 
        string AccountId,
        string SubscriptionId,
        string MemberId,
        string UserId

    ) : IRequest<Guid>, IMemberInvitation;
}
