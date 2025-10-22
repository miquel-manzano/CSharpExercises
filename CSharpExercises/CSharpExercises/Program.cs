internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a value to check if it's within the interval (5, 50):");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 5 && number < 50)
                Console.WriteLine($"{number} is within the interval (5, 50).");
            else
                Console.WriteLine($"{number} is NOT within the interval (5, 50).");
        }
    }
}