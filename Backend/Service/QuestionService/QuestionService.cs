using DataModel;
using Repository;
using Service.Exceptions;

namespace Service.QuestionService;

public class QuestionService : IQuestionService
{
    private readonly IQuestionRepository _questionRepository;

    public QuestionService(IQuestionRepository questionRepository)
    {
        _questionRepository = questionRepository;
    }

    public async ValueTask<MultipleChoiceQuestion> CreateMultipleChoiceQuestion(CreateMultipleChoiceQuestionDTO dto)
    {
        var question = GenerateMultipleChoiceQuestion(dto);
        await _questionRepository.CreateAsync(question);
        return question;
    }

    private static MultipleChoiceQuestion GenerateMultipleChoiceQuestion(CreateMultipleChoiceQuestionDTO dto)
    {
        return new MultipleChoiceQuestion()
        {
            Index = dto.Question.Index,
            Text = dto.Question.Text,
            Difficulty = dto.Question.Difficulty,
            CorrectAnswer = GenerateMultipleChoiceAnswer(dto.CorrectAnswer),
            WrongAnswers = GenerateMultipleChoiceAnswers(dto.WrongAnswers ?? [])
        };
    }

    private static HashSet<MultipleChoiceAnswer> GenerateMultipleChoiceAnswers(IEnumerable<CreateMultipleChoiceQuestionDTO.MultipleChoiceAnswer> answers)
    {
        return [..answers.Select(GenerateMultipleChoiceAnswer)];
    }
    
    private static MultipleChoiceAnswer GenerateMultipleChoiceAnswer(CreateMultipleChoiceQuestionDTO.MultipleChoiceAnswer answer)
    {
        return new MultipleChoiceAnswer
        {
            Index = answer.Index,
            Text = answer.Text,
            Comment = answer.Comment,
        };
    }

    public async ValueTask<Question?> GetQuestion(GetQuestionDTO getQuestion)
    {
        return await _questionRepository.GetAsync(getQuestion.Key) ?? throw new QuestionNotFoundException(getQuestion.Key);
    }
}