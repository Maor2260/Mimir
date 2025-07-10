using DataModel;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public interface IDataContext
{
    int SaveChanges();

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    
    DbSet<Question> Questions { get; set; }

    DbSet<MultipleChoiceQuestion> Questions_MultipleChoice { get; set; }

    DbSet<Answer> Answers { get; set; }

    DbSet<MultipleChoiceAnswer> Anwers_MultipleChoice { get; set; }
    
    public DbSet<Player> Players { get; set; }

    public DbSet<Match> Matches { get; set; }
    
}