using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game

    // Creating Die Objects
    {
        Die dieOne = new Die();
        Die dieTwo = new Die();
        Die dieThree = new Die(); // Creating 3 die objects from the Die class in order to call their functions

        // Rolling the Die

        public int[] dieRolls()
        {
            int rollOne = dieOne.dieRoll();
            int rollTwo = dieTwo.dieRoll();
            int rollThree = dieThree.dieRoll();
            return new int[] { rollOne, rollTwo, rollThree };
        }

        // Calculating the sum of the die

        public int DieSum()
        {
            return dieRolls().Sum();
        }

        // Printing the die values and the sum of the die

        public void diePrint()
        {
            Console.WriteLine($"Die number one is: ");
            Console.WriteLine($"Die number two is: ");
            Console.WriteLine($"Die number three is: ");
            Console.WriteLine($"The sum is: ");
        }
    }
}