using Microsoft.Extensions.Configuration;
using AutoMapper;
namespace HelpStockApp.Infra.IoC
{
    public static class DependencyInjectionAPI
    {
        public static ISrviceCollection AddInfraestruturaAPI(this.IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<>
        }
    }
}