namespace PartyInvitesSequel.Models.Interfaces
{
    public interface Repository<T>
    {
        IPersonList MemoryDB { get; set; }

        List<T> GetList();

        T GetGuest(int i);

        void AddGuest(T value);
    }
}
