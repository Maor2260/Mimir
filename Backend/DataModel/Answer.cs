namespace DataModel;

public abstract class Answer : Entity
{
    public required string Text { get; set; }

    public string? Comment { get; set; }
}