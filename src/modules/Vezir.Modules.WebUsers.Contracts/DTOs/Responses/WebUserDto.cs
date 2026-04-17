namespace Kontrol.Modules.WebUsers.Contracts.DTOs.Responses;

/// <summary>
/// Web user list item DTO (for list views).
/// </summary>
public record WebUserDto
{
    public Guid Id { get; init; }
    public string Email { get; init; } = string.Empty;
    public string FullName { get; init; } = string.Empty;
    public string? Phone { get; init; }
    public string? City { get; init; }
    public bool EmailVerified { get; init; }
    public int LoyaltyPoints { get; init; }
    public bool MarketingConsent { get; init; }
    public DateTime? LastLoginAt { get; init; }
    public DateTime CreatedAt { get; init; }
}
