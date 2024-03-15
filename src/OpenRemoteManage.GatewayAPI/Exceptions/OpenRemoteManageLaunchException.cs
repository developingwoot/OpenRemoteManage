
/// <summary>
/// Exception file for errors during the application launch
/// </summary>
public class OpenRemoteManageLaunchException : Exception
{
    /// <summary>
    /// Exception file for errors during the application launch
    /// </summary>
    public OpenRemoteManageLaunchException()
    {
    }

    /// <summary>
    /// Exception file for errors during the application launch
    /// With error message
    /// </summary>
    /// <param name="message"></param>
    public OpenRemoteManageLaunchException(string? message) : base(message)
    {
    }

    /// <summary>
    /// Exception file for errors during the application launch
    /// Includes string based error message and inner exception
    /// </summary>
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    public OpenRemoteManageLaunchException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}