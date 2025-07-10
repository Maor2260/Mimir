using DataModel;

namespace Service.Exceptions;

public class PlayerNotFoundException : EntityNotFoundException<Player>
{
    public PlayerNotFoundException(Key key) : base(key) { }
}