using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace TokenAuthentication.Service
{
    public class TokenAuthenticationRepository : IDisposable
    {
        public TokenAuthenticationRepository()
        {
            
        }

        public async Task<IdentityResult> RegisterUser(User userModel)
        {
            return await MockResult();
        }

        public async Task<User> FindUser(string userName, string password)
        {
            return await MockUser();
        }

        public async Task<User> FindAsync(UserLoginInfo loginInfo)
        {
            return await MockUser();
        }

        public async Task<IdentityResult> CreateAsync(User user)
        {
            return await MockResult();
        }

        public async Task<IdentityResult> AddLoginAsync(string userId, UserLoginInfo login)
        {
            return await MockResult();
        }

        public async Task<Client> FindClient(string clientId)
        {
            return await MockClient();
        }

        public Task<bool> AddRefreshToken(RefreshToken token)
        {
            return Task<bool>.FromResult(true);
        }

        public Task<bool> RemoveRefreshToken(string refreshTokenId)
        {
            return Task<bool>.FromResult(true);
        }

        public Task<bool> RemoveRefreshToken(RefreshToken refreshToken)
        {
            return Task<bool>.FromResult(true);
        }

        public async Task<RefreshToken> FindRefreshToken(string refreshTokenId)
        {
            return await MockToken();
        }

        public async Task<List<RefreshToken>> GetAllRefreshTokens()
        {
            var list = new List<RefreshToken>() {await MockToken()};
            return list;
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
        }
        private Task<IdentityResult> MockResult()
        {
            return Task.FromResult(new IdentityResult());
        }

        private Task<Client> MockClient()
        {
            return
                Task<Client>.FromResult(new Client()
                {
                    Active = true,
                    AllowedOrigin = "Allow",
                    ApplicationType = ApplicationTypes.JavaScript,
                    Id = "1",
                    Name = "Bearer",
                    RefreshTokenLifeTime = 12345,
                    Secret = "rrarareertqweqweqwewqes"
                });
        }

        private string _mockToken = "rrarareertqweqweqwewqes";

        private Task<RefreshToken> MockToken()
        {
            var token = new RefreshToken()
            {
                ClientId = "1234",
                ExpiresUtc = DateTime.Now.AddDays(10.0),
                Id = "12",
                IssuedUtc = DateTime.Now.AddDays(12.0),
                ProtectedTicket = "abcdef",
                Subject = "sub"
            };
            return Task<RefreshToken>.FromResult(token);
        }

        private Task<User> MockUser()
        {
            return
                Task<User>.FromResult(new User()
                {
                    Email = "trele@lele.pl",
                    Password = "Goncarz22",
                    UserName = "Mike",
                    Id = 1
                });
        }
        // private UserManager<IdentityUser> _userManager;
    }
}
