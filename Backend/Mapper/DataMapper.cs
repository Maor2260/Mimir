using DataModel;
using Facade.Core;

namespace Mapper;

public static class DataMapper
{
    public static MimirMultipleChoiceQuestion FromDTO(this MultipleChoiceQuestion question)
    {
        return new MimirMultipleChoiceQuestion()
        {
            Key = question.Key.FromDTO(),
            Index = question.Index,
            Text = question.Text,
            CorrectAnswer = question.CorrectAnswer.FromDTO(),
            WrongAnswers = question.WrongAnswers.FromDTOs()
        };
    }

    public static HashSet<MimirMultipleChoiceAnswer> FromDTOs(this HashSet<MultipleChoiceAnswer> questions)
    {
        return [..questions.Select(FromDTO)];
    }
    
    public static MimirMultipleChoiceAnswer FromDTO(this MultipleChoiceAnswer answer)
    {
        return new MimirMultipleChoiceAnswer()
        {
            Key = answer.Key.FromDTO(),
            Index = answer.Index,
            Text = answer.Text,
            Comment = answer.Comment,
        };
    }
}