using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Components
{
    public class BookViewComponent: ViewComponent
    {
        public IRepository<Guest> repository;

        public BookViewComponent(IRepository<Guest> repository)
        {
            Console.WriteLine("Dependency Injection ViewComponent done");
            this.repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Console.WriteLine("BookviewComponent is started");
            return View(repository.GetValues());
        }
    }
}
