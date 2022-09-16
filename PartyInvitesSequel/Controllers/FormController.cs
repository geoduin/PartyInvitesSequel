using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Controllers
{
    public class FormController : Controller
    {
        private IRepository<Guest> listRepository;

        public FormController(IRepository<Guest> listRepository)
        {
            Console.WriteLine("Dependency injection is happening formcontroller");
            this.listRepository = listRepository;
        }

        [HttpGet]
        public IActionResult FormParty()
        {
            Console.WriteLine("Post FormParty");
            foreach(Guest a in listRepository.GetValues())
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
                listRepository.AddValue(gast);
                //return View("../Home/Index");
                return RedirectToAction(actionName: nameof(Index), controllerName: "Home");
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
