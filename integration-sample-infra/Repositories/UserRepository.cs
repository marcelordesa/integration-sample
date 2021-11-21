using integration_sample_domains.Contracts.Repositories;
using integration_sample_domains.Entities.Users;
using System.Linq;

namespace integration_sample_infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User GetUser(string userName, string password)
        {
            return UserContext.GetUser().Where(u => u.UserName.ToLower() == userName.ToLower() && u.Password == password).FirstOrDefault();
        }
    }
}