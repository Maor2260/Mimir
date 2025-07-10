using DataModel;
using Repository;
using Service.Exceptions;

namespace Service.PlayerService;

public class PlayerService : IPlayerService
{
    private readonly IPlayerRepository _playerRepository;

    public PlayerService(IPlayerRepository playerRepository)
    {
        _playerRepository = playerRepository;
    }

    public ValueTask<Player> CreateGuest(CreateGuestPlayerDTO createGuestPlayerDto)
    {
        return CreatePlayer(new CreatePlayerDTO()); // Debug...
    }
    
    public async ValueTask<Player> CreatePlayer(CreatePlayerDTO dto)
    {
        Player player = GeneratePlayer(dto);
        await _playerRepository.CreateAsync(player);
        return player;
    }

    private static Player GeneratePlayer(CreatePlayerDTO dto)
    {
        return new Player()
        {
            Name = dto.Name ?? "Guest", // TODO: Replace "Guest"
        };
    }

    public async ValueTask<Player> GetPlayer(GetPlayerDTO dto)
    {
        return await _playerRepository.GetAsync(dto.PlayerKey) ?? throw new PlayerNotFoundException(dto.PlayerKey);
    }
}