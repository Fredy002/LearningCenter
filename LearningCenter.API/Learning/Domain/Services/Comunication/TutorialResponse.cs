using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Shared.Domain.Services.Comunication;

namespace LearningCenter.API.Learning.Domain.Services.Comunication;

public class TutorialResponse : BaseResponse<Tutorial>
{
    public TutorialResponse(string message) : base(message)
    {
    }

    public TutorialResponse(Tutorial resource) : base(resource)
    {
    }
}