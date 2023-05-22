using AutoMapper;
using LarningCenter.API.Learning.Domain.Model;
using LarningCenter.API.Learning.Domain.Services;
using LarningCenter.API.Learning.Resource;
using Microsoft.AspNetCore.Mvc;

namespace LarningCenter.API.Learning.Controllers;

public class CategoriesController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    private readonly IMapper _mapper;

    public CategoriesController(ICategoryService categoryService, IMapper mapper)
    {
        _categoryService = categoryService;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoryResource>> GetAllAsync()
    {
        var Categories = await _categoryService.ListAsync();
        var resource = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(Categories);
        return resource;
    }
}