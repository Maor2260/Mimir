using DataModel;

namespace Repository;

public class MatchRepository(IDataContext dataContext) : RepositoryService<Match>(dataContext), IMatchRepository
{
    public override Task CreateAsync(Match match)
    {
        DataContext.Matches.Add(match);
        return SaveChangesAsync();
    }

    public override ValueTask<Match?> GetAsync(Key key)
    {
        throw new NotImplementedException();
    }
 
    public override Task UpdateAsync(Match entity)
    {
        throw new NotImplementedException();
    }

    public override Task DeleteAsync(Match entity)
    {
        throw new NotImplementedException();
    }
}