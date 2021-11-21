using integration_sample_domains.Contracts.Application;
using integration_sample_domains.Contracts.DomainServices;
using integration_sample_domains.Entities.Users;

namespace integration_sample_application
{
    public class UserApplication : IUserApplication
    {
        private readonly IUserDomainService userDomainService;
        public UserApplication(IUserDomainService _userDomainService)
        {
            this.userDomainService = _userDomainService;
        }

        public UserToken GetUserAndToken(string userName, string password)
        {
            return this.userDomainService.GetUserAndToken(userName, password);
        }
    }
}