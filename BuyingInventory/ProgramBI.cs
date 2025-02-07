// Creator: Ryder Held
// Date: 2/5/2025
namespace BuyingInventory
{
    public class ProgramBI
    {
        public static void Main(string[] args)
        {
            StoreMenu storeMenu = new StoreMenu();
            Console.WriteLine(storeMenu.ToString());

            // The following code moves the cursor to the end of line 8
            // There is likely a better way to do this, but I could not
            //                                                      figure out stay on the same line after return
            Console.SetCursorPosition(45, 8);

            Console.WriteLine(storeMenu.UserResponse());
        }
    }
}
