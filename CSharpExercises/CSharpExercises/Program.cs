internal class Program
{
    private static void Main(string[] args)
    {
        const int MAX_ATTEMPTS = 3;
        int attempts = 1;
        bool isValid = false;
        int number = 0;

        while (attempts <= MAX_ATTEMPTS && !isValid)
        {
            Console.WriteLine($"Attempt {attempts} of {MAX_ATTEMPTS}");
            Console.WriteLine("Enter an integer number within the interval (2, 30):");
            if (int.TryParse(Console.ReadLine(), out number) && number > 2 && number < 30)
            {
                isValid = true;
            }
            else
            {
                Console.WriteLine("Error: The number is not within the interval (2, 30).");
                attempts++;
            }
        }

        if (isValid)
            Console.WriteLine($"Valid number entered: {number}");
        else
            Console.WriteLine("You have lost. No valid number entered.");
    }
}