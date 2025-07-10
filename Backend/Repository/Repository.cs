using DataModel;

namespace Repository;

public abstract class RepositoryService<TEntity>(IDataContext dataContext) where TEntity : Entity
{
    protected readonly IDataContext DataContext = dataContext;

    public abstract Task CreateAsync(TEntity entity);
    
    public abstract ValueTask<TEntity?> GetAsync(Key key);
    
    public abstract Task UpdateAsync(TEntity entity);
    
    public abstract Task DeleteAsync(TEntity entity);
    
    protected Task SaveChangesAsync()
    {
        return DataContext.SaveChangesAsync(CancellationToken.None);
    }
}