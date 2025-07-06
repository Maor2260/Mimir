using DataModel;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Repository.Converters;

public class KeyConverter : ValueConverter<Key, Guid>
{
    public KeyConverter() : base(
        k => k.Id,
        id => Key.FromGuid(id))
    {
    }
}