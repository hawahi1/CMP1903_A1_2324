using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method

        public void Test()
        {
            // Testing that the die rolls are the same, and that there are no conflicting values in the sums.
            Game game = new Game();
            int[] dies = game.dieRolls();
            int functionSum = game.DieSum(dies);
            int testSum = dies[0] + dies[1] + dies[2];
            Debug.Assert(condition: functionSum == testSum, message: "The sums don't match!");

            // Testing that the die rolls keeps the generated numbers within their own parameters.
            Die die = new Die();
            int testRolls = die.dieRoll();
            Debug.Assert(condition: testRolls >= 1 & testRolls <= 6, message: "The number is outside of the set parameters!");
            
            
        }

    }
}
