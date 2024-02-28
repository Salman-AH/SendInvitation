using DemoUsersManagementCommandSide.Abstraction;
using DemoUsersManagementCommandSide.Exceptions;

namespace DemoUsersManagementCommandSide.Domain
{
    public class BusinessRequirements(InvitationMember invitaionMembers)
    {
        private readonly InvitationMember _invitaionMembers = invitaionMembers;

        public void RequireSameUser(IMemberInvitation command)
        {
            if (_invitaionMembers.UserId != command.UserId)
                throw new NotFoundException();
        }

        public void RequireNotDeleted()
        {
            if (_invitaionMembers.IsDeleted)
                throw new NotFoundException();
        }

        public void RequireSent()
        {
            if (!_invitaionMembers.IsSent)
                throw new RuleViolationException("Task is already uncsent.");
        }

        public void RequireCanceled()
        {
            if (_invitaionMembers.IsSent)
                throw new RuleViolationException("Task is already sent.");
        }

    }

}
