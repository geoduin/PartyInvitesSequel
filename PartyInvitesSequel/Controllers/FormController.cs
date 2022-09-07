using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Controllers
{
    public class FormController : Controller
    {
        private GuestList list;

        public FormController(IPersonList list)
        {
            this.list = (GuestList?)list;
        }

        [HttpGet]
        public IActionResult FormParty()
        {
            Console.WriteLine("Post FormParty");
            foreach(Guest a in list.GetAll)
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
                list.AddPersonToList(gast);
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
