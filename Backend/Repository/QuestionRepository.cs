using DataModel;

namespace Repository;

public class QuestionRepository(IDataContext dataContext) : IQuestionRepository
{
    public Task CreateAsync(Question question)
    {
        dataContext.Questions.AddAsync(question);
        return SaveChangesAsync();
    }

    public ValueTask<Question?> GetAsync(Key key)
    {
        return dataContext.Questions.FindAsync(key); ;
    }

    public Task UpdateAsync(Question entity)
    {
        dataContext.Questions.Update(entity);
        return SaveChangesAsync();
    }

    public Task DeleteAsync(Question entity)
    {
        dataContext.Questions.Remove(entity);
        return SaveChangesAsync();
    }

    private Task SaveChangesAsync()
    {
        return dataContext.SaveChangesAsync(CancellationToken.None);
    }
}