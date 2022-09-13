using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Controllers
{
    public class FormController : Controller
    {
        private GuestList l;

        public FormController(IPersonList list)
        {
            Console.WriteLine("Dependency injection is happening formcontroller");
            this.l = (GuestList?)list;
        }

        [HttpGet]
        public IActionResult FormParty()
        {
            Console.WriteLine("Post FormParty");
            foreach(Guest a in l.list)
            {
                Console.WriteLine(a.Name);
            }
            return View();
        }

        [HttpPost]
        public IActionResult FormParty(Guest gast)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine(gast);
                l.AddPersonToList(gast);
                return View("../Home/Index");
            }
            return View();
        }

        public IActionResult BASIC()
        {
            Console.WriteLine("Post BASIC");
            return View();
        }
    }
}
