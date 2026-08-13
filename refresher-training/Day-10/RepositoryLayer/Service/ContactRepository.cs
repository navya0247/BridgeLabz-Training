using ModelLayer.Entities;
using RepositoryLayer.Context;
using RepositoryLayer.Interface;

namespace RepositoryLayer.Service
{
    public class ContactRepository : IContactRepository
    {
        private readonly AppDbContext _context;

        // db context injected here
        public ContactRepository(AppDbContext context)
        {
            _context = context;
        }

        public Contact AddContact(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        public List<Contact> GetAllContacts()
        {
            return _context.Contacts.ToList();
        }

        public Contact? GetContactById(int id)
        {
            return _context.Contacts.FirstOrDefault(c => c.ContactId == id);
        }

        public Contact? UpdateContact(int id, Contact contact)
        {
            var existing = _context.Contacts.FirstOrDefault(c => c.ContactId == id);
            if (existing == null) return null;

            // update fields
            existing.Name = contact.Name;
            existing.Phone = contact.Phone;
            existing.Email = contact.Email;

            _context.SaveChanges();
            return existing;
        }

        public bool DeleteContact(int id)
        {
            var existing = _context.Contacts.FirstOrDefault(c => c.ContactId == id);
            if (existing == null) return false;

            _context.Contacts.Remove(existing);
            _context.SaveChanges();
            return true;
        }
    }
}