using System.Globalization;
using Facade.Core;
using Service.MatchService;

namespace Hub;

public class GameHub : Microsoft.AspNetCore.SignalR.Hub
{
    private readonly IMatchService _matchService;
    
    private static readonly Dictionary<string, List<string>> Matches = new();

    public GameHub(IMatchService matchService)
    {
        _matchService = matchService;
    }


    public Task<string> Test()
    {
        var response = DateTime.Now.ToString(CultureInfo.CurrentCulture);
        Console.WriteLine("Debug - GameHub#Test was triggered: " + response);
        return Task.FromResult(response);
    }

    public async Task<MimirQuestion> CreateMultiChoiceQuestion(string question)
    {
        throw new  NotImplementedException();
    }
    
    public async Task<string> CreateMatch()
    {
        var match = await _matchService.CreateAsync(new CreateMatchDTO());
        var matchId = Guid.NewGuid().ToString()[..6].ToUpper();
        Matches[matchId] = new List<string> { Context.ConnectionId };
        return matchId;
    } 
}