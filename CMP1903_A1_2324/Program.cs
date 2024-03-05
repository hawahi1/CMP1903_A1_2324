using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        // Running the game
        static void Main(string[] args)
        {
            
            // Creating the game object and running the game

            Game game = new Game();     // Creates the game object
            int[] dies = game.dieRolls();   // Calls on the dieRolls function to rolls the die, storing them in the dies array
            game.diePrint(dies);        // Calls on the diePrint function to print the results

            // Creating the testing object to test the outputs.

            Testing testing = new Testing();    // Creates a testing object from our testing class
            testing.Test();     // Runs the testing object

        }
    }
}
