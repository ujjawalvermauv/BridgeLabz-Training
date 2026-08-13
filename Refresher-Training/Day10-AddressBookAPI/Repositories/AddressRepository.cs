using Day10_AddressBookAPI.Data;
using Day10_AddressBookAPI.Models;

namespace Day10_AddressBookAPI.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly AddressBookDbContext context;

        public AddressRepository(AddressBookDbContext context)
        {
            this.context = context;
        }

        public List<AddressEntry> GetAll()
        {
            return context.AddressEntries.ToList();
        }

        public AddressEntry? GetById(int id)
        {
            return context.AddressEntries
                .FirstOrDefault(entry => entry.Id == id);
        }

        public void Add(AddressEntry entry)
        {
            context.AddressEntries.Add(entry);
            context.SaveChanges();
        }

        public void Update(AddressEntry entry)
        {
            context.AddressEntries.Update(entry);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            AddressEntry? entry = GetById(id);

            if (entry != null)
            {
                context.AddressEntries.Remove(entry);
                context.SaveChanges();
            }
        }
    }
}