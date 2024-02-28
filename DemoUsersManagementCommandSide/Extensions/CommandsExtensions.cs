using DemoUsersManagementCommandSide.Commands.AcceptInvitation;
using DemoUsersManagementCommandSide.Commands.CancelInvitationRequest;
using DemoUsersManagementCommandSide.Commands.CreateInvitationCommand;
using DemoUsersManagementCommandSide.Commands.DeleteCommand;
using DemoUsersManagementCommandSide.Commands.RejectInvitation;
using DemoUsersManagementCommandSide.Commands.SendInvitaionRequest;
using DemoUsersManagementCommandSide.Domain;
using Microsoft.AspNetCore.Identity.Data;

namespace DemoUsersManagementCommandSide.Extensions
{
    public static class CommandsExtensions
    {
        public static CreateInvitationCommand ToCreateCommand(this CreateInvitationRequest request)
            => new()
            {
               AccountId = request.AccountId,
               SubscriptionId = request.SubscriptionId,
               MemberId = request.MemberId,
               UserId = request.UserId,               
               Permissions = new List<Permission>()
            };

        public static SendInvitaionCommand ToSendCommand(this SendInvitationRequest request)
           => new(
               Id: Guid.Parse(request.Id),
               UserId: request.UserId
           );


        public static CancelInvitationCommand ToCancelCommand(this CancelInvitationRequest request)
            => new(
                Id: Guid.Parse(request.Id),
                UserId: request.UserId,
                AccountId: request.AccountId,
                SubscriptionId: request.SubscriptionId,
                MemberId: request.MemberId
            );

        public static AcceptInvitationCommand ToAcceptCommand(this AcceptInvitationRequest request)
            => new(
                Id: Guid.Parse(request.Id),
                UserId: request.UserId,
                AccountId: request.AccountId,
                SubscriptionId: request.SubscriptionId,
                MemberId: request.MemberId
            );

        public static RejectInvitationCommand ToRejectCommand(this RejectInvitationRequest request)
           => new(
               Id: Guid.Parse(request.Id),
               UserId: request.UserId,
               AccountId: request.AccountId,
               SubscriptionId: request.SubscriptionId,
               MemberId: request.MemberId
           );

        public static DeleteInvitationCommand ToDeletCommand(this DeleteInvitationRequest request)
            => new(
                Id: Guid.Parse(request.Id),
                UserId: request.UserId
            );




    }
}
