namespace Facade.Core;

public class MimirQuestion
{
    public required MimirKey Key { get; set; }

    public MimirDifficulty? Difficulty { get; set; }

    public uint? Index { get; set; }

    public required string Text { get; set; }

    public MimirAnswer CorrectAnswer { get; set; }
}