using System;
using System.Collections.Generic;
using System.Text;

namespace PokeFarm
{
    public class Greninja : Pokemon
    {
        public override string pokemon { get; } = "Greninja";
        public static Random randomGender = new Random();
        static int GenderValue = 2;
        public Greninja()
        {
            this.gender = randomGender.Next(GenderValue);
            this.ability = "Protean";
            this.nature = "Water/Dark";
        }
        public override void Speak()
        {
            Console.WriteLine("n\tBluuublublublbulblub");
        }
        public override void Sleep()
        {
            Console.WriteLine($"\tYour {this.pokemonName} is tired, and goes to sleep");
        }
    }
}
