using PartyInvitesSequel.Data;
using PartyInvitesSequel.Models.Helpers;
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

        //In memory-database
        public async void AddValue(Guest value)
        {
            IMemDB.AddPersonToList(value);
            //Inserts into database
            dataContext.InsertGuest(value);
        }

        public Guest GetFromList(int index)
        {
            return IMemDB.GetGuest(index);
        }

        public List<Guest> GetValues()
        {
            IMemDB.list = dataContext.SelectAllGuests();
            return IMemDB.list;
        }

        public void DeleteValue(int i)
        {
            Guest g = IMemDB.GetGuest(i);
            dataContext.DeleteGuest(g);

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
