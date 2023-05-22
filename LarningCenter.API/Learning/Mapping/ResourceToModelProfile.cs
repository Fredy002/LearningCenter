using AutoMapper;
using LarningCenter.API.Learning.Domain.Model;
using LarningCenter.API.Learning.Resource;

namespace LarningCenter.API.Learning.Mapping;

public class ResourceToModelProfile : Profile
{
    protected ResourceToModelProfile()
    {
        CreateMap<CategoryResource, Category>();
        CreateMap<TutorialResource, Tutorial>();
    }
}