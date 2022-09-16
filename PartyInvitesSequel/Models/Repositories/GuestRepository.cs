using PartyInvitesSequel.Data;
using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Models.Repositories
{
    public class GuestRepository : IRepository<Guest>
    {
        private GuestList IMemDB;
        private DatabaseContext dataContext;

        public GuestRepository(DatabaseContext context)
        {
            IMemDB = GuestList.Instance();
            dataContext = context;
        }

        public void AddValue(Guest value)
        {
            IMemDB.AddPersonToList(value);
        }

        public Guest GetFromList(int index)
        {
            return IMemDB.GetGuest(index);
        }

        public List<Guest> GetValues()
        {
            return IMemDB.list;
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
