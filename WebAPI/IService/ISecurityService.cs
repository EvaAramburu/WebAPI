namespace WebAPI.IService
{
    public interface ISecurityService
    {
        bool ValidateUserCredentials(string userName, string Password);
    }
}

