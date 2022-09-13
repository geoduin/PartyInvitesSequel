using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Controllers
{
    public class ProfileController : Controller
    {
        public IPersonList _list;

        public ProfileController(IPersonList list)
        {
            Console.WriteLine("Dependency injection Profile");
            _list = list;
        }

        public IActionResult Profile(int index)
        {
            if(_list.Size() == 0)
            {
                Console.WriteLine($"User list is still empty");
                return NotFound();
            } else if(_list.Size() < index)
            {
                Console.WriteLine($"No User with index {index} is found in the list.");
                return BadRequest();
            }
            Guest guest = _list.GetGuest(index);
            return View(guest);
        }
    }
}
