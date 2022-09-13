using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Models
{
    public class GuestList : IPersonList
    {
        public List<Guest> list { get; set; }
        public static GuestList Current { set; get; }

        public GuestList()
        {
            list = new List<Guest>();
        }

        public static GuestList Instance()
        {
            if(Current == null)
            {
                Current = new GuestList();
            }
            return Current;
        }

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
