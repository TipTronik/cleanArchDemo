namespace Infrastructure.Contracts.Logger;

/// <summary>
/// Logger Interface
/// </summary>
public class ILogger
{
    public async Task LogDebug(string message, Exception exception = null)
    {
        //Log Debug
    }
}