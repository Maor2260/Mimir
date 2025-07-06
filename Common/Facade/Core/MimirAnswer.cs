namespace Facade.Core;

public class MimirAnswer
{
    public required MimirKey Key { get; set; }
    
    public required string Text { get; set; }

    public string? Comment { get; set; }
}