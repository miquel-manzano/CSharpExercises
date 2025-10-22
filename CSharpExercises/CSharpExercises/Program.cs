internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a natural number (maximum 7 digits, max 9999999):");
        if (int.TryParse(Console.ReadLine(), out int decimalNumber))
        {
            if (decimalNumber < 0)
            {
                Console.WriteLine("Error: You must enter a natural number.");
                return;
            }

            if (decimalNumber > 9999999)
            {
                Console.WriteLine("Error: You must enter a number with a maximum of 7 digits.");
                return;
            }

            string binary = Convert.ToString(decimalNumber, 2);
            Console.WriteLine($"{decimalNumber} in binary is equal to: {binary}");
        }
    }
}