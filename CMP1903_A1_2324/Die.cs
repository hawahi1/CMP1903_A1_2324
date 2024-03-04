using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        // Property
        public int DieValue // creates a property to store the die value
        {
            set; get;
        }
        // Method
        static Random rnd = new Random(); // creates a random object which we use to generate random integers
        public int dieRoll() // creates an integer object that stores the value of the die roll
        {
            DieValue = rnd.Next(1, 7); // effectively rolls the die, using the random objet to pick a number between 1 and 6
            return DieValue; // returns and therefore stores the value of the die
        }


    }
}
