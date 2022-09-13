namespace PartyInvitesSequel.Models.Interfaces
{
    public interface IPersonList
    {
        void AddPersonToList(Guest guest);
        Guest GetGuest(int index);
        int Size();
    }
}
