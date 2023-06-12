namespace LearningCenter.API.Security.Domain.Services.Communication;

public class UpdateRequest
{
   public string FirstName { get; set; }
   public string LastName { get; set; }
   public string UserName { get; set; }
   public string Password { get; set; }
}