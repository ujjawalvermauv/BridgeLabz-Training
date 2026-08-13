using Day8_ContactManagement.Models;

namespace Day8_ContactManagement.Repositories
{
    public interface IContactRepository
    {
        List<Contact> GetAll();

        Contact GetById(int id);

        void Add(Contact contact);

        void Update(Contact contact);

        void Delete(int id);
    }
}