using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {

        //Property

        int dieValue = 0;

        //Method
        static Random random = new Random();
        int dieRoll = random.Next(1, 7);

    }
}
