// Creator: Ryder Held
// Date: 2/2/2025
namespace RepairingTheClocktower
{
    public class ProgramTOT
    {
        public static void Main(string[] args)
        {
            // Inputs numbers
            TickOrTock number1 = new TickOrTock(8);
            TickOrTock number2 = new TickOrTock(51);
            TickOrTock number3 = new TickOrTock(1000000000);

            List<TickOrTock> numberList = new List<TickOrTock>();
            numberList.Add(number1);
            numberList.Add(number2);
            numberList.Add(number3);

            // Produces correct output through loop
            foreach (TickOrTock Number in numberList)
            {
                Console.WriteLine(Number.EvenTickOddTock());
            }
        }
    }
}
