using DataModel;

namespace Service.QuestionService;

public record CreateMultipleChoiceQuestionDTO
{
    public required MultipleChoiceQuestion Question { get; set; }
    
    public required MultipleChoiceAnswer CorrectAnswer { get; init; }

    public HashSet<MultipleChoiceAnswer>? WrongAnswers { get; init; }

    public record MultipleChoiceQuestion
    {
        public uint? Index { get; init; }

        public required string Text { get; init; }

        public Difficulty? Difficulty { get; init; }
    }

    public record MultipleChoiceAnswer
    {
        public uint? Index { get; init; }

        public required string Text { get; init; }

        public string? Comment { get; init; }
    }
}