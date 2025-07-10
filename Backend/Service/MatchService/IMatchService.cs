using DataModel;

namespace Service.MatchService;

public interface IMatchService
{
    ValueTask<Match> CreateAsync(CreateMatchDTO createMatchDto);
}