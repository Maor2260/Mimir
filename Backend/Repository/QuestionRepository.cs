using DataModel;

namespace Repository;

public class QuestionRepository(IDataContext dataContext)
    : RepositoryService<Question>(dataContext), IQuestionRepository
{
    public override Task CreateAsync(Question question)
    {
        DataContext.Questions.AddAsync(question);
        return SaveChangesAsync();
    }

    public override ValueTask<Question?> GetAsync(Key key)
    {
        return DataContext.Questions.FindAsync(key);
    }

    public override Task UpdateAsync(Question entity)
    {
        DataContext.Questions.Update(entity);
        return SaveChangesAsync();
    }

    public override Task DeleteAsync(Question entity)
    {
        DataContext.Questions.Remove(entity);
        return SaveChangesAsync();
    }
}