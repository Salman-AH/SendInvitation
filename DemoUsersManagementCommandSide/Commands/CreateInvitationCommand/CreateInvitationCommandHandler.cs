using DemoUsersManagementCommandSide.Abstraction;
using DemoUsersManagementCommandSide.Commands.SendInvitaionRequest;
using DemoUsersManagementCommandSide.Domain;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DemoUsersManagementCommandSide.Commands.CreateInvitationCommand
{
    public class CreateInvitationCommandHandler(IEventStore eventStore) : IRequestHandler<CreateInvitationCommand, Guid>
    {
        private readonly IEventStore _eventStore = eventStore;
        public async Task<Guid> Handle(CreateInvitationCommand command, CancellationToken cancellationToken)
        {
            var invitation = InvitationMember.Create(command);
            await _eventStore.AppendToStreamAsync(invitation);
            return invitation.Id;
        }
    }
}
