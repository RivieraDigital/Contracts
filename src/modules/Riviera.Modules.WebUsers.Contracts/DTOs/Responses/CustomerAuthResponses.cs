namespace Riviera.Modules.WebUsers.Contracts.DTOs.Responses;

/// <summary>
/// Customer login/register response for WebShop.
/// </summary>
public class CustomerLoginResponse
{
    public string Token { get; set; } = string.Empty;
    public CustomerDto Customer { get; set; } = new();
}

/// <summary>
/// Customer data for WebShop frontend.
/// </summary>
public class CustomerDto
{
    public Guid Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
    public string FullName => $"{FirstName} {LastName}".Trim();
}
