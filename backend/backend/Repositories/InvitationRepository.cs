using backend.Models;

namespace backend.Repositories
{
    public class InvitationRepository : IInvitationRepository
    {
        private Invitation[] invations;
        public InvitationRepository()
        {
            invations = new Invitation[]
            {
                new Invitation { Id = 1, CustomerName = "Alice", TotalPrice = 250.00m, IsExceptional = true, Status = OrderStatus.Pending },
                new Invitation { Id = 2, CustomerName = "Bob", TotalPrice = 450.50m, IsExceptional = true, Status = OrderStatus.Approved },
                new Invitation { Id = 3, CustomerName = "Charlie", TotalPrice = 150.75m, IsExceptional = false, Status = OrderStatus.Rejected }
            };
        }
        public Invitation[] GetAllInvitations()
        {
            return invations;
        }
        public Invitation[] GetExceptionalInvitations()
        {
            return invations.Where(i => i.IsExceptional && i.Status == OrderStatus.Pending).ToArray();
        }
        public Invitation? RejectInvitation(int id)
        {
            var invation = invations.FirstOrDefault(i => i.Id == id);
            if (invation == null)
                return null;
            invation.Status = OrderStatus.Rejected;
            return invation;
        }
        public Invitation? ApproveInvitation(int id)
        {
            var invatation = invations.FirstOrDefault(i => i.Id == id);
            if (invatation == null)
                return null;
            invatation.Status = OrderStatus.Approved;
            return invatation;
        }

    }
}
