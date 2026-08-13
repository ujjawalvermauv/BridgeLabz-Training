using Day8_ContactManagement.Models;

namespace Day8_ContactManagement.Services
{
    public interface IContactService
    {
        List<Contact> GetAll();

        Contact GetById(int id);

        void Add(Contact contact);

        void Update(Contact contact);

        void Delete(int id);
    }
}