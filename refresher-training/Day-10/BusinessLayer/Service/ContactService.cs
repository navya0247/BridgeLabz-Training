using ModelLayer.Dtos;
using ModelLayer.Entities;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;

namespace BusinessLayer.Service
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _repository;

        // repository injected here
        public ContactService(IContactRepository repository)
        {
            _repository = repository;
        }

        public Contact AddContact(ContactDto contactDto)
        {
            // convert dto to entity
            Contact contact = new Contact
            {
                Name = contactDto.Name,
                Phone = contactDto.Phone,
                Email = contactDto.Email
            };

            return _repository.AddContact(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return _repository.GetAllContacts();
        }

        public Contact? GetContactById(int id)
        {
            return _repository.GetContactById(id);
        }

        public Contact? UpdateContact(int id, ContactDto contactDto)
        {
            // convert dto to entity
            Contact contact = new Contact
            {
                Name = contactDto.Name,
                Phone = contactDto.Phone,
                Email = contactDto.Email
            };

            return _repository.UpdateContact(id, contact);
        }

        public bool DeleteContact(int id)
        {
            return _repository.DeleteContact(id);
        }
    }
}