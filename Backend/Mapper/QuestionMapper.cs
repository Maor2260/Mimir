using ApiFacade.QuestionFacade;
using Service.QuestionService;

namespace Mapper;

public static class QuestionMapper
{
    public static CreateMultipleChoiceQuestionDTO ToDTO(this CreateMultipleChoiceQuestionRequest request)
    {
        return new CreateMultipleChoiceQuestionDTO
        {
            Question = CreateMultipleChoiceQuestionDTO(request.Question),
            CorrectAnswer = CreateMultipleChoiceAnswerDTO(request.CorrectAnswer),
            WrongAnswers = CreateMultipleChoiceAnswerDTOs(request.WrongAnswers)
        };
    }
    
    private static CreateMultipleChoiceQuestionDTO.MultipleChoiceQuestion CreateMultipleChoiceQuestionDTO(CreateMultipleChoiceQuestion question)
    {
        return new CreateMultipleChoiceQuestionDTO.MultipleChoiceQuestion()
        {
            Index = question.Index,
            Text = question.Text,
            Difficulty = question.Difficulty.ToDTO(),
        };
    }
    
    private static HashSet<CreateMultipleChoiceQuestionDTO.MultipleChoiceAnswer> CreateMultipleChoiceAnswerDTOs(IEnumerable<CreateMultipleChoiceAnswer> answers)
    {
        return [..answers.Select(CreateMultipleChoiceAnswerDTO)];
    }
    
    private static CreateMultipleChoiceQuestionDTO.MultipleChoiceAnswer CreateMultipleChoiceAnswerDTO(CreateMultipleChoiceAnswer answer)
    {
        return new CreateMultipleChoiceQuestionDTO.MultipleChoiceAnswer
        {
            Index = answer.Index,
            Text = answer.Text,
            Comment = answer.Comment,
        };
    }
}