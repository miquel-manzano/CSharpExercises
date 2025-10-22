internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the height of the triangle (positive integer): ");
        if (int.TryParse(Console.ReadLine(), out int height))
        {
            if (height <= 0)
            {
                Console.WriteLine("The height must be a positive integer.");
                return;
            }

            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}