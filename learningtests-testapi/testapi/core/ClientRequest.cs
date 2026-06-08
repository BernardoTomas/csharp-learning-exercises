namespace testapi.Core;

public class ClientRequest
{
    public string? name { get; set; }
    public double accountBalance { get; set; }

    public Client CreateClient (int id)
    {
        return new Client
        {
            Id = id,
            Name = name,
            AccountBalance = accountBalance,
            CreatedAt = DateTime.Now,
            UpdatedAt = DateTime.Now
        };
    }

    public Client UpdateClient (Client clientToUpdate)
    {
        clientToUpdate.Name = name;
        clientToUpdate.AccountBalance = accountBalance;
        clientToUpdate.UpdatedAt = DateTime.Now;

        return clientToUpdate;
    }
}