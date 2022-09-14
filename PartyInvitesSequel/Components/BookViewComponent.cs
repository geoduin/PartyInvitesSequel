using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Components
{
    public class BookViewComponent: ViewComponent
    {
        public IPersonList list;
        public IRepository<Guest> repository;

        public BookViewComponent(IPersonList list, IRepository<Guest> repository)
        {
            Console.WriteLine("Dependency Injection ViewComponent done");
            Console.WriteLine(list.GetType().Name);
            this.list = list;
            this.repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Console.WriteLine("BookviewComponent is started");
            return View(repository.GetValues());
        }
    }
}
