internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a natural number (positive integer or zero):");
        if (int.TryParse(Console.ReadLine(), out int originalNumber))
        {
            if (originalNumber < 0)
            {
                Console.WriteLine("Error: You must enter a natural number.");
                return;
            }

            int number = originalNumber;
            int counter = (number == 0) ? 1 : 0;

            while (number > 0)
            {
                number /= 10;
                counter++;
            }

            Console.WriteLine($"Number of digits of {originalNumber}: {counter}");
        }
    }
}