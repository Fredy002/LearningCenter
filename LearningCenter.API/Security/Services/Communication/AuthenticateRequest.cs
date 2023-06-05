using System.ComponentModel.DataAnnotations;

namespace LearningCenter.API.Security.Services.Communication;

public class AuthenticateRequest
{
    [Required]
    public string UserName { get; set; }

    [Required] 
    public string Password { get; set; }
}