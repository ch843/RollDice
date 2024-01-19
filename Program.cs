using RollDice;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.WriteLine("How many dice rolls would you like to simulate?");
        decimal numRolls = 0;

        while (!Decimal.TryParse(System.Console.ReadLine(), out numRolls))
        {
            System.Console.WriteLine("Enter a valid positive number.");
        }
        
        Dice dice1 = new Dice();
        Dice dice2 = new Dice();
        Dictionary<int, int> numberCombos = new Dictionary<int, int>();

        for (int i = 0; i < numRolls; i++)
        {
            int result1 = dice1.roll();
            int result2 = dice2.roll();

            int combo = result1 + result2;
            if (numberCombos.ContainsKey(combo))
            {
                numberCombos[combo]++;
            }
            else
            {
                numberCombos.Add(combo, 1);
            }
        }

        var percentDict = AnalyzeDice.getPercentages(numberCombos, numRolls);
        var histogramRows = AnalyzeDice.createHistogram(percentDict);

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls.");
        System.Console.WriteLine("Total number of rolls = 1000.");
        System.Console.WriteLine("\n");

        foreach (var item in histogramRows)
        {
            System.Console.WriteLine($"{item.Key}: {item.Value}");
        }
        return;
    }
}