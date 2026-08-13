using Day10_AddressBookAPI.Models;

namespace Day10_AddressBookAPI.Services
{
    public interface IAddressService
    {
        List<AddressEntry> GetAll();

        AddressEntry? GetById(int id);

        void Add(AddressEntry entry);

        void Update(AddressEntry entry);

        void Delete(int id);
    }
}