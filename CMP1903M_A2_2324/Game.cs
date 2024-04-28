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
        Die DieOne = new Die();
        Die DieTwo = new Die();
        Die DieThree = new Die(); // Creating 3 die objects from the Die class in order to call their functions

        // Rolling the Die

        public int[] DieRolls()
        {
            int RollOne = DieOne.DieRoll();
            int RollTwo = DieTwo.DieRoll();
            int RollThree = DieThree.DieRoll();
            return new int[] { RollOne, RollTwo, RollThree };
        }

        // Calculating the sum of the die

        public int DieSum(int[] num)
        {
            return num[0] + num[1] + num[2];
        }

        // Printing the die values and the sum of the die

        public void DiePrint(int[] num)
        {
            Console.WriteLine("Die number one is:" + num[0] );
            Console.WriteLine("Die number two is:" + num[1] );
            Console.WriteLine("Die number three is:" + num[2] );
            Console.WriteLine("The sum is:" + DieSum(num) );
        }
    }
}