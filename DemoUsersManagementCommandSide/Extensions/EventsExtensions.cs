using DemoUsersManagementCommandSide.Commands.AcceptInvitation;
using DemoUsersManagementCommandSide.Commands.CancelInvitationRequest;
using DemoUsersManagementCommandSide.Commands.CreateInvitationCommand;
using DemoUsersManagementCommandSide.Commands.DeleteCommand;
using DemoUsersManagementCommandSide.Commands.RejectInvitation;
using DemoUsersManagementCommandSide.Commands.SendInvitaionRequest;
using DemoUsersManagementCommandSide.Domain;
using DemoUsersManagementCommandSide.Events;
using DemoUsersManagementCommandSide.Events.DataType;

namespace DemoUsersManagementCommandSide.Extensions
{
    public static class EventsExtensions
    {
        public static InvitationCreated ToEvent(this CreateInvitationCommand command) => new(
                aggregateId: Guid.NewGuid(),
                sequence: 1,               
                data: new InvitationCreatedData(
                    AccountId: command.AccountId,
                    SubscriptionId: command.SubscriptionId,
                    MemberId: command.MemberId,
                    UserId: command.UserId,                    
                    Permission: command.Permissions.FirstOrDefault()
                ),
                userId: command.UserId                
            );


        public static InvitationSent ToEvent(this SendInvitaionCommand command, int sequence)
            => new(
                aggregateId: command.Id,
                sequence: sequence,
                userId: command.UserId,
                data: new object()
            );


        public static InvitationCanceled ToEvent(this CancelInvitationCommand command, int sequence)
            => new(
                aggregateId: command.Id,
                sequence: sequence,
                userId: command.UserId,
                data: new object()
            );
        public static InvitationAccepted ToEvent(this AcceptInvitationCommand command, int sequence)
           => new(
               aggregateId: command.Id,
               sequence: sequence,
               userId: command.UserId,
               data: new object()
           );

        public static InvitationRejected ToEvent(this RejectInvitationCommand command, int sequence)
           => new(
               aggregateId: command.Id,
               sequence: sequence,
               userId: command.UserId,
               data: new object()
           );

        public static InvitationDeleted ToEvent(this DeleteInvitationCommand command, int sequence)
            => new(
                aggregateId: command.Id,
                sequence: sequence,
                userId: command.UserId,
                data: new object()
            );


    }
}
