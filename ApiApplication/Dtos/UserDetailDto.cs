namespace ApiApplication.Dtos;
public class UserDetailDto
{
    public string Id { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string PhoneNumberConfirmed { get; set; } = string.Empty;

    public List<UserRoleDto>? Roles { get; set; }
}
