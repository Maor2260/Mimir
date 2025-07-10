using DataModel;
using Repository;
using Service.PlayerService;

namespace Service.MatchService;

public class MatchService : IMatchService
{
    public readonly IMatchRepository _matchRepository;
    
    private readonly IPlayerService _playerService;

    public MatchService(IMatchRepository matchRepository, IPlayerService playerService)
    {
        _matchRepository = matchRepository;
        _playerService = playerService;
    }

    public async ValueTask<Match> CreateAsync(CreateMatchDTO dto)
    {
        var match = await GenerateMatch(dto);
        await _matchRepository.CreateAsync(match);
        return match;
    }

    private async ValueTask<Match> GenerateMatch(CreateMatchDTO dto)
    {
        var player = dto.PlayerKey is not null ? GetPlayer(dto.PlayerKey) : CreateGuest();
        return new Match()
        {
            Player = await player,
        };
    }

    private async ValueTask<Player> CreateGuest()
    {
        return await _playerService.CreatePlayer(new CreatePlayerDTO());
    }

    private async ValueTask<Player> GetPlayer(Key playerKey)
    {
        return await _playerService.GetPlayer(new GetPlayerDTO
        {
            PlayerKey = playerKey,
        });
    }
}