namespace PartyInvitesSequel.Models.Interfaces
{
    public interface IDatabase<T>
    {
        void Insert(T e);
        void Update(T e);
        void Delete(T e);
        T SelectAll();
        T SelectById(int id);
        T SelectByElement(string element);
    }
}
