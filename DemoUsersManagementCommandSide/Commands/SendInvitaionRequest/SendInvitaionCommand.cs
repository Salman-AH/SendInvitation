using DemoUsersManagementCommandSide.Abstraction;
using DemoUsersManagementCommandSide.Domain;
using MediatR;

namespace DemoUsersManagementCommandSide.Commands.SendInvitaionRequest
{
    public class SendInvitaionCommand: IRequest<Guid>, IMemberInvitation
    {
        public SendInvitaionCommand(Guid Id, string UserId)
        {
            this.Id = Id;
            this.UserId = UserId;
        }

        public Guid Id { get; init; }       
        public string UserId { get; init; }       
        

    }
}
