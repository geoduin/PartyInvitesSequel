namespace PartyInvitesSequel.Models.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetValues();
        void RemoveValue();
        void AddValue(T value);
        T GetFromList(int index);
        bool UpdateValue(T value);
        void DeleteValue(int i);
    }
}
