using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Models
{
    public class GuestRepository : IRepository<Guest>
    {
        private GuestList IMemDB;

        public GuestRepository()
        {
            IMemDB = GuestList.Instance();
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
