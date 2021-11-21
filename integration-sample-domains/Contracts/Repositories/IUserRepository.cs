using integration_sample_domains.Entities.Users;

namespace integration_sample_domains.Contracts.Repositories
{
    public interface IUserRepository
    {
        User GetUser(string userName, string password);
    }
}