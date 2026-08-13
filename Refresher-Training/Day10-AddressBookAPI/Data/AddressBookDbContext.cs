using Day10_AddressBookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Day10_AddressBookAPI.Data
{
    public class AddressBookDbContext : DbContext
    {
        public AddressBookDbContext(
            DbContextOptions<AddressBookDbContext> options)
            : base(options)
        {
        }

        public DbSet<AddressEntry> AddressEntries { get; set; }
    }
}