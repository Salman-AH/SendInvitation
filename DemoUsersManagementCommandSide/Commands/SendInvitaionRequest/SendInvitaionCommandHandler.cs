using DemoUsersManagementCommandSide.Abstraction;
using DemoUsersManagementCommandSide.Domain;
using DemoUsersManagementCommandSide.Exceptions;
using MediatR;

namespace DemoUsersManagementCommandSide.Commands.SendInvitaionRequest
{
    public class SendInvitaionCommandHandler(IEventStore eventStore): IRequestHandler<SendInvitaionCommand, Guid>
    {
        private readonly IEventStore _eventStore = eventStore;

        public async Task<Guid> Handle(SendInvitaionCommand command, CancellationToken cancellationToken)
        {
            var events = await _eventStore.GetStreamAsync(command.Id);

            if (events.Count == 0)
                throw new NotFoundException();


            var invitation = InvitationMember.LoadFromHistory(events);

            invitation.Send(command);

            await _eventStore.AppendToStreamAsync(invitation);

            return invitation.Id;
        }
        
    }
}
