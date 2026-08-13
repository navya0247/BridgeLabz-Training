using ModelLayer.Entities;

namespace RepositoryLayer.Interface
{
    public interface IContactRepository
    {
        // add new contact
        Contact AddContact(Contact contact);

        // get all contacts
        List<Contact> GetAllContacts();

        // get single contact by id
        Contact? GetContactById(int id);

        // update existing contact
        Contact? UpdateContact(int id, Contact contact);

        // delete contact by id
        bool DeleteContact(int id);
    }
}