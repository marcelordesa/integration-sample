using integration_sample_domains.Contracts.DomainServices;
using integration_sample_domains.Contracts.Repositories;
using integration_sample_domains.Entities.Users;
using integration_sample_domains.Settings;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace integration_sample_domain_services
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository userRepository;
        public UserDomainService(IUserRepository _userRepository)
        {
            this.userRepository = _userRepository;
        }

        public UserToken GetUserAndToken(string userName, string password)
        {
            var user = this.userRepository.GetUser(userName, password);

            if (user == null)
                return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Setting.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName.ToString()),
                    new Claim(ClaimTypes.Role, user.Role.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new UserToken
            {
                User = new User
                {
                    UserName = user.UserName,
                    Password = string.Empty,
                    Role = user.Role
                },
                Token = tokenHandler.WriteToken(token)
            };
        }
    }
}