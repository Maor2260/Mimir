using HubConnector;

namespace BlazorWebAssemblyApp.Pages;

public partial class Home
{
    private Connector Connector; //TODO: Should be of type IHubConnector

    protected override async Task OnInitializedAsync()
    {
        Connector = new Connector();
        Connector.StartConnection();
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