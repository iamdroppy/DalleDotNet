namespace DalleDotNet;

public class AuthenticationException : ApplicationException
{
    public AuthenticationException(string message) : base("Error authenticating: " + message)
    {
    }
}