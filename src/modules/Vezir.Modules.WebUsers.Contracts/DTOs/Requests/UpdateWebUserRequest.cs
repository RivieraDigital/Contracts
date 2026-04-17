namespace Kontrol.Modules.WebUsers.Contracts.DTOs.Requests;

/// <summary>
/// Request model for updating an existing web user.
/// </summary>
public class UpdateWebUserRequest
{
    public string Email { get; init; } = string.Empty;
    public string FullName { get; init; } = string.Empty;
    public string? Phone { get; init; }
    public string? DefaultAddress { get; init; }
    public string? DefaultCity { get; init; }
    public string? DefaultPostalCode { get; init; }
    public string? DefaultCountry { get; init; }
    public bool EmailVerified { get; init; }
    public bool MarketingConsent { get; init; }
    public string? NewPassword { get; init; }
}
