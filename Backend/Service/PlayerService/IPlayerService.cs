using DataModel;

namespace Service.PlayerService;

public interface IPlayerService
{
    ValueTask<Player> CreateGuest(CreateGuestPlayerDTO createGuestPlayerDto);
    
    ValueTask<Player> CreatePlayer(CreatePlayerDTO createPlayerDto);
    
    ValueTask<Player> GetPlayer(GetPlayerDTO getPlayerDto);
}