using Vezir.Modules.WebUsers.Contracts.DTOs.Requests;
using Vezir.Modules.WebUsers.Contracts.DTOs.Responses;
using Vezir.Shared.Contracts.Results;

namespace Vezir.Modules.WebUsers.Contracts.Services;

/// <summary>
/// Service interface for managing web users.
/// Follows the same pattern as ICatalogService from Catalog module.
/// </summary>
public interface IWebUserService
{
    /// <summary>
    /// Get paginated and filtered list of web users.
    /// </summary>
    Task<WebUserListResponse> GetPagedAsync(SearchWebUsersRequest request);
    
    /// <summary>
    /// Get a single web user by ID with full details.
    /// </summary>
    Task<WebUserDetailDto?> GetByIdAsync(Guid id);
    
    /// <summary>
    /// Create a new web user.
    /// </summary>
    Task<OperationResult<Guid>> CreateAsync(CreateWebUserRequest request);
    
    /// <summary>
    /// Update an existing web user.
    /// </summary>
    Task<OperationResult> UpdateAsync(Guid id, UpdateWebUserRequest request);
    
    /// <summary>
    /// Delete a web user.
    /// </summary>
    Task<OperationResult> DeleteAsync(Guid id);
    
    /// <summary>
    /// Add loyalty points to a web user.
    /// </summary>
    Task<OperationResult<int>> AddLoyaltyPointsAsync(Guid id, AddLoyaltyPointsRequest request);
    
    /// <summary>
    /// Register a new customer from WebShop. Creates entry in webusers table.
    /// </summary>
    Task<OperationResult<CustomerDto>> RegisterCustomerAsync(CustomerRegisterRequest request);
    
    /// <summary>
    /// Validate customer credentials for WebShop login.
    /// Returns customer data if credentials are valid, null otherwise.
    /// </summary>
    Task<CustomerDto?> ValidateCustomerAsync(string email, string password);
}
