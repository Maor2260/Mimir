namespace Facade.Core;

public class MimirMultipleChoiceQuestion : MimirQuestion
{
    public new required MimirMultipleChoiceAnswer CorrectAnswer { get; set; }
    
    public HashSet<MimirMultipleChoiceAnswer>? WrongAnswers { get; set; }
}