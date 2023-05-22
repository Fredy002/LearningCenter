using LarningCenter.API.Learning.Domain.Model;

namespace LarningCenter.API.Learning.Domain.Repositories;

public interface ITutorialRepository
{
    Task<IEnumerable<Tutorial>> ListAsync();
    Task AddAsync(Tutorial tutorial);
    Task<Tutorial> FindByIdAsync(int tutorialId);
    Task<Tutorial> FindByTitleAsync(string title);
    Task<IEnumerable<Tutorial>> FindByCategoryIdAsync(int categoryId);
    void Update(Tutorial tutorial);
    void Remove(Tutorial tutorial);
}