using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Controllers
{
    public class InvitationController : Controller
    {
        private readonly IPersonList _list;
        public InvitationController(IPersonList list)
        {
            Console.WriteLine("Dependency injection is happening Invitation");
            _list = (GuestList)list;
        }
        public IActionResult Invitation()
        {
            return View(_list);
        }
    }
}
