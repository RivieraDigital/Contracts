namespace Vezir.Modules.WebUsers.Contracts.DTOs.Responses;

/// <summary>
/// Web user detail DTO (for single user view with full details).
/// </summary>
public record WebUserDetailDto : WebUserDto
{
    public string? DefaultAddress { get; init; }
    public string? DefaultCity { get; init; }
    public string? DefaultPostalCode { get; init; }
    public string? DefaultCountry { get; init; }
    public DateTime? UpdatedAt { get; init; }
    public int OrderCount { get; init; }
    public decimal TotalSpent { get; init; }
}
