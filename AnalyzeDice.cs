using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDice
{
    // This class is a helper function class, so it does not contain a constructor but
    // has functions that I access in Program.cs
    internal class AnalyzeDice
    {
        public static Dictionary<int, decimal> getPercentages(Dictionary<int, int> numberCombos, decimal totalRolls)
        {
            // Stores percentage of total rolls for each key in percentValues dict
            Dictionary<int, decimal> percentValues = new Dictionary<int, decimal>();
            foreach (var item in numberCombos)
            {
                // Calls function to find percentage and adds the key and value to dict
                // For every key value pair in numberCombos dict
                percentValues.Add(item.Key, findPercentage(item.Value, totalRolls));
            }

            return percentValues;
        }

        private static decimal findPercentage(int numCombos, decimal totalRolls)
        {
            // Calculates percentage of total
            return numCombos / totalRolls * 100;
        }

        public static SortedDictionary<int, string> createHistogram(Dictionary<int, decimal> percentValues)
        {
            SortedDictionary<int, string> rows = new SortedDictionary<int, string>();

            // Goes through each key value pair in dictionary and creates asterisk string for histogram
            // For every 1% that the percent is, it gets a asterisk
            foreach (var item in percentValues)
            {
                StringBuilder stars = new StringBuilder();
                for (int i = 0; i < item.Value; i++) {
                    stars.Append("*");
                }

                rows.Add(item.Key, stars.ToString());
            }

            return rows;
        }

    }

}
