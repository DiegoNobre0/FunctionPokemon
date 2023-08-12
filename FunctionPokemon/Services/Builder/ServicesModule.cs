using FunctionPokemon.Services.Code;
using FunctionPokemon.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPokemon.Services.Builder
{
    public static class ServicesModule
    {
        public static IServiceCollection RegisterServicesModule(this IServiceCollection services)
        {
            services.AddScoped<IPokemonService, PokemonService>();

            return services;
        }
    }
}
