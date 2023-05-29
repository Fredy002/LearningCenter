using AutoMapper;
using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Learning.Resource;

namespace LearningCenter.API.Learning.Mapping;

public class ResourceToModelProfile : Profile
{
    protected ResourceToModelProfile()
    {
        CreateMap<CategoryResource, Category>();
        CreateMap<TutorialResource, Tutorial>();
    }
}