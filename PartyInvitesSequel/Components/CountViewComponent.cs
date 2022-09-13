using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Components
{
    public class CountViewComponent : ViewComponent
    {
        public GuestList L;
        public CountViewComponent(IPersonList list)
        {
            L = (GuestList?)list;
        }

       public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(L.list.Count);
        }
    }
}
