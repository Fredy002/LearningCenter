using LarningCenter.API.Learning.Domain.Model;
using LarningCenter.API.Shared.Domain.Services.Comunication;

namespace LarningCenter.API.Learning.Domain.Services.Comunication;

public class CategoryResponse : BaseResponse<Category>
{
    public CategoryResponse(string message) : base(message)
    {
    }

    public CategoryResponse(Category resource) : base(resource)
    {
    }
}