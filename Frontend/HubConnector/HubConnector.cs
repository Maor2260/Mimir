using Microsoft.AspNetCore.SignalR.Client;

namespace HubConnector;

public class HubConnector : IHubConnector
{
    private static readonly Uri BASE_ADDRESS = new Uri("http://localhost:5143/hub");
    
    private HubConnection _connection;

    public void StartConnection()
    {
        _connection = new HubConnectionBuilder()
            .WithUrl(BASE_ADDRESS)
            .WithAutomaticReconnect()
            .Build();
        _connection.StartAsync();
    }

    public async Task<string> CreateMatch()
    {
        return await _connection.InvokeAsync<string>("CreateMatch");
    }
    
    public Task GetNextQuestion()
    {
        return _connection.InvokeAsync("null", null);
    }
}