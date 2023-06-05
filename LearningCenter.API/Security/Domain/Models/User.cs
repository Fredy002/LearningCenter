using System.Text.Json.Serialization;

namespace LearningCenter.API.Security.Domain.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    
    [JsonIgnore]
    public string PasswordHash { get; set; }
}