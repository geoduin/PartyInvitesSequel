using PartyInvitesSequel.Models.Interfaces;

namespace PartyInvitesSequel.Models
{
    public class GuestList : IPersonList
    {
        public List<Guest> list { get; set; }
        public static GuestList guestList { get; set; }
        
        public List<Guest> GetAll => list;

        public GuestList()
        {
            list = new();
        }

        public static GuestList Instance()
        {
            if(guestList == null)
            {
                guestList = new GuestList();
            }
            return guestList;
        }

        public void AddPersonToList(Guest guest)
        {
            list.Add(guest);
        }

        public Guest GetGuest(int index)
        {
            return list[index];
        }

        public void SetList(List<Guest> list)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            return list.Count;
        }
    }
}
