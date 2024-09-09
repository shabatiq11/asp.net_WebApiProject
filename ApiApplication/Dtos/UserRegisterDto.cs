using System.ComponentModel.DataAnnotations;

namespace ApiApplication.Dtos;
public class UserRegisterDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}
