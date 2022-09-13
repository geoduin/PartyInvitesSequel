using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Components
{
    public class BookViewComponent: ViewComponent
    {
        public IPersonList list;

        public BookViewComponent(IPersonList list)
        {
            Console.WriteLine("Dependency Injection ViewComponent done");
            Console.WriteLine(list.GetType().Name);
            this.list = list;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(list);
        }
    }
}
