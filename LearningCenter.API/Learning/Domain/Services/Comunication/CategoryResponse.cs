using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Shared.Domain.Services.Comunication;

namespace LearningCenter.API.Learning.Domain.Services.Comunication;

public class CategoryResponse : BaseResponse<Category>
{
    public CategoryResponse(string message) : base(message)
    {
    }

    public CategoryResponse(Category resource) : base(resource)
    {
    }
}