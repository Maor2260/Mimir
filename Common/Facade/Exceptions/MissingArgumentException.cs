namespace Facade.Exceptions;

public class MissingArgumentException : Exception, IFacadeException
{
    private string MissingField { get; }

    public override string Message => $"Missing field: {MissingField}";

    public MissingArgumentException(string missingField)
    {
        MissingField = missingField;
    }
}