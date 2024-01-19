using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDice
{
    internal class AnalyzeDice
    {
        public static Dictionary<int, decimal> getPercentages(Dictionary<int, int> numberCombos, decimal totalRolls)
        {
            Dictionary<int, decimal> percentValues = new Dictionary<int, decimal>();
            foreach (var item in numberCombos)
            {
                percentValues.Add(item.Key, findPercentage(item.Value, totalRolls));
            }

            return percentValues;
        }

        private static decimal findPercentage(int numCombos, decimal totalRolls)
        {
            return numCombos / totalRolls * 100;
        }

        public static SortedDictionary<int, string> createHistogram(Dictionary<int, decimal> percentValues)
        {
            SortedDictionary<int, string> rows = new SortedDictionary<int, string>();

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
