using DataModel;

namespace Repository;

public class PlayerRepository(IDataContext dataContext) : RepositoryService<Player>(dataContext), IPlayerRepository
{
    public override Task CreateAsync(Player player)
    {
        DataContext.Players.Add(player);
        return SaveChangesAsync();
    }

    public override ValueTask<Player?> GetAsync(Key key)
    {
        return DataContext.Players.FindAsync(key);
    }

    public override Task UpdateAsync(Player entity)
    {
        throw new NotImplementedException();
    }

    public override Task DeleteAsync(Player entity)
    {
        throw new NotImplementedException();
    }
}