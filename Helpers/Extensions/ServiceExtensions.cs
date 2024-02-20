using System;
using proiect_daw.Helpers.JwtUtils;
using proiect_daw.Repositories.UserRepository;
//using proiect_daw.Services;

namespace proiect_daw.Helpers.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }

        //public static IServiceCollection AddServices(this IServiceCollection services)
        //{
        //    services.AddTransient<IUserService, UserService>();

        //    return services;
        //}

        public static IServiceCollection AddHelpers(this IServiceCollection services)
        {
            services.AddTransient<IJwtUtils, JwtUtil>();

            return services;
        }
    }
}

