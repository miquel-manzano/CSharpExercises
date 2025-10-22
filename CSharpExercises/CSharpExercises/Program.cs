internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("How many numbers do you want to enter? ");
        if (int.TryParse(Console.ReadLine(), out int numberQuantity))
        {
            int positiveCount = 0, negativeCount = 0, zeroCount = 0;

            for (int i = 1; i <= numberQuantity; i++)
            {
                Console.Write($"Enter number {i}/{numberQuantity}: ");
                if (int.TryParse(Console.ReadLine(), out int currentNumber))
                {
                    if (currentNumber > 0) positiveCount++;
                    else if (currentNumber < 0) negativeCount++;
                    else zeroCount++;
                }
            }

            Console.WriteLine("--- RESULT ---");
            Console.WriteLine($"Total numbers entered: {numberQuantity}");
            Console.WriteLine($"Positive numbers: {positiveCount}");
            Console.WriteLine($"Negative numbers: {negativeCount}");
            Console.WriteLine($"Zeros: {zeroCount}");
        }
    }
}