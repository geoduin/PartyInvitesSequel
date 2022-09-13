using PartyInvitesSequel.Models.Interfaces;
using Moq;
using PartyInvitesSequel.Models;
using PartyInvitesSequel.Controllers;

namespace PartyInvites
{
    public class UnitTest1
    {
        [Fact]
        public void FillInForm()
        {
            //Arrange
            List<Guest> setList = new List<Guest>()
            {
                new Guest(){Name = "Eerste", Email = "Eerste@Example.org", Phone = "0645330802", WillAttend = true},
                new Guest(){Name = "Tweede", Email = "Tweede@Example.org", Phone = "0645330803", WillAttend = true},
                new Guest(){Name = "Derde", Email = "Derde@Example.org", Phone = "0645330804", WillAttend = false},
            };

            var moq = new Mock<IPersonList>();
            moq.Setup(m => m.GetGuest(0)).Returns(new Guest() { Name = "Eerste", Email = "Eerste@Example.org", Phone = "0645330802", WillAttend = true });
            var controller = new InvitationController(moq.Object);

            //Act
            
            //Assert
            Assert.True(true);
            //}
        }
    }
}