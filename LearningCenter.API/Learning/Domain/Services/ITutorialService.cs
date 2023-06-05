using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Learning.Domain.Services.Comunication;

namespace LearningCenter.API.Learning.Domain.Services;

public interface ITutorialService
{
   Task<IEnumerable<Tutorial>> ListAsync();
   Task<IEnumerable<Tutorial>> ListByCategoryIdAsync(int categoryId);
   Task<TutorialResponse> SaveAsync(Tutorial tutorial);
   Task<TutorialResponse> UpdateAsync(int id, Tutorial tutorial);
   Task<TutorialResponse> DeleteAsync(int id);
}