using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Learning.Domain.Repositories;
using LearningCenter.API.Shared.Persistence.Contexts;
using LearningCenter.API.Shared.Persistence.Repositories;

namespace LearningCenter.API.Learning.Persistence.Repositories;

public class TutorialRepository : BaseRepository, ITutorialRepository
{
    public TutorialRepository(AppDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<Tutorial>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }

    public Task<Tutorial> FindByIdAsync(int tutorialId)
    {
        throw new NotImplementedException();
    }

    public Task<Tutorial> FindByTitleAsync(string title)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Tutorial>> FindByCategoryIdAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public void Update(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }

    public void Remove(Tutorial tutorial)
    {
        throw new NotImplementedException();
    }
}