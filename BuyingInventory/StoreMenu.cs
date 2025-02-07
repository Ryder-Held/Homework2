// Creator: Ryder Held
// Date: 2/5/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingInventory
{
    public class StoreMenu
    {
        // Variables
        private int itemNumber = -1;

        // Gets and sets
        public int ItemNumber
        {
            get { return this.itemNumber; }
            set { this.itemNumber = value; }
        }

        // Methods
        public override string ToString()
        {
            string storeItems = "";
            storeItems = storeItems + "The following items are available:\n";
            storeItems = storeItems + "1 - Rope\n";
            storeItems = storeItems + "2 - Torches\n";
            storeItems = storeItems + "3 - Climbing Equipment\n";
            storeItems = storeItems + "4 - Clean Water\n";
            storeItems = storeItems + "5 - Machete\n";
            storeItems = storeItems + "6 - Canoe\n";
            storeItems = storeItems + "7 - Food Supplies\n";
            storeItems = storeItems + "What number do you want to see the price of?";
            return storeItems;
        }

        public string UserResponse()
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            string response;
            response = choice switch
            {
                1 => "A rope costs 10 gold.",
                2 => "Torches cost 15 gold.",
                3 => "Climbing equipment costs 25 gold.",
                4 => "Clean water costs 1 gold.",
                5 => "A machete costs 20 gold.",
                6 => "A canoe costs 200 gold.",
                7 => "Food supplies costs 1 gold.",
                _ => "The store does not sell ay other items"
            };
            return response;
        }
    }
}
