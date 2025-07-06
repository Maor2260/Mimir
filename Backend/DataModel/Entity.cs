using System.ComponentModel.DataAnnotations;

namespace DataModel;

public abstract class Entity
{
    [Key] public Key Key { get; set; } = new();
    
    public override bool Equals(object? other)
    {
        return other is Entity entity && 
               Key.Equals(entity.Key);
    }
}