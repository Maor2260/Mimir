namespace DataModel;

public abstract class Question : Entity, Indexable
{
    public uint? Index { get; set; }

    public Difficulty? Difficulty { get; set; }

    public required string Text { get; set; }
}