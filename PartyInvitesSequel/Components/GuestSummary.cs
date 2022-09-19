using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Components
{
    public class GuestSummary : ViewComponent
    {
        private IRepository<Guest> _guestRepository;

        public GuestSummary(IRepository<Guest> repo)
        {
            _guestRepository = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemAsync();
            return View(items);
        }

        private async Task<List<Guest>> GetItemAsync() => _guestRepository.GetValues();
    }
}
