namespace Vezir.Modules.WebUsers.Contracts.DTOs.Responses;

/// <summary>
/// Paginated list response for web users.
/// </summary>
public record WebUserListResponse
{
    public List<WebUserDto> Users { get; init; } = new();
    public int TotalCount { get; init; }
    public int Page { get; init; }
    public int PageSize { get; init; }
}
