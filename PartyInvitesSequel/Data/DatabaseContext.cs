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
    }
}
