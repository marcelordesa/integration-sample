using integration_sample_domains.Entities.Users;

namespace integration_sample_domains.Contracts.Application
{
    public interface IUserApplication
    {
        UserToken GetUserAndToken(string userName, string password);
    }
}