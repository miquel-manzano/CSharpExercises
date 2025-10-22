internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the DAY: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Enter the MONTH: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter the YEAR: ");
        int year = int.Parse(Console.ReadLine());

        bool validDate = true;
        bool isLeap = false;

        if (year < 1600 || year > 2500)
        {
            Console.WriteLine("Error in year: invalid (1600–2500).");
            validDate = false;
        }

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Error in month: invalid (1–12).");
            validDate = false;
        }

        if (validDate)
        {
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
                isLeap = true;

            int maxDays = month switch
            {
                4 or 6 or 9 or 11 => 30,
                2 => isLeap ? 29 : 28,
                _ => 31
            };

            if (day < 1 || day > maxDays)
            {
                Console.WriteLine($"Error in day: invalid for month {month}.");
                validDate = false;
            }
        }

        if (validDate)
            Console.WriteLine("Valid date");
        else
            Console.WriteLine("The entered date is INVALID.");
    }
}