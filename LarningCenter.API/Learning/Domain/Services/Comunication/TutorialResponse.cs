using LarningCenter.API.Learning.Domain.Model;
using LarningCenter.API.Shared.Domain.Services.Comunication;

namespace LarningCenter.API.Learning.Domain.Services.Comunication;

public class TutorialResponse : BaseResponse<Tutorial>
{
    public TutorialResponse(string message) : base(message)
    {
    }

    public TutorialResponse(Tutorial resource) : base(resource)
    {
    }
}