using Microsoft.AspNetCore.Mvc;

namespace ApiFacade.QuestionFacade;

public interface IQuestionFacade
{
    Task<ActionResult<CreateMultipleChoiceQuestionRespond>> CreateMultipleChoiceQuestion([FromBody] CreateMultipleChoiceQuestionRequest createMultipleChoiceQuestionRequest);
}