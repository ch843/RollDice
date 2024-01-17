using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        string numRolls = "";

        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        numRolls = System.Console.ReadLine("How many dice rolls would you like to simulate?");

        System.Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        System.Console.WriteLine("Each \"*\" represents 1 % of the total number of rolls.");
        System.Console.WriteLine(" Total number of rolls = 1000.");

    }
}