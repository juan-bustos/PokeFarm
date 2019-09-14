using System;
using System.Collections.Generic;
using System.Text;

namespace PokeFarm
{
    public class UserSelection
    {
        public static string GetUserString ()
        {
            string userInput = Console.ReadLine();
            return userInput.ToLower();
        }
        public static int GetUserInt ()
        {
            int userInput = validEntry(Console.ReadLine());
            return userInput;
        }
        public static int validEntry (string validInput)
        {
            string userInput;
            int userInt;
            bool tryAgain = false;
            do
            {
                tryAgain = int.TryParse(validInput, out userInt);
                if (!tryAgain || userInt < 0)
                {
                    Console.WriteLine("\n\tInvalid Input. Enter a Number: ");
                    userInput = Console.ReadLine();
                    tryAgain = int.TryParse(validInput, out userInt);
                }
            } while (!tryAgain);
            return userInt;
        }
    }
    class MenuSelection
    {
        public static int Menu()
        {
            int selection = 0;
            Console.WriteLine("\n  Select a Pokemon to create");
            Console.WriteLine("  1. Arcanine");
            Console.WriteLine("  2. Charmander");
            Console.WriteLine("  3. Greninja");
            Console.WriteLine("  4. Eevee");
            Console.WriteLine("  5. Quit");
            Console.Write("  Enter selection: ");
            selection = UserSelection.GetUserInt();
            if (selection == 5)
            {
                Environment.Exit(0);
            }
            return selection;
        }
    }
}
