﻿using Microsoft.AspNetCore.Mvc;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;
using System.Diagnostics;

namespace PartyInvitesSequel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPersonList list;

        public HomeController(ILogger<HomeController> logger, IPersonList list)
        {
            Console.WriteLine("Dependency injection is happening Home");
            _logger = logger;
            this.list = list;
        }

        [HttpGet]
        public IActionResult Index()
        {
            Console.WriteLine("Welkom op startpagina");
            list.ToString();
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
            return View(list);
        }

    }
}