// Creator: Ryder Held
// Date: 2/6/2025
using System;

namespace Replicator
{
    public class ProgramR
    {
        public static void Main(string[] args)
        {
            int[] firstArray = new int[5];

            for (int number = 0; number < 5; number++)
            {
                Console.Write("Enter a number for the array: ");
                int arrayNumber = Convert.ToInt32(Console.ReadLine());
                firstArray[number] = arrayNumber;
            }

            int[] copiedArray = new int[5];

            for (int copiedNumber = 0; copiedNumber < 5; copiedNumber++)
            {
                copiedArray[copiedNumber] = firstArray[copiedNumber];
                Console.WriteLine($"{firstArray[copiedNumber]} is copied into {copiedArray[copiedNumber]}");
            }
        }
    }
}
