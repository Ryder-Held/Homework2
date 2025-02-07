// Creator: Ryder Held
// Date: 2/5/2025
namespace BuyingInventory
{
    public class ProgramDI
    {
        public static void Main(string[] args)
        {
            OldStorePlusDiscounts storeMenu = new OldStorePlusDiscounts();
            Console.WriteLine(storeMenu.ToString());

            // The following code moves the cursor to the end of line 8
            // There is likely a better way to do this, but I could not
            //                                                      figure out stay on the same line after return
            Console.SetCursorPosition(37, 8);

            Console.WriteLine(storeMenu.NameLookup());
        }
    }
}
