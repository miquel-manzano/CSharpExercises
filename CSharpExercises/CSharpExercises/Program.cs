internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a value to check if it's a natural number:");
        if (int.TryParse(Console.ReadLine(), out int value))
        {
            bool isNatural = value >= 0;
            if (isNatural)
                Console.WriteLine($"{value} is a natural number.");
            else
                Console.WriteLine($"{value} is NOT a natural number.");
        }
    }
}