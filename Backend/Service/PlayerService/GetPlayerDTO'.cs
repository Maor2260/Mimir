using DataModel;

namespace Service.PlayerService;

public class GetPlayerDTO
{
    public required Key PlayerKey { get; init; }
}