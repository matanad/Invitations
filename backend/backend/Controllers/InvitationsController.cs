using backend.Models;
using backend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationsController : ControllerBase
    {
        private IInvitationRepository _InvitationRepository;

        public InvitationsController(IInvitationRepository InvitationRepository)
        {
            _InvitationRepository = InvitationRepository;
        }

        [HttpGet]
        public ActionResult<Invitation[]> GetInvitations()
        {
            var invations = _InvitationRepository.GetAllInvitations();
            return Ok(invations);
        }
        [HttpPost]
        [Route("{id}/approve")]
        public ActionResult ApproveInvitation(int id)
        {
            var Invitation = _InvitationRepository.ApproveInvitation(id);
            if (Invitation == null)
                return NotFound();

            return Ok(Invitation);
        }
        [HttpPost]
        [Route("{id}/reject")]
        public ActionResult RejectInvitation(int id)
        {
            var Invitation = _InvitationRepository.RejectInvitation(id);
            if (Invitation == null)
                return NotFound();

            return Ok(Invitation);
        }
        [HttpGet]
        [Route("exceptional")]
        public ActionResult<Invitation[]> GetExceptionalInvitation()
        {
            var exceptionalInvitations = _InvitationRepository.GetExceptionalInvitations();
            if (exceptionalInvitations == null)
                return NotFound();

            return Ok(exceptionalInvitations);
        }
    }
}
