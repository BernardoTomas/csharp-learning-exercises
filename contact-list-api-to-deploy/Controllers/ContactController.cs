namespace contact_list_api_to_deploy.Controllers;

using contact_list_api_to_deploy.Models;
using contact_list_api_to_deploy.Repository;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("contact")]
public class ContactController : ControllerBase
{
    private readonly IContactRepository _repository;

    public ContactController (IContactRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllContacts()
    {
        return Ok(_repository.GetContacts());
    }

    [HttpGet("{contactId}")]
    public IActionResult GetContactById(int contactId)
    {
        var contact = _repository.GetContactById(contactId);
        if (contact is null) return NotFound("No contact with this Id exists");
        return Ok(contact);
    }

    [HttpPost]
    public IActionResult AddContact([FromBody] Contact contact)
    {
        return Created("", _repository.AddContact(contact));
    }

    [HttpPut]
    public IActionResult UpdateContact([FromBody] Contact contact)
    {
        return Ok(_repository.UpdateContact(contact));
    }

    [HttpDelete("{contactId}")]
    public IActionResult DeleteContact(int contactId)
    {
        _repository.DeleteContact(contactId);
        return NoContent();
    }
}