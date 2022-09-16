using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Data;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;
using System.Diagnostics;

namespace PartyInvitesSequel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IRepository<Guest> guestRepository;

        public HomeController(ILogger<HomeController> logger, IRepository<Guest> guestRepository)
        {
            Console.WriteLine("Dependency injection is happening Home");
            _logger = logger;
            this.guestRepository = guestRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Console.WriteLine("Welkom op startpagina");
            return View();
        }

        public IActionResult Privacy()
        {
            Console.WriteLine("Gaat naar privacy pagina");
            return View();
        }

        [HttpGet]
        public IActionResult CandidateList()
        {
            return View();
        }

    }
}