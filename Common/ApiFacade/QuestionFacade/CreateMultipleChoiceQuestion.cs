using Facade.Core;

namespace ApiFacade.QuestionFacade;

public class CreateMultipleChoiceQuestion
{
    public uint? Index { get; set; }

    public MimirDifficulty? Difficulty { get; set; }
    
    public string? Text { get; set; }
}