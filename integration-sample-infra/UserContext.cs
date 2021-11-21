using integration_sample_domains.Entities.Users;
using System.Collections.Generic;

namespace integration_sample_infra
{
    public class UserContext
    {
        public static List<User> GetUser()
        {
            return new List<User> {
                new User { UserName = "admin", Password = "admin", Role="Administrator" }
            };
        }
    }
}