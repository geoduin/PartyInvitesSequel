using Castle.Components.DictionaryAdapter.Xml;
using Microsoft.AspNetCore.Mvc;
using Moq;
using PartyInvitesSequel.Components;
using PartyInvitesSequel.Controllers;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class ControllerTest
    {

        [Fact]
        public async void CheckController2()
        {
            //Arrange
            List<Guest> dummyList = new List<Guest>()
            {
                new Guest() {Name = "Xin", Email = "Xin20Wang@outlook.com", Phone = "0645330382" , WillAttend = true},
                new Guest(){Name = "Nix", Email = "Niks@outlook.com", Phone = "0645330381" , WillAttend = true},
            };
            var fake = new Mock<IRepository<Guest>>();
            fake.Setup(m => m.GetValues()).Returns(dummyList);
            //Controllers
            var ProfileController = new ProfileController(fake.Object);

            //Act
            var result = ProfileController.Profile(1) as ViewResult;
            var Badresult = ProfileController.Profile(3);
            //Assert
            Assert.Equal("BadRequestResult", Badresult.GetType().Name);
            Assert.NotNull(result);
        }
    }
}
