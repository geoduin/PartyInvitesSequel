using Microsoft.AspNetCore.Mvc;
using Moq;
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
    public class UnitTests
    {
        [Fact]
        public void CheckModelState()
        {
            //Arrange
            List<Guest> dummyList = new List<Guest>(){new Guest() {Name = "Xin", Email = "Xin20Wang@outlook.com", Phone = "0645330382" , WillAttend = true},};
            var mock = new Mock<IRepository<Guest>>();
            mock.Setup(n => n.GetValues()).Returns(dummyList);
            var Controller = new FormController(mock.Object);
            Controller.ModelState.AddModelError("", "Required");

            //Act
            var BadResult = Controller.FormParty(new Guest() {Email = "Niks@outlook.com", Phone = "0645330381", WillAttend = true }) as ViewResult;
            var sameForm = Assert.IsType<ViewResult>(BadResult);
            //Assert
            Assert.Equal(1, sameForm.ViewData.ModelState.Count);
            Assert.False(BadResult.ViewData.ModelState.IsValid);
        }

        [Fact]
        public void RedirectionState()
        {
            //Arrange
            List<Guest> dummyList = new List<Guest>() {  };
            var mock = new Mock<IRepository<Guest>>();
            mock.Setup(n => n.GetValues()).Returns(dummyList);
            var Controller = new FormController(mock.Object);

            //Act
            var result = Controller.FormParty(new Guest() { Name = "Xin", Email = "Xin20Wang@outlook.com", Phone = "0645330382", WillAttend = true });

            //Assert
            var redirectionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Home", redirectionResult.ControllerName);
            Assert.Equal("Index", redirectionResult.ActionName);
        }
    }
}
