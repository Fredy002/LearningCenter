using AutoMapper;
using LearningCenter.API.Security.Domain.Models;
using LearningCenter.API.Security.Resources;
using LearningCenter.API.Security.Services.Communication;

namespace LearningCenter.API.Security.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<User, AuthenticateResponse>();
        CreateMap<User, UserResource>();
    }
}