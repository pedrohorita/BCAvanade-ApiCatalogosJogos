using ApiCatalogoJogos.Repositories;
using ApiCatalogoJogos.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ApiCatalogoJogos.Configuration
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IJogoService, JogoService>();
            services.AddScoped<IJogoRepository, JogoSqlServerRepository>();
        }
    }
}
