// Creator: Ryder Held
// Date: 2/5/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrototype
{
    public class HigherOrLower
    {
        // Methods
        public override string ToString()
        {
            Console.Write("Pilot, enter a number between 1 and 100: ");
            string pilotChoice = Console.ReadLine();
            int pilotNumber = Convert.ToInt32(pilotChoice);
            Console.Clear();
            Console.Write("Hunter, guess the number: ");
            string hunterChoice = Console.ReadLine();
            int hunterGuess = Convert.ToInt32(hunterChoice);
            while (hunterGuess != pilotNumber)
            {
                if (hunterGuess > pilotNumber)
                {
                    Console.WriteLine($"{hunterGuess} is to high.");
                    Console.Write("What is your next guess? ");
                    hunterChoice = Console.ReadLine();
                    hunterGuess = Convert.ToInt32(hunterChoice);
                }
                if (hunterGuess < pilotNumber)
                {
                    Console.WriteLine($"{hunterGuess} is to low.");
                    Console.Write("What is your next guess? ");
                    hunterChoice = Console.ReadLine();
                    hunterGuess = Convert.ToInt32(hunterChoice);
                }
            }
            return "You guessed the number!";
        }
    }
}
