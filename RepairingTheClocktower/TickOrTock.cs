// Creator: Ryder Held
// Date: 2/2/2025
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheClocktower
{
    public class TickOrTock
    {
        // Variables
        private int number = -99999;

        // Gets and sets
        public int Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        // Constructors
        public TickOrTock()
        {
            // Empty Constructor
        }

        public TickOrTock(int aNumber)
        {
            // Full Constructor
            this.Number = aNumber;
        }

        // Methods
        public string EvenTickOddTock()
        {
            string tick = "Tick";
            string tock = "Tock";
            if (this.Number % 2 == 0)
            {
                return tick;
            }
            
            else
            {
                return tock;
            }
        }
    }
}
