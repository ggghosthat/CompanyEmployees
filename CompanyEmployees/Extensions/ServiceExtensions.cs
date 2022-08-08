using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using LoggerService;
using Contracts;

namespace CompanyEmployees.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("Cors Policy", builder => 
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {
                options.AutomaticAuthentication = true;
                options.AuthenticationDisplayName = "Ollarius";
            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services) 
        {
            services.AddScoped<ILoggerManager, LoggerManager>();
        }
    }
}
