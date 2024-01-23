// Cassidy Hardisty Section 001

using RollDice;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        decimal numRolls = 0;

        // Loop to make sure user inputs valid number
        while (!Decimal.TryParse(Console.ReadLine(), out numRolls))
        {
            Console.WriteLine("Enter a valid positive number.");
        }

        // Creates two instances of Dice
        DiceRolls dice = new DiceRolls((int)numRolls);
        int[] rolls = new int[(int)numRolls];
        rolls = dice.getRollResults();

        // Holds number of times a number is rolled by the two dice
        Dictionary<int, int> numberCombos = new Dictionary<int, int>();

        // Loop to roll the two dice the amount of times the user enters
        for (int i = 0; i < rolls.Length; i++)
        {
           
            // Adds result to dictionary to keep count of how many times that number has been rolled
            // The sum of the two dice is the key in the dictionary, the count of times is the value
            if (numberCombos.ContainsKey(rolls[i]))
            {
                numberCombos[rolls[i]]++;
            }
            else
            {
                numberCombos.Add(rolls[i], 1);
            }
        }

        // Makes dictionary to hold the percentage of each roll
        var percentDict = AnalyzeDice.getPercentages(numberCombos, numRolls);

        // Makes dictionary to hold star string for histogram rows
        var histogramRows = AnalyzeDice.createHistogram(percentDict);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numRolls}.");
        Console.WriteLine("\n");

        // Goes through each key value pair in histogram and outputs it into a row of the graph
        foreach (var item in histogramRows)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
        return;
    }
}