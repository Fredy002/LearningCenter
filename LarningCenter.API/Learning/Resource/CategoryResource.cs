namespace LarningCenter.API.Learning.Resource;

public class CategoryResource
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public CategoryResource Category { get; set; }
}