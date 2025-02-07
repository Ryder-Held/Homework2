// Creator: Ryder Held
// Date: 2/6/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCanon
{
    public class CanonOutput
    {
        // Methods
        public override string ToString()
        {
            int round = 1;
            string magicSpell = "";
            do
            {
                if (round % 3 == 0 && round % 5 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    magicSpell = $"{round}: Fire\n";
                    Console.Write(magicSpell);
                }
                else if (round % 5 == 0 && round % 3 != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    magicSpell = $"{round}: Electric\n";
                    Console.Write(magicSpell);
                }
                else if (round % 3 == 0 && round % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    magicSpell = $"{round}: Fire & Electric\n";
                    Console.Write(magicSpell);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    magicSpell = $"{round}: Normal\n";
                    Console.Write(magicSpell);
                }
                round++;
            }
            while (round > 0 && round < 101);
            return "";
        }
    }
}
