using ModelLayer.Dtos;
using ModelLayer.Entities;

namespace BusinessLayer.Interface
{
    public interface IContactService
    {
        Contact AddContact(ContactDto contactDto);
        List<Contact> GetAllContacts();
        Contact? GetContactById(int id);
        Contact? UpdateContact(int id, ContactDto contactDto);
        bool DeleteContact(int id);
    }
}