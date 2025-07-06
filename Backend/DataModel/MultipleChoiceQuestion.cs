namespace DataModel;

public class MultipleChoiceQuestion : Question
{
    public required MultipleChoiceAnswer CorrectAnswer { get; set; }
    
    public required HashSet<MultipleChoiceAnswer> WrongAnswers { get; set; }
}