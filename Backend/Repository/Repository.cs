using DataModel;

namespace Repository;

public interface IRepository<in TEntity> where TEntity : Entity
{
    Task CreateAsync(TEntity entity);
    
    ValueTask<Question?> GetAsync(Key key);
    
    Task UpdateAsync(TEntity entity);
    
    Task DeleteAsync(TEntity entity);
}