using Facade.Core;

namespace ApiFacade.QuestionFacade;

public class CreateMultipleChoiceQuestionRespond
{
    public MimirMultipleChoiceQuestion? Question { get; set; }

    public CreateMultipleChoiceQuestionRespond(MimirMultipleChoiceQuestion question)
    {
        Question = question;
    }
}