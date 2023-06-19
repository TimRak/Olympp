using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Real_Estate_Broker.Application.Interfaces;
using Real_Estate_Broker.Application.Services;
using Real_Estate_Broker.Domain.Interfaces;
using Real_Estate_Broker.Infrastructure.DBContexts;
using Real_Estate_Broker.Infrastructure.Repositories;

namespace Real_Estate_Broker.Services
{
    public static class ServiceBinder
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IPropertyRepository, PropertyRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITransactionRepository, TransactionRepository>();

            services.AddScoped<IPropertyService, PropertyService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITransactionService, TransactionService>();

            return services;
        }
    }
}
