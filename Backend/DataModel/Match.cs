namespace DataModel;

public class Match : Entity
{
    public Player Player { get; set; }

    public HashSet<Player> Contestants { get; set; } = [];

    public HashSet<Question> PlayedQuestions { get; set; } = [];
}