using DataModel;

namespace Repository;

public interface IMatchRepository
{
    Task CreateAsync(Match entity);
    
    ValueTask<Match?> GetAsync(Key key);
    
    Task UpdateAsync(Match entity);
    
    Task DeleteAsync(Match entity);
}