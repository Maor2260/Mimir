using DataModel;

namespace Repository;

public interface IQuestionRepository
{
    Task CreateAsync(Question question);

    ValueTask<Question?> GetAsync(Key key);

    Task UpdateAsync(Question entity);
    
    Task DeleteAsync(Question entity);
}