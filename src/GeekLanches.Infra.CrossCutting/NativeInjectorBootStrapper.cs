using GeekLanches.Application.Interfaces;
using GeekLanches.Application.Services;
using GeekLanches.Domain.Interfaces.Repositories;
using GeekLanches.Domain.Services;
using GeekLanches.Domain.Services.Interfaces;
using GeekLanches.Infra.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace GeekLanches.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        /// <summary>
        /// Mapear e injetar no container, segundo um escopo pré-definido
        /// </summary>
        /// <param name="services"></param>
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();         

            services.AddScoped<IIngredienteDomainService, IngredienteDomainService>();
            services.AddScoped<ILancheDomainService, LancheDomainService>();
            services.AddScoped<ILancheIngredientesDomainService, LancheIngredientesDomainService>();

            services.AddScoped<IIngredienteService, IngredienteService>();
            services.AddScoped<ILancheService, LancheService>();

            services.AddScoped<IIngredienteRepository, IngredienteRepository>();
            services.AddScoped<ILancheRepository, LancheRepository>();
            services.AddScoped<ILancheIngredientesRepository, LancheIngredientesRepository>();
        }
    }
}
