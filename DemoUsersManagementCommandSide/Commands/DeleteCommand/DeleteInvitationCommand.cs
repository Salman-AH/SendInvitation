using DemoUsersManagementCommandSide.Abstraction;
using MediatR;

namespace DemoUsersManagementCommandSide.Commands.DeleteCommand
{
    public record DeleteInvitationCommand(
       Guid Id,       
       string UserId

   ) : IRequest<Guid>, IMemberInvitation;
}
