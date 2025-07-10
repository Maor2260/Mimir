using HubConnector;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.SignalR.Client;

namespace BlazorWebAssemblyApp.Pages;

public partial class Home
{
    private HubConnector.HubConnector Connector; //TODO: Should be of type IHubConnector
    
    private HubConnection?
        hubConnection; // TODO: Uninstall 'Microsoft.AspNetCore.SignalR.Client' Nuget package in BlazorWebApp, and move this to HubConnector

    protected override async Task OnInitializedAsync()
    {
        Connector = new HubConnector.HubConnector();
        Connector.StartConnection();
        
        /*
        hubConnection = new HubConnectionBuilder()
            .WithUrl("http://localhost:5143/hub")
            .WithAutomaticReconnect()
            .Build();


        hubConnection.StartAsync();
        var response = await hubConnection.InvokeAsync<string>("Test");
        Console.WriteLine("Server time: " + response);


        hubConnection.On<string>("Test", (connectionId) => { Console.WriteLine(connectionId); });

        await hubConnection.StartAsync();
        */
    }

    public string? NewMatchId { get; set; }
    
    private async void CreateMatchClick()
    {
        NewMatchId = await Connector.CreateMatch();
    }
    
    private void JoinMatchClicked()
    {
        throw new NotImplementedException();
    }
}