using System;
using System.Collections.Generic;
using System.Text;

namespace PokeFarm
{
    public class Eevee : Pokemon
    {
        public override string pokemon { get; } = "Eevee";
        public static Random randomGender = new Random();
        static int GenderValue = 2;
        public Eevee()
        {
            this.gender = randomGender.Next(GenderValue);
            this.ability = "Anticipation";
            this.nature = "Normal";
        }
        public override void Speak()
        {
            Console.WriteLine("n\tSkkkkrrrtttt");
        }
        public override void Sleep()
        {
            Console.WriteLine($"\tYour {this.pokemonName} is tired, and goes to sleep");
        }
    }
}
