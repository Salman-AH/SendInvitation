using DemoUsersManagementCommandSide.Commands.AcceptInvitation;
using DemoUsersManagementCommandSide.Commands.CancelInvitationRequest;
using DemoUsersManagementCommandSide.Commands.DeleteCommand;
using DemoUsersManagementCommandSide.Commands.RejectInvitation;
using DemoUsersManagementCommandSide.Commands.SendInvitaionRequest;

namespace DemoUsersManagementCommandSide.Domain
{
    public class BusinessRules
    {
        private readonly BusinessRequirements _requirements;

        public BusinessRules(InvitationMember invitation)
        {
            _requirements = new BusinessRequirements(invitation);
        }

        public void Validate(SendInvitaionCommand command)
        {            
            _requirements.RequireSameUser(command);            
        }

        public void Validate(CancelInvitationCommand command)
        {
            _requirements.RequireNotDeleted();
            _requirements.RequireSameUser(command);
            _requirements.RequireSent();
        }

        public void Validate(AcceptInvitationCommand command)
        {
            _requirements.RequireNotDeleted();
            _requirements.RequireSameUser(command);
            _requirements.RequireSent();
        }

        public void Validate(RejectInvitationCommand command)
        {
            _requirements.RequireNotDeleted();
            _requirements.RequireSameUser(command);
            _requirements.RequireSent();
        }
              

        public void Validate(DeleteInvitationCommand command)
        {
            _requirements.RequireNotDeleted();
            _requirements.RequireSameUser(command);
        }
    }

}
