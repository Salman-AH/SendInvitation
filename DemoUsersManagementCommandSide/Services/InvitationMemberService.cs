using DemoUsersManagementCommandSide;
using DemoUsersManagementCommandSide.Extensions;
using Grpc.Core;
using MediatR;

namespace DemoUsersManagementCommandSide.Services
{
    public class InvitationMemberService: InvitaionMembers.InvitaionMembersBase
    {
        private readonly ILogger<InvitationMemberService> _logger;
        private readonly IMediator _mediator;

        public InvitationMemberService(ILogger<InvitationMemberService> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public override async Task<Response> CreateInvitation(CreateInvitationRequest request, ServerCallContext context)
        {
            var command = request.ToCreateCommand();

            var id = await _mediator.Send(command);

            return new Response()
            {
                Id = id.ToString(),
                Message = "The invitation has been created successfuly"
            };
        }

    

        public override async Task<Response> SendInvitation(SendInvitationRequest request, ServerCallContext context)
        {
            var command = request.ToSendCommand();

            var id = await _mediator.Send(command);

            return new Response()
            {
                Id = id.ToString(),
                Message = "The invitation has been sent successfuly"
            };

        }

        public override async Task<Response> CancelInvitation(CancelInvitationRequest request, ServerCallContext context)
        {
            var command = request.ToCancelCommand();

            var id = await _mediator.Send(command);

            return new Response()
            {
                Id = id.ToString(),
                Message = "The invitation has been Canceled."
            };

        }

        public override async Task<Response> AcceptInvitation(AcceptInvitationRequest request, ServerCallContext context)
        {
            var command = request.ToAcceptCommand();

            var id = await _mediator.Send(command);

            return new Response()
            {
                Id = id.ToString(),
                Message = "The invitation has been Accepted."
            };

        }

        public override async Task<Response> RejectInvitation(RejectInvitationRequest request, ServerCallContext context)
        {
            var command = request.ToRejectCommand();

            var id = await _mediator.Send(command);

            return new Response()
            {
                Id = id.ToString(),
                Message = "The invitation has been rejected."
            };

        }

        public override async Task<Response> DeleteInvitation(DeleteInvitationRequest request, ServerCallContext context)
        {
            var command = request.ToDeletCommand();

            var id = await _mediator.Send(command);

            return new Response()
            {
                Id = id.ToString(),
                Message = "The invitation has been deleted."
            };

        }

    }
}
