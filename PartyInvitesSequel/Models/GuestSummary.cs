using Microsoft.AspNetCore.Mvc;

namespace PartyInvitesSequel.Models
{
    public class GuestSummary : ViewComponent
    {
        private GuestList _guestList;

        public GuestSummary(GuestList guestList)
        {
            _guestList = guestList;
        }

       public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemAsync();
            return View(items);
        }

        private async Task<List<Guest>> GetItemAsync() => _guestList.GetAll.ToList();
    }
}
