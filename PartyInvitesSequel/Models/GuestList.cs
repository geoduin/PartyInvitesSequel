using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Models
{
    public class GuestList : IPersonList
    {
        public static List<Guest> list = new();

        public List<Guest> GetAll => list;

        public void AddPersonToList(Guest guest)
        {
            list.Add(guest);
        }

        public Guest GetGuest(int index)
        {
            return list[index];
        }

        public int Size()
        {
            return list.Count;
        }
    }
}
