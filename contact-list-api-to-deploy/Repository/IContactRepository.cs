namespace contact_list_api_to_deploy.Repository;

using contact_list_api_to_deploy.Models;

public interface IContactRepository
{
    IEnumerable<Contact> GetContacts();
    Contact GetContactById(int contactId);
    Contact AddContact(Contact contact);
    Contact UpdateContact(Contact contact);
    void DeleteContact(int contactId);
}