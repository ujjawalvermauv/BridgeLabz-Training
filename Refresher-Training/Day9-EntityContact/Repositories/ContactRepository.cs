using Day9_EntityContact.Data;
using Day9_EntityContact.Models;
using Microsoft.EntityFrameworkCore;

namespace Day9_EntityContact.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDbContext context;

        public ContactRepository(ContactDbContext context)
        {
            this.context = context;
        }

        public List<Contact> GetAll()
        {
            return context.Contacts.ToList();
        }

        public Contact? GetById(int id)
        {
            return context.Contacts
                .FirstOrDefault(contact => contact.Id == id);
        }

        public void Add(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();
        }

        public void Update(Contact contact)
        {
            context.Contacts.Update(contact);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Contact? contact = GetById(id);

            if (contact != null)
            {
                context.Contacts.Remove(contact);
                context.SaveChanges();
            }
        }
    }
}