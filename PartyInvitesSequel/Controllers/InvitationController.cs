using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Controllers
{
    public class InvitationController : Controller
    {
        public InvitationController()
        {
            Console.WriteLine("Dependency injection is happening Invitation");
        }
        public IActionResult Invitation()
        {
            Console.WriteLine("Invitations are wrong");
            return View();
        }
    }
}
