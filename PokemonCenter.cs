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
            int pokemonCreator = MenuSelection.Menu();

            if (pokemonCreator == 1)
            {
                myArcanine.Add(new Arcanine());
                Console.Write($"\tEnter Arcanine's name:  ");
                myArcanine[arcanineCount].pokemonName = UserSelection.GetUserString();
            }
            if (pokemonCreator == 2)
            {
                myCharmander.Add(new Charmander());
                Console.Write($"\tEnter Charmander's name:  ");
                myCharmander[charmanderCount].pokemonName = UserSelection.GetUserString();
            }
            if (pokemonCreator == 3)
            {
                myGreninja.Add(new Greninja());
                Console.Write($"\tEnter Greninja's name:  ");
                myGreninja[greninjaCount].pokemonName = UserSelection.GetUserString();
            }
            if (pokemonCreator == 4)
            {
                myEevee.Add(new Eevee());
                Console.Write($"\tEnter Eevee's name:  ");
                myEevee[eeveeCount].pokemonName = UserSelection.GetUserString();
            }

        }
        public List<Pokemon> selectPokemonType()
        {
            int pokemonCompanion = MenuSelection.Menu();
            SelectPokemonToCreate:
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
            else if (pokemonCompanion == 4)
            {
                return myEevee;
            }
            else
            {
                Console.WriteLine("You have input the wrong value. Please select a valid entry!");
                goto SelectPokemonToCreate;
            }
        }
        public string createPokemonName (string pokemonName = "")
        {
            Console.Write("Enter your Pokemon's name here:   ");
            pokemonName = UserSelection.GetUserString();

            return pokemonName;
        }
    }
}
