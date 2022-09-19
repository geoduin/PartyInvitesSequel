using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Helpers;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Components
{
    public class CountViewComponent : ViewComponent
    {
        public GuestList L;
        public IRepository<Guest> GuestRepository;
        public CountViewComponent(IPersonList list, IRepository<Guest> guestRepository)
        {
            L = (GuestList?)list;
            GuestRepository = guestRepository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(GuestRepository.GetValues().Count);
        }
    }
}
