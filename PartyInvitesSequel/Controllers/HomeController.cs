using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Data;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;
using System.Diagnostics;
using System.Security.Claims;

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
        
        [Authorize]
        public IActionResult LoggedInPage()
        {
            return View();
        }

        public IActionResult Verplaatsen()
        {
            var ClaimGuy = new List<Claim>()
            {
                new Claim(ClaimTypes.Name,  "Xin"),
                new Claim(ClaimTypes.Email,  "Xin20Wang@outlook.com")
            };

            var identity = new ClaimsIdentity(ClaimGuy, "Xins Identiteit");

            var principle = new ClaimsPrincipal(new[] { identity });

            HttpContext.SignInAsync(principle);
            return RedirectToAction("Index");
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