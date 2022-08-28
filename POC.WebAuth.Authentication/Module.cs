using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using POC.WebAuth.Authentication.Data;
using System;

namespace POC.WebAuth.Authentication
{
    public static class Module
    {
        public static void AddAuthenticationMembers(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection") ??
                                   throw new InvalidOperationException(
                                       "Connection string 'DefaultConnection' not found.");

            services.AddDbContext<AuthenticationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddEntityFrameworkStores<AuthenticationDbContext>();
        }

    }
}