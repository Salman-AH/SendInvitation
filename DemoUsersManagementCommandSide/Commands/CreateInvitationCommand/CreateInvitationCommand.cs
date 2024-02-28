using DemoUsersManagementCommandSide.Abstraction;
using MediatR;

namespace DemoUsersManagementCommandSide.Commands.CreateInvitationCommand
{
    public class CreateInvitationCommand : IRequest<Guid>, IMemberInvitation
    {
        public Guid Id { get; init; }
        public required string AccountId { get; init; }
        public required string SubscriptionId { get; init; }
        public required string MemberId { get; init; }
        public required string UserId { get; init; }
        public required List<Permission> Permissions { get; init; }
    }
}
