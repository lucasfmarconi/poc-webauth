using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace POC.WebAuth.Authentication.Data
{
    internal class AuthenticationDbContext : IdentityDbContext
    {
        public AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
            : base(options)
        {
        }
    }
}
