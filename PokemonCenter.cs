using System;
using System.Collections.Generic;
using System.Text;

namespace PokeFarm
{
    public class PokemonCenter
    {
        int arcanineCount = 0, charmanderCount = 0, greninjaCount = 0, eeveeCount = 0;
        private List<Pokemon> myArcanine = new List<Pokemon>();
        private List<Pokemon> myCharmander = new List<Pokemon>();
        private List<Pokemon> myGreninja = new List<Pokemon>();
        private List<Pokemon> myEevee = new List<Pokemon>();

        public void CreatePokemon ()
        {
            // This lets a user select from array which Pokemon they would 
            // like to create. 
            int[] pokemonCreator = MenuSelection.Menu();

            if (pokemonCreator[0] == 1)
            {
                myArcanine.Add(new Arcanine());
                Console.Write($"\tEnter Arcanine's name:  ");
                myArcanine[arcanineCount].pokemonName = UserSelection.GetUserString();
            }
            if (pokemonCreator[0] == 2)
            {
                myArcanine.Add(new Charmander());
                Console.Write($"\tEnter Charmander's name:  ");
                myCharmander[charmanderCount].pokemonName = UserSelection.GetUserString();
            }
            if (pokemonCreator[0] == 3)
            {
                myArcanine.Add(new Greninja());
                Console.Write($"\tEnter Greninja's name:  ");
                myGreninja[greninjaCount].pokemonName = UserSelection.GetUserString();
            }
            if (pokemonCreator[0] == 4)
            {
                myEevee.Add(new Eevee());
                Console.Write($"\tEnter Eevee's name:  ");
                myEevee[eeveeCount].pokemonName = UserSelection.GetUserString();
            }

        }
        public List<Pokemon> selectPokemonType()
        {
            int pokemonCompanion = MenuSelection.SelectCompanion();

            if (pokemonCompanion == 1)
            {
                return myArcanine;
            }
            else if (pokemonCompanion == 2)
            {
                return myCharmander;
            }
            else if (pokemonCompanion == 3)
            {
                return myGreninja;
            }
                return myEevee;
        }
        public string createPokemonName (string pokemonName = "Charizard")
        {
            Console.Write("Enter your Pokemon's name here:   ");
            pokemonName = UserSelection.GetUserString();

            return pokemonName;
        }

    }
}
