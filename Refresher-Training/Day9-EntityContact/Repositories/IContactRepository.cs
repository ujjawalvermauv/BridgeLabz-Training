using Day9_EntityContact.Models;

namespace Day9_EntityContact.Repositories
{
    public interface IContactRepository
    {
        List<Contact> GetAll();

        Contact? GetById(int id);

        void Add(Contact contact);

        void Update(Contact contact);

        void Delete(int id);
    }
}