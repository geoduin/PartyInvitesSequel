using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Models
{
    public class GuestRepository : Repository<Guest>
    {

        public IPersonList MemoryDB { get; set; }

        public GuestRepository(GuestList list)
        {
            MemoryDB = list;
        }

        public void AddGuest(Guest value)
        {
            MemoryDB.AddPersonToList(value);
        }

        public Guest GetGuest(int i)
        {
            return MemoryDB.GetGuest(i);
        }

        public List<Guest> GetList()
        {
            return GuestList.Instance().list;
        }
    }
}
