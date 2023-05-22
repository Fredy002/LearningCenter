using AutoMapper;
using LarningCenter.API.Learning.Domain.Model;
using LarningCenter.API.Learning.Resource;

namespace LarningCenter.API.Learning.Mapping;

public class ModelToResourceProfile : Profile
{
    protected ModelToResourceProfile()
    {
        CreateMap<Category, CategoryResource>();
        CreateMap<Tutorial, TutorialResource>();
    }
}