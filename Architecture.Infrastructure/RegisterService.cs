using Architecture.Application.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Architecture.Infrastructure
{
    public static class RegisterService
    {
        public static void ConfigureInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), x => x.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName));
            });
            services.AddScoped<IAppDbContext>(option => option.GetService<AppDbContext>());
        }
    }
}
