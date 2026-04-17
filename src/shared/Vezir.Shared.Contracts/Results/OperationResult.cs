namespace Kontrol.Shared.Contracts.Results;

/// <summary>
/// Represents the result of an operation without return data.
/// Universal type used across all modules.
/// </summary>
public class OperationResult
{
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; }
    public List<string> Errors { get; set; } = new();
    
    public static OperationResult Success() => new() { IsSuccess = true };
    
    public static OperationResult Failure(string error) => new() 
    { 
        IsSuccess = false, 
        ErrorMessage = error,
        Errors = new List<string> { error }
    };
    
    public static OperationResult Failure(List<string> errors) => new() 
    { 
        IsSuccess = false, 
        ErrorMessage = errors.FirstOrDefault(),
        Errors = errors
    };
}

/// <summary>
/// Represents the result of an operation with return data.
/// Universal type used across all modules.
/// </summary>
/// <typeparam name="T">Type of data returned on success</typeparam>
public class OperationResult<T>
{
    public bool IsSuccess { get; set; }
    public T? Data { get; set; }
    public string? ErrorMessage { get; set; }
    public List<string> Errors { get; set; } = new();
    
    public static OperationResult<T> Success(T data) => new() 
    { 
        IsSuccess = true, 
        Data = data 
    };
    
    public static OperationResult<T> Failure(string error) => new() 
    { 
        IsSuccess = false, 
        ErrorMessage = error,
        Errors = new List<string> { error }
    };
    
    public static OperationResult<T> Failure(List<string> errors) => new() 
    { 
        IsSuccess = false, 
        ErrorMessage = errors.FirstOrDefault(),
        Errors = errors
    };
    
    /// <summary>
    /// Converts to non-generic OperationResult (discarding data)
    /// </summary>
    public OperationResult ToNonGeneric() => new()
    {
        IsSuccess = IsSuccess,
        ErrorMessage = ErrorMessage,
        Errors = Errors
    };
}
