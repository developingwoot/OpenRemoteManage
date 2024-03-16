
/// <summary>
/// Launch Exception for application
/// </summary>
public class OpenRemoteManageLaunchException : Exception
{
    /// <summary>
    /// Launch Exception with no parameters
    /// </summary>
    public OpenRemoteManageLaunchException()
    {
    }

    /// <summary>
    /// Launch Exception including message that is passed to base exception
    /// </summary>
    /// <param name="message"></param>
    public OpenRemoteManageLaunchException(string? message) : base(message)
    {
    }

    /// <summary>
    /// Launch Exception including message and inner exception that are passed to base exception
    /// </summary>
    /// <param name="message"></param>
    /// <param name="innerException"></param>
    public OpenRemoteManageLaunchException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}
