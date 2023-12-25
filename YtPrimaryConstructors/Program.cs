using Microsoft.Extensions.Logging;

var account = new BankAccount("48375893", "Wilson Neto");
var account2 = new OtherBankAccount("48375893", "Wilson Neto");
account2.ChangeOwner("Outro");
    
Console.WriteLine(account);
Console.WriteLine(account2.Owner);

var add = new Address("rua x", 10);
Console.WriteLine(add.Number);

public record Address(string Street, int Number);

public class BankAccount(string accountId, string owner)
{
    public BankAccount() : this("", "")
    {}
    
    public string AccountId { get; } = accountId;
    public string Owner { get; } = owner;

    public override string ToString() => $"Account ID: {AccountId}, Owner: {Owner}";
}

public class OtherBankAccount(string accountId, string owner)
{
    
    public override string ToString() => $"Account ID: {accountId}, Owner: {owner}";

    public void ChangeOwner(string newOwner) => owner = newOwner;

    public string Owner => owner;
}

class ServiceGateway(ILogger<ApiGateway> _logger)
{
    private readonly ILogger<ApiGateway> _logger = _logger;

    public void DoSomething()
    {
        _logger.LogInformation("information...");
    }
    
    public void DoOtherStuff()
    {
        _logger.LogInformation("information...");
    }
}

class ApiGateway(ILogger<ApiGateway> logger)
{
    // <WarningsAsErrors>CS9124</WarningsAsErrors>
    private readonly ILogger<ApiGateway> _logger = logger;

    public void DoSomething()
    {
        _logger.LogInformation("information...");
    }
    
    public void DoOtherStuff()
    {
        _logger.LogInformation("information...");
    }
}

class DbGateway(ILogger<ApiGateway> logger)
{
    public void DoSomething()
    {
        logger.LogInformation("information...");
    }
    
    public void DoOtherStuff()
    {
        logger.LogInformation("information...");
    }
}









