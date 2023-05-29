using AutoMapper;
using LearningCenter.API.Learning.Domain.Model;
using LearningCenter.API.Learning.Resource;

namespace LearningCenter.API.Learning.Mapping;

public class ModelToResourceProfile : Profile
{
    protected ModelToResourceProfile()
    {
        CreateMap<Category, CategoryResource>();
        CreateMap<Tutorial, TutorialResource>();
    }
}