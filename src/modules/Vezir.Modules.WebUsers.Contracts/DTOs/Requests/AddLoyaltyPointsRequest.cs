namespace Vezir.Modules.WebUsers.Contracts.DTOs.Requests;

/// <summary>
/// Request model for adding loyalty points to a web user.
/// </summary>
public class AddLoyaltyPointsRequest
{
    public int Points { get; init; }
}
