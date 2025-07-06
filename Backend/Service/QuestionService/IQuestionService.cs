using DataModel;

namespace Service.QuestionService;

public interface IQuestionService
{
    ValueTask<MultipleChoiceQuestion> CreateMultipleChoiceQuestion(CreateMultipleChoiceQuestionDTO createMultipleChoiceQuestion);
    
    ValueTask<Question?> GetQuestion(GetQuestionDTO getQuestion);
}