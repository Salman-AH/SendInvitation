using DemoUsersManagementCommandSide.Abstraction;
using DemoUsersManagementCommandSide.Commands.SendInvitaionRequest;
using DemoUsersManagementCommandSide.Domain;
using DemoUsersManagementCommandSide.Exceptions;
using MediatR;

namespace DemoUsersManagementCommandSide.Commands.AcceptInvitation
{
    public class AcceptInvitationCommandHandler(IEventStore eventStore) : IRequestHandler<AcceptInvitationCommand, Guid>
    {
        private readonly IEventStore _eventStore = eventStore;

        public async Task<Guid> Handle(AcceptInvitationCommand command, CancellationToken cancellationToken)
        {
            var events = await _eventStore.GetStreamAsync(command.Id);

            if (events.Count == 0)
                throw new NotFoundException();

            var invitation = InvitationMember.LoadFromHistory(events);

            invitation.Accept(command);

            await _eventStore.AppendToStreamAsync(invitation);

            return invitation.Id;

        }
    }
}
