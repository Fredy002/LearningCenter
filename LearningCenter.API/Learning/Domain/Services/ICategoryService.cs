using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Learning.Domain.Services.Comunication;

namespace LearningCenter.API.Learning.Domain.Services;

public interface ICategoryService
{
   Task<IEnumerable<Category>> ListAsync();
   Task<CategoryResponse> SaveAsync(Category category);
   Task<CategoryResponse> UpdateAsync(int id, Category category);
   Task<CategoryResponse> DeleteAsync(int id);
}