using System;
using System.Collections.Generic;
using System.Text;

namespace PokeFarm
{
    public class Arcanine : Pokemon
    {
        public override string pokemon { get; } = "Arcanine";
        public static Random randomGender = new Random();
        static int GenderValue = 2;
        public Arcanine()
        {
            this.gender = randomGender.Next(GenderValue);
            this.ability = "Flash Fire";
            this.nature = "Fire";
        }
        public override void Speak()
        {
            Console.WriteLine("n\tROOOOOOOOOOOOOOOAAAAAAAAAARRRRRRR!!!!");
        }
        public override void Sleep()
        {
            Console.WriteLine($"\tYour {this.pokemonName} is tired, and goes to sleep");
        }
    }
}
