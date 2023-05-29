namespace LearningCenter.API.Learning.Domain.Model;

public class Category
{
   public int Id { get; set; }
   public string Name { get; set; }
   
   // Relationships

   public IList<Tutorial> Tutorials { get; set; } = new List<Tutorial>();
}