using Day8_ContactManagement.Models;
using Day8_ContactManagement.Repositories;

namespace Day8_ContactManagement.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository repository;

        public ContactService(IContactRepository repository)
        {
            this.repository = repository;
        }

        public List<Contact> GetAll()
        {
            return repository.GetAll();
        }

        public Contact GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Add(Contact contact)
        {
            repository.Add(contact);
        }

        public void Update(Contact contact)
        {
            repository.Update(contact);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}