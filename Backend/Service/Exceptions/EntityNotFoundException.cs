using DataModel;

namespace Service.Exceptions;

public abstract class EntityNotFoundException<TEntity> : Exception, IServiceException 
    where TEntity : Entity
{
    private Key Key { get;}
    
    public override string Message => $"{typeof(TEntity).Name}[{Key}] not found";

    protected EntityNotFoundException(Key key)
    {
        Key = key;
    }
}