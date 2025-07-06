namespace Service.Exceptions;

public class InvalidArgumentException : Exception, IServiceException
{
    public InvalidArgumentException(string? message) : base(message) { }
}