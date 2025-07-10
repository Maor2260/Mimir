using DataModel;

namespace Repository;

public interface IPlayerRepository
{
    Task CreateAsync(Player player);

    ValueTask<Player?> GetAsync(Key key);
    
    Task UpdateAsync(Player entity);
    
    Task DeleteAsync(Player entity);
}