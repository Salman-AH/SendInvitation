using DemoUsersManagementCommandSide.Abstraction;
using DemoUsersManagementCommandSide.Commands.RejectInvitation;
using DemoUsersManagementCommandSide.Domain;
using DemoUsersManagementCommandSide.Exceptions;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DemoUsersManagementCommandSide.Commands.DeleteCommand
{
    public class DeleteInvitationCommandHandler(IEventStore eventStore) : IRequestHandler<DeleteInvitationCommand, Guid>
    {
        private readonly IEventStore _eventStore = eventStore;

        public async Task<Guid> Handle(DeleteInvitationCommand command, CancellationToken cancellationToken)
        {

            var events = await _eventStore.GetStreamAsync(command.Id);

            if (events.Count == 0)
                throw new NotFoundException();

            var invitation = InvitationMember.LoadFromHistory(events);

            invitation.Delete(command);

            await _eventStore.AppendToStreamAsync(invitation);

            return invitation.Id;
        }
    }
}
