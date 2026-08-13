using Day10_AddressBookAPI.Models;
using Day10_AddressBookAPI.Repositories;

namespace Day10_AddressBookAPI.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository repository;

        public AddressService(IAddressRepository repository)
        {
            this.repository = repository;
        }

        public List<AddressEntry> GetAll()
        {
            return repository.GetAll();
        }

        public AddressEntry? GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Add(AddressEntry entry)
        {
            repository.Add(entry);
        }

        public void Update(AddressEntry entry)
        {
            repository.Update(entry);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}