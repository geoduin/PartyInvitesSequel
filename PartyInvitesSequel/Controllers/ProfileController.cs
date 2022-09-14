using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Controllers
{
    public class ProfileController : Controller
    {
        private IRepository<Guest> repository;

        public ProfileController(IRepository<Guest> repository)
        {
            Console.WriteLine("Dependency injection Profile");
            this.repository = repository;
        }

        public IActionResult Profile(int index)
        {
            if(repository.GetValues().Count == 0)
            {
                Console.WriteLine($"User list is still empty");
                return NotFound();
            } else if(repository.GetValues().Count < index)
            {
                Console.WriteLine($"No User with index {index} is found in the list.");
                return BadRequest();
            }
            Guest guest = repository.GetFromList(index);
            return View(guest);
        }
    }
}
