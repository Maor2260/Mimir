using Microsoft.EntityFrameworkCore;

namespace DataModel;

[Owned]
public class Key
{
    public Guid Id { get; private init; }
    
    public Key()
    {
        Id = Guid.NewGuid();
    }

    public static Key FromGuid(Guid guid)
    {
        return new Key()
        {
            Id = guid
        };
    }
    
    /// <summary>
    /// Verify if the given object has a matching Key value
    /// </summary>
    public override bool Equals(object? key)
    {
        return key is Key other &&
               Id.Equals(other.Id);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public override string ToString()
    {
        return Id.ToString();
    }
}