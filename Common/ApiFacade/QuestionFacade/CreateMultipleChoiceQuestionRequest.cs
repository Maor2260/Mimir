namespace ApiFacade.QuestionFacade;

public class CreateMultipleChoiceQuestionRequest : IApiFacadeRequest
{
    public CreateMultipleChoiceQuestion? Question { get; set; }
    
    public CreateMultipleChoiceAnswer? CorrectAnswer { get; set; }

    public IEnumerable<CreateMultipleChoiceAnswer>? WrongAnswers { get; set; }

    public void Validate()
    {
        if (Question is null) throw new MissingFieldException(nameof(Question));
        if (string.IsNullOrWhiteSpace(Question.Text)) throw new MissingFieldException($"{nameof(Question)}.{nameof(Question.Text)}");
        if (CorrectAnswer is null) throw new MissingFieldException(nameof(CorrectAnswer));
        if (string.IsNullOrWhiteSpace(CorrectAnswer.Text)) throw new MissingFieldException($"{nameof(CorrectAnswer)}.{nameof(CorrectAnswer.Text)}");
        if (WrongAnswers is null || !WrongAnswers.Any()) throw new MissingFieldException(nameof(WrongAnswers));
    }
}