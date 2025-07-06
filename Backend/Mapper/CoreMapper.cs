using DataModel;
using Facade.Core;
using Service.Exceptions;

namespace Mapper;

public static class CoreMapper
{
    public static MimirKey FromDTO(this Key key)
    {
        return new MimirKey()
        {
            Id = key.Id
        };
    }
    
    public static Difficulty? ToDTO(this MimirDifficulty? difficulty)
    {
        return difficulty switch
        {
            null => null,
            MimirDifficulty.VeryEasy => Difficulty.VeryEasy,
            MimirDifficulty.Easy => Difficulty.Easy,
            MimirDifficulty.Medium => Difficulty.Medium,
            MimirDifficulty.Hard => Difficulty.Hard,
            MimirDifficulty.VeryHard => Difficulty.VeryHard,
            MimirDifficulty.Extreme => Difficulty.Extreme,
            _ => throw new InvalidArgumentException("Unknown difficulty")
        };
    }
    
    public static MimirDifficulty? FromDTO(this Difficulty? difficulty)
    {
        return difficulty switch
        {
            null => null,
            Difficulty.VeryEasy => MimirDifficulty.VeryEasy,
            Difficulty.Easy => MimirDifficulty.Easy,
            Difficulty.Medium => MimirDifficulty.Medium,
            Difficulty.Hard => MimirDifficulty.Hard,
            Difficulty.VeryHard => MimirDifficulty.VeryHard,
            Difficulty.Extreme => MimirDifficulty.Extreme,
            _ => throw new InvalidArgumentException("Unknown difficulty")
        };
    }
}