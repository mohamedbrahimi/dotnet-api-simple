using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace webapi_try.Models;

public class User
{
    public int Id { get; set; }
    
    [EmailAddress]
    [Required]
    public string Email { get; set; }
    public string Password { get; set; }
    
    [MaxLength(200)]
    [MinLength(2)]
    public string FirstName { get; set; }
    [MaxLength(200)]
    [MinLength(2)]
    public string LastName { get; set; }
    public DateTime CreatedAt { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    public DateTime LastLogin { get; set; }
    public DateTime LastRequest { get; set; }
    
    
}