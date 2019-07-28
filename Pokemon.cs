using System;
using System.Collections.Generic;
using System.Text;

namespace PokeFarm
{
    public abstract class Pokemon
    {
        protected static Random randomPokemon = new Random();
        public string pokemonName { get; set; }
        public virtual string pokemon { get;}
        public int gender;
        public string ability;
        public string nature;
        // Pokemon Speaks when you encounter it. 
        public virtual void Speak()
        {
            Console.WriteLine("*Pokemon Noise*");
        }
        // Pokemon goes to sleep after being up for a while. 
        public virtual void Sleep()
        {
            Console.WriteLine(" *Pokemon is tired, and goes to sleep* ");
        }
        // A basic list of abilities a pokemon will do.
        public void Ability()
        {
            if (randomPokemon.NextDouble() < .34)
            {
                Console.WriteLine($"\t{this.pokemonName} uses Tackle!!");
            }
            else if (randomPokemon.NextDouble() > .66)
            {
                Console.WriteLine($"\t{this.pokemonName} tries to run away!");
            }
            else
            {
                Console.WriteLine($"\t{this.pokemonName} uses their special ability" +
                    $"{this.ability}");
            }
        }
    }


}
