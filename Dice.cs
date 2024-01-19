using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDice
{
    internal class Dice
    {
        public Dice() { }

        public int roll()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 7);
            return num;
        }
    }
}
