using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RollDice
{
    internal class DiceRolls
    {
        private int totalRolls;
        private int[] rolls;

        public DiceRolls(int numRolls) {
            this.totalRolls = numRolls;
            this.rolls = new int[numRolls];

        }

        // Assigns random roll to a die
        private int roll()
        {
            Random rnd = new Random();
            int num = rnd.Next(1, 7);
            return num;
        }

        public int[] getRollResults()
        {

            for (int i = 0; i < totalRolls; i++)
            {
                // Rolls the dice
                int result1 = roll();
                int result2 = roll();

                int combo = result1 + result2;
                rolls[i] = combo;
            }

            return rolls;
        }
    }
}
