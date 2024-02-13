using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {

        //Property

        int dieValue;
        Random rnd = new Random();

        //Method

        public static void main(Random rnd, int dieValue)
        {
            int dieRoll = rnd.Next(1, 7);
            dieValue = dieRoll;
        }

    }
    internal class Print
    {
        public static void main(int dieValue)
        {
            Console.WriteLine(dieValue);
        }
    }
}
