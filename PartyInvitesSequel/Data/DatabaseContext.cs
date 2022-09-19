using Microsoft.EntityFrameworkCore;
using PartyInvitesSequel.Models;

namespace PartyInvitesSequel.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Guest> guests { get; set; }

        public void InsertGuest(Guest guest)
        {
            Add(guest);
            SaveChanges();
        }

        public List<Guest> SelectAllGuests()
        {
            return guests.ToList();
        }

        public void DeleteGuest(Guest guest)
        {
            guests.Remove(guest);
            SaveChanges();
        }
    }
}
