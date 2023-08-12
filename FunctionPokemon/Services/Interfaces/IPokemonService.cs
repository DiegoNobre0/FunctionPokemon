using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPokemon.Services.Interfaces
{
    public interface IPokemonService
    {
        Task getPokemonsMethod();
        Task<int> createPokemonsMethod(int seed);
    }
}
