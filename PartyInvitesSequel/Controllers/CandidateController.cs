using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Controllers
{
    public class CandidateController : Controller
    {
        /*private GuestList personList;

        public CandidateController(IPersonList personList)
        {
            this.personList = (GuestList?)personList;
        }*/

        public IActionResult CandidateList()
        {
            return View();
        }
    }
}
