using System;

namespace PokeFarm
{
    class DayCare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tPokeFarm.DayCare.Main()");
            PokemonCenter PokeFarm = new PokemonCenter();

            do
            {
                PokeFarm.CreatePokemon();
                Console.Write("\n Create another Pokemon? [Y/N]: ");
            } while (Console.ReadLine().ToLower()== "y");
            Console.ReadLine();
        }
    }
}
