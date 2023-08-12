using FunctionPokemon.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPokemon.Services.Code
{
    public class PokemonService : IPokemonService
    {

        public PokemonService() { }

        public async Task getPokemonsMethod()
        {
            //var delay = await Task.CompletedTask();
            //await Task.Delay(delay);
            var teste = "TESTE";
            //var result = await pokemonRepository.GetAll();
            return;
           //return result;
        }

        public async Task<int> createPokemonsMethod(int seed)
        {
            var delay = new Random(seed * 2).Next(1000, 10000);
            await Task.Delay(delay);

            return delay;
        }
    }
}
