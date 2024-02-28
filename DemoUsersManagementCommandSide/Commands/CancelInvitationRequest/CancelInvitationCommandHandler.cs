using DemoUsersManagementCommandSide.Abstraction;
using DemoUsersManagementCommandSide.Domain;
using DemoUsersManagementCommandSide.Exceptions;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DemoUsersManagementCommandSide.Commands.CancelInvitationRequest
{
    public class CancelInvitationCommandHandler(IEventStore eventStore) : IRequestHandler<CancelInvitationCommand, Guid>
    {
        private readonly IEventStore _eventStore = eventStore;

        public async Task<Guid> Handle(CancelInvitationCommand command, CancellationToken cancellationToken)
        {
            var events = await _eventStore.GetStreamAsync(command.Id);

            if (events.Count == 0)
                throw new NotFoundException();

            var invitation = InvitationMember.LoadFromHistory(events);

            invitation.Canseled(command);

            await _eventStore.AppendToStreamAsync(invitation);

            return invitation.Id;

        }


    }
}
