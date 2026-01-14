using backend.Models;

namespace backend.Repositories
{
    public interface IInvitationRepository
    {
        Invitation? ApproveInvitation(int id);
        Invitation[] GetAllInvitations();
        Invitation[] GetExceptionalInvitations();
        Invitation? RejectInvitation(int id);
    }
}