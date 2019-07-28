using System;

namespace PokeFarm
{
    class DayCare
    {
        static void FirePit ()
        {
            Charmander blaze = new Charmander("Blaze");
            blaze.type = "Fire";
            blaze.hiddenAbility = "Solar Power";
            blaze.color = "Red";
            Console.WriteLine($"{blaze.name} is a Charmander and has the" +
                $" { blaze.hiddenAbility} hidden ability. He is a {blaze.type} " +
                $"type, and is a {blaze.color} color.");

            Charmander zippo = new Charmander("Zippo");
            zippo.type = "Fire";
            zippo.move = "Ember";
            zippo.color = "Orange";
            Console.WriteLine($"{zippo.name} is a Charmander and has the" +
            $" { zippo.move} ability. He is a {zippo.type} " +
             $"type, and is a {zippo.color} color.");

            Charmander red = new Charmander("Red");
            red.type = "Fire";
            red.move = "Smokescreen";
            red.color = "Red";
            Console.WriteLine($"{red.name} is a Charmander and has the" +
            $" { red.move} ability. He is a {red.type} " +
             $"type, and is a {red.color} color. ");

            Charmander droggo = new Charmander("Droggo");
            droggo.type = "Fire/Dragon";
            droggo.move = "Fire Blitz";
            droggo.color = "Shiny Orange";
            Console.WriteLine($"{droggo.name} is a rare Charmander and knows the" +
                $" {droggo.move} move. He is a {droggo.color} color.");

            Arcanine arcane = new Arcanine("Arcane");
            arcane.type = "Fire";
            arcane.move = "Fire Fang";
            arcane.color = "Orange/Black";
            Console.WriteLine($"{arcane.name} is a Arcanine and knows the" +
                $" {arcane.move} move. He is a {arcane.color} color.");
        }
        static void Main(string[] args)
        {
            FirePit();
            Console.ReadLine();
        }
    }
}
