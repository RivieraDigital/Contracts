using System.ComponentModel.DataAnnotations;

namespace Vezir.Modules.WebUsers.Contracts.DTOs.Requests;

/// <summary>
/// Request model for searching/filtering web users.
/// Automatically bound from query string parameters.
/// </summary>
public class SearchWebUsersRequest
{
    /// <summary>
    /// Search term (searches in Email, FullName, Phone)
    /// </summary>
    public string? Search { get; set; }
    
    /// <summary>
    /// Filter by email verification status
    /// </summary>
    public bool? EmailVerified { get; set; }
    
    /// <summary>
    /// Filter by marketing consent
    /// </summary>
    public bool? MarketingConsent { get; set; }
    
    /// <summary>
    /// Sort field (name_asc, name_desc, email_asc, email_desc, newest, last_login)
    /// </summary>
    public string? SortBy { get; set; }
    
    /// <summary>
    /// Page number (1-based)
    /// </summary>
    public int Page { get; set; } = 1;
    
    /// <summary>
    /// Page size
    /// </summary>
    public int PageSize { get; set; } = 20;
}
