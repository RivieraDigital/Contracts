namespace Kontrol.Modules.WebUsers.Contracts.DTOs.Requests;

/// <summary>
/// Customer login request for WebShop.
/// </summary>
public class CustomerLoginRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

/// <summary>
/// Customer registration request for WebShop.
/// </summary>
public class CustomerRegisterRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? Phone { get; set; }
}
