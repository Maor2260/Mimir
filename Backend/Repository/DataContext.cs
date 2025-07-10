using DataModel;
using Repository.Converters;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class DataContext : DbContext, IDataContext
{
    public DbSet<Question> Questions { get; set; }
    
    public DbSet<MultipleChoiceQuestion> Questions_MultipleChoice { get; set; }
    
    public DbSet<Answer> Answers { get; set; }
    
    public DbSet<MultipleChoiceAnswer> Anwers_MultipleChoice { get; set; }

    public DbSet<Player> Players { get; set; }

    public DbSet<Match> Matches { get; set; }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder
            .Properties<Key>()
            .HaveConversion<KeyConverter>();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite($"Data Source={Environment.GetEnvironmentVariable("localDatabasePath") ?? "TestV1 Mimir.db"}");
    }
}