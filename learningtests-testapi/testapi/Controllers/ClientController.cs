namespace testapi.Controllers;
using Microsoft.AspNetCore.Mvc;
using testapi.Core;

[ApiController]
[Route("clients")]
public class ClientController : ControllerBase
{
    private static List<Client> _clients = new();
    private static int _nextId = 1;

    [HttpGet]
    public ActionResult Get()
    {
        return Ok(_clients);
    }

    [HttpPost]
    public ActionResult Create(ClientRequest request)
    {
        var newClient = request.CreateClient(_nextId++);
        _clients.Add(newClient);

        return StatusCode(201, newClient);
    }

    [HttpPut("{id}")]
    public ActionResult Update(int id, ClientRequest request)
    {
        var clientToUpdate = _clients.FirstOrDefault(client => client.Id == id);

        if (clientToUpdate == null)
        {
            return NotFound("Client not found!");
        }

        var clientUpdated = request.UpdateClient(clientToUpdate);

        return Ok(clientUpdated);
    }

    [HttpDelete("{id}")]
    public ActionResult Delete(int id)
    {
        var deletedClient = _clients.RemoveAll(client => client.Id == id);

        if (deletedClient == 0)
        {
            return NotFound("Client not found!");
        }

        return NoContent();
    }
}