using System;
using System.Collections.Generic;
using System.Text;

namespace PokeFarm
{
    public class Charmander : Pokemon
    {
        public override string pokemon { get; } = "Charmander";
        public static Random randomGender = new Random();
        static int GenderValue = 2;
        public Charmander()
        {
            this.gender = randomGender.Next(GenderValue);
            this.ability = "Blaze";
            this.nature = "Fire";
        }
        public override void Speak()
        {
            Console.WriteLine("n\tROOOOOOOAAARRRRR!");
        }
        public override void Sleep()
        {
            Console.WriteLine($"\tYour {this.pokemonName} is tired, and goes to sleep");
        }

    }

}
