
using System.Collections.Generic;
using System.Security.Claims;

namespace TokenAuthentication.Service
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public ClaimsIdentity CreateClaimsIdentity()
        {
            var claims = new List<Claim>
                {
                    new Claim("UserName", "lvbokhorst"),
                    new Claim(ClaimTypes.Name, "Leon van Bokhorst"),
                    new Claim(ClaimTypes.Email, "leonvanbokhorst@ilovehadoop.org"),
                    new Claim(ClaimTypes.Role, "nerds"),
                    new Claim("http://remondo.claims/room", "mancave")
                };

            return new ClaimsIdentity( claims, "Basic", "UserName", ClaimTypes.Role);
        }
    }
}
