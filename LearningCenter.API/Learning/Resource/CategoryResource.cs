using Swashbuckle.AspNetCore.Annotations;

namespace LearningCenter.API.Learning.Resource;

public class CategoryResource
{
    [SwaggerSchema("Category Identifier")]
    public int Id { get; set; }
    [SwaggerSchema("Category Name")]
    public string Title { get; set; }
}