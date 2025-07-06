using DataModel;

namespace Service.Exceptions;

public class QuestionNotFoundException : EntityNotFoundException<Question>
{
    public QuestionNotFoundException(Key key) : base(key) { }
}