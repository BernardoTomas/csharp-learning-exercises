namespace contact_list_api_to_deploy.Repository;

using contact_list_api_to_deploy.Models;

public class ContactRepository : IContactRepository
{
    private readonly IContactContext _context;

    public ContactRepository (IContactContext context)
    {
        _context = context;
    }

    public IEnumerable<Contact> GetContacts()
    {
        return _context.Contacts;
    }

    public Contact GetContactById(int contactId)
    {
        Contact? contact = _context.Contacts.FirstOrDefault(c => c.ContactId == contactId);
        if (contact is null) return null!;
        return contact;
    }

    public Contact AddContact(Contact contactToAdd)
    {
        _context.Contacts.Add(contactToAdd);
        _context.SaveChanges();

        return contactToAdd;
    }

    public Contact UpdateContact(Contact contactToUpdate)
    {
        _context.Contacts.Update(contactToUpdate);
        _context.SaveChanges();
        
        return contactToUpdate;
    }

    public void DeleteContact(int contactId)
    {
        Contact? contactToRemove = GetContactById(contactId);
        _context.Contacts.Remove(contactToRemove);
        _context.SaveChanges();
    }
}