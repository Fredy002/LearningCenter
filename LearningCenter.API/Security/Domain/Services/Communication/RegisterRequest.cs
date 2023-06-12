using System.ComponentModel.DataAnnotations;

namespace LearningCenter.API.Security.Services.Communication;

public class RegisterRequest
{
    [Required]
    public string FirstName { get; set; }
    
    [Required]
    public string LastName { get; set; }
    
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }
}