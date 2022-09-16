using PartyInvitesSequel.Data;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Models.Repositories
{
    public class GuestSQLRepository: IRepository<Guest>
    {
        private DatabaseContext SQLServer;
        
        public GuestSQLRepository(DatabaseContext context)
        {
            this.SQLServer = context;
        }

        public void AddValue(Guest value)
        {
            throw new NotImplementedException();
        }

        public Guest GetFromList(int index)
        {
            throw new NotImplementedException();
        }
        //Sylvester Anika
        public List<Guest> GetValues()
        {
            var result = SQLServer.Add(new Guest() { Name = "Nieuwe", Email = "Hello@Outlook.com", });
            throw new NotImplementedException();
        }

        public void RemoveValue()
        {
            throw new NotImplementedException();
        }

        public bool UpdateValue(Guest value)
        {
            throw new NotImplementedException();
        }
    }
}
